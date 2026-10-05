using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.Services;

public class AuthService
{
    // Gọi qua cổng Load Balancer
    private readonly HttpClient _http = new()
    {
        BaseAddress = new Uri("https://verbless-leona-unwrought.ngrok-free.dev/")
    };

    public async Task<(bool success, string message)> RegisterAsync(RegisterRequest req)
    {
        try
        {
            // Gọi API qua Load Balancer (Port 7030)
            var res = await _http.PostAsJsonAsync("api/Auth/register", req);

            if (res.IsSuccessStatusCode)
            {
                return (true, "Đăng ký thành công!");
            }

            // Lấy thông báo lỗi từ Server (ví dụ: "Email đã tồn tại")
            var error = await res.Content.ReadAsStringAsync();
            return (false, error);
        }
        catch (Exception)
        {
            return (false, "Lỗi kết nối Server. Vui lòng kiểm tra Load Balancer.");
        }
    }

    public async Task<(bool success, string message)> LoginAsync(string email, string password)
    {
        try
        {
            var req = new LoginRequest { Email = email, Password = password };
            var res = await _http.PostAsJsonAsync("api/Auth/login", req);

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadFromJsonAsync<AuthResponse>();
                if (data != null)
                {
                    // Lưu trạng thái vào Session
                    UserSession.Token = data.Token;
                    UserSession.FullName = data.FullName;
                    UserSession.UserId = data.UserId;
                    UserSession.Role = data.Role;
                    return (true, "Thành công");
                }
            }

            var error = await res.Content.ReadAsStringAsync();
            return (false, error ?? "Sai tài khoản hoặc mật khẩu");
        }
        catch (Exception ex)
        {
            return (false, "Không thể kết nối tới Server. Hãy kiểm tra Load Balancer!");
        }
    }
}