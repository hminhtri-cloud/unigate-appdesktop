using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGate.Server.Entities;

[Table("UserFavorites")] // Đặt tên bảng số nhiều cho chuẩn
public class UserFavorite
{
    [Key]
    public int Id { get; set; }

    // --- LIÊN KẾT VỚI USER ---
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User? User { get; set; } // Để biết ai là người lưu

    // --- LIÊN KẾT VỚI MAJOR (NGÀNH HỌC) ---
    public int MajorId { get; set; }

    [ForeignKey("MajorId")]
    public virtual Major? Major { get; set; } // Để lấy thông tin: Tên ngành, Điểm chuẩn...

    public DateTime SavedAt { get; set; } = DateTime.Now;
}