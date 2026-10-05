using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; // Thêm cái này để dùng [Index]

namespace UniGate.Server.Entities;

[Table("Users")]
[Index(nameof(Email), IsUnique = true)] // QUAN TRỌNG: Cấm trùng Email ở cấp độ Database
public class User
{
    [Key]
    public int UserID { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress] // Tự động kiểm tra định dạng a@b.c
    public string Email { get; set; } = "";

    [Required]
    [MaxLength(255)] // Password Hash thường dài cố định, nhưng để 255 cho an toàn
    public string PasswordHash { get; set; } = "";

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = "";

    [MaxLength(20)]
    public string Role { get; set; } = "Student"; // "Admin" hoặc "Student"

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [MaxLength(10)] // Mã OTP thường chỉ 6 số
    public string? ResetCode { get; set; }

    public DateTime? ResetCodeExpiration { get; set; }

    // --- CÁC MỐI QUAN HỆ (Navigation Properties) ---
    // Giúp m truy vấn ngược cực nhanh: user.Favorites, user.HollandResults...

    // 1 User có nhiều kết quả Holland
    public virtual ICollection<HollandResult> HollandResults { get; set; } = new List<HollandResult>();

    // 1 User có nhiều Ngành yêu thích
    public virtual ICollection<UserFavorite> Favorites { get; set; } = new List<UserFavorite>();

    // 1 User có 1 bảng Điểm (Quan hệ 1-1)
    public virtual UserScore? UserScore { get; set; }
}