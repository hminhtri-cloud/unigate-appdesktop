namespace UniGate.Shared.DTOs;

public class UserDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = ""; // Dùng để nhập pass mới
    public string Role { get; set; } = "Student"; // Student hoặc Admin
    public string Region { get; set; } = "Miền Nam"; // Miền Bắc/Trung/Nam
    public DateTime CreatedAt { get; set; }
}