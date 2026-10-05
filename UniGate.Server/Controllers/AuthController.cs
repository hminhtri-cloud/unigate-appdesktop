using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly IConfiguration _config;

    public AuthController(AppDbContext db, IConfiguration config)
    {
        _db = db;
        _config = config;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest req)
    {
        if (await _db.Users.AnyAsync(u => u.Email == req.Email))
            return BadRequest("Email đã tồn tại.");

        var user = new User
        {
            Email = req.Email,
            FullName = req.FullName,
            // Mã hóa mật khẩu trước khi lưu vào MySQL
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(req.Password),
            Role = "Student"
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();
        return Ok("Đăng ký thành công!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest req)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == req.Email);

        if (user == null || !BCrypt.Net.BCrypt.Verify(req.Password, user.PasswordHash))
            return Unauthorized("Sai tài khoản hoặc mật khẩu.");

        // Tạo Token JWT
        var claims = new[] {
            new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["JwtSettings:Issuer"],
            audience: _config["JwtSettings:Audience"],
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
        );

        return Ok(new AuthResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            FullName = user.FullName,
            UserId = user.UserID,
            Email = user.Email,
            Role = user.Role
        });
    }

    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto dto)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
        if (user == null) return NotFound("Email này không có trong hệ thống m ơi!");

        // 1. Tạo mã OTP
        string otp = new Random().Next(100000, 999999).ToString();

        // 2. Lưu vào DB
        user.ResetCode = otp;
        user.ResetCodeExpiration = DateTime.Now.AddMinutes(5);
        await _db.SaveChangesAsync();

        // 3. Gửi Email thật (Gọi hàm helper bên dưới)
        try
        {
            await SendEmailAsync(user.Email, otp);
            // Quan trọng: Trả về thông báo thành công, KHÔNG trả về mã OTP nữa!
            return Ok(new { message = "Đã gửi mã OTP về email của m rồi đó, check đi!" });
        }
        catch (Exception ex)
        {
            return BadRequest("Lỗi gửi mail: " + ex.Message);
        }
    }

    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto dto)
    {
        // 1. Tìm user khớp cả Email và mã OTP
        var user = await _db.Users.FirstOrDefaultAsync(u =>
            u.Email == dto.Email && u.ResetCode == dto.OTP);

        // 2. Kiểm tra nếu không thấy hoặc mã hết hạn
        if (user == null || user.ResetCodeExpiration < DateTime.Now)
        {
            return BadRequest("Mã OTP không đúng hoặc đã hết hạn rồi m ơi!");
        }

        // 3. Mã hóa mật khẩu mới bằng BCrypt (phải khớp với logic lúc Register)
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);

        // 4. Xóa mã OTP và thời gian hết hạn sau khi dùng xong
        user.ResetCode = null;
        user.ResetCodeExpiration = null;

        // 5. Lưu thay đổi vào MySQL bằng biến _db
        await _db.SaveChangesAsync();

        return Ok("Đổi mật khẩu thành công rồi đó! Giờ m đăng nhập lại thử đi.");
    }

    private async Task SendEmailAsync(string toEmail, string otp)
    {
        string fromMail = _config["EmailSettings:Mail"]!;
        string fromPassword = _config["EmailSettings:Password"]!;
        string host = _config["EmailSettings:Host"]!;
        int port = int.Parse(_config["EmailSettings:Port"]!);

        var message = new MailMessage();
        message.From = new MailAddress(fromMail, "UniGate System");
        message.To.Add(new MailAddress(toEmail));
        message.Subject = "[UniGate] Mã xác nhận lấy lại mật khẩu";

        // Nội dung Email (HTML cho đẹp)
        message.Body = $@"
            <html>
            <body>
                <h2>Xin chào,</h2>
                <p>Bạn vừa yêu cầu lấy lại mật khẩu cho tài khoản UniGate.</p>
                <p>Mã xác nhận (OTP) của bạn là: <b style='color:red; font-size: 20px;'>{otp}</b></p>
                <p>Mã này có hiệu lực trong 5 phút. Vui lòng không chia sẻ cho ai khác.</p>
                <br/>
                <p>Thân ái,<br/>Đội ngũ UniGate</p>
            </body>
            </html>";
        message.IsBodyHtml = true;

        using var smtp = new SmtpClient(host, port);
        smtp.EnableSsl = true; // Gmail bắt buộc cái này
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new NetworkCredential(fromMail, fromPassword);

        await smtp.SendMailAsync(message);
    }
}