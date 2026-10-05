using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGate.Server.Entities;

[Table("UserTargets")] // Đặt tên bảng số nhiều
public class UserTarget
{
    [Key]
    public int Id { get; set; }

    // --- LIÊN KẾT VỚI USER ---
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User? User { get; set; } // Navigation Property: Giúp m gọi userTarget.User là ra info sinh viên

    [Required]
    [MaxLength(10)] // Mã khối (A00, D01...) chỉ cần 3-5 ký tự, t để 10 là dư xài
    public string GroupCode { get; set; } = "";
}