using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;
using BCrypt.Net;

namespace UniGate.Server.Controllers;

[Route("api/admin/users")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminUsersController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminUsersController(AppDbContext db) => _db = db;

    // 1. LẤY DANH SÁCH
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _db.Users.OrderByDescending(u => u.UserID).ToListAsync(); // Sửa Id -> UserID

        var dtos = users.Select(u => new UserDto
        {
            Id = u.UserID, // Map UserID của DB sang Id của DTO
            FullName = u.FullName,
            Email = u.Email,
            Role = u.Role,
            Region = "Việt Nam", // Mặc định, vì DB không có cột này
            CreatedAt = u.CreatedAt,
            Password = "" // Luôn giấu mật khẩu
        });

        return Ok(dtos);
    }

    // 2. THÊM MỚI
    [HttpPost]
    public async Task<IActionResult> Create(UserDto dto)
    {
        if (await _db.Users.AnyAsync(u => u.Email == dto.Email))
            return BadRequest("Email này đã tồn tại!");

        var user = new User
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Role = dto.Role,
            // Mã hóa mật khẩu
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            // RegionID: ĐÃ BỎ
            CreatedAt = DateTime.Now
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Tạo người dùng thành công!" });
    }

    // 3. CẬP NHẬT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UserDto dto)
    {
        // Tìm theo UserID
        var user = await _db.Users.FindAsync(id);
        if (user == null) return NotFound("Không tìm thấy user");

        user.FullName = dto.FullName;
        user.Role = dto.Role;
        // Region: ĐÃ BỎ

        // Chỉ đổi mật khẩu nếu Admin có nhập
        if (!string.IsNullOrEmpty(dto.Password))
        {
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
        }

        await _db.SaveChangesAsync();
        return Ok(new { message = "Cập nhật thành công!" });
    }

    // 4. XÓA
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _db.Users.FindAsync(id);
        if (user == null) return NotFound();

        _db.Users.Remove(user);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa người dùng!" });
    }
}