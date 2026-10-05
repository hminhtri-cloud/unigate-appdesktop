using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGate.Server.Entities;

[Table("HollandQuestions")] // Đặt tên bảng rõ ràng trong SQL
public class HollandQuestion
{
    [Key]
    public int Id { get; set; }

    [Required] // Bắt buộc phải nhập
    [MaxLength(500)] // Tối đa 500 ký tự (tiết kiệm hơn để max)
    public string Content { get; set; } = "";

    [Required]
    [MaxLength(1)] // Chỉ lưu 1 ký tự: R, I, A, S, E, hoặc C
    [Column(TypeName = "char(1)")] // Tối ưu cứng trong SQL
    public string Group { get; set; } = "";
}

[Table("HollandResults")]
public class HollandResult
{
    [Key]
    public int Id { get; set; }

    // --- KHÓA NGOẠI (Foreign Key) ---
    // Cái này quan trọng nè, giúp liên kết với bảng User
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User? User { get; set; } // Để virtual để EF Core tự load thông tin User

    [Required]
    [MaxLength(10)] // Ví dụ: "RIA", "SAE" (Cho dư ra chút phòng hờ)
    public string HollandCode { get; set; } = "";

    public DateTime TestDate { get; set; } = DateTime.Now;
}