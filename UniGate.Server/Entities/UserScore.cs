using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGate.Server.Entities;

[Table("UserScores")]
public class UserScore
{
    // --- QUAN HỆ 1-1 VỚI USER ---
    // UserId vừa là Key của bảng này, vừa là Key trỏ về bảng User
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    [ForeignKey("User")]
    public int UserId { get; set; }

    // Navigation Property: Giúp m gọi user.UserScore là ra điểm ngay
    public virtual User? User { get; set; }

    // --- HỌC BẠ (Điểm tối đa 10.00 -> Dùng decimal(4,2) là đủ) ---
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Toan { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Van { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Anh { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Ly { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Hoa { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Sinh { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Su { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_Dia { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_GDKTPL { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? HB_TinHoc { get; set; }

    // --- ĐIỂM THI TN THPT ---
    [Column(TypeName = "decimal(4,2)")] public decimal? Thpt_Toan { get; set; }
    [Column(TypeName = "decimal(4,2)")] public decimal? Thpt_Van { get; set; }

    [MaxLength(50)] // Tên môn tự chọn ngắn thôi (VD: Vật Lý)
    public string? Thpt_TuChon1_Mon { get; set; }

    [Column(TypeName = "decimal(4,2)")] public decimal? Thpt_TuChon1_Diem { get; set; }

    [MaxLength(50)]
    public string? Thpt_TuChon2_Mon { get; set; }

    [Column(TypeName = "decimal(4,2)")] public decimal? Thpt_TuChon2_Diem { get; set; }

    // Điểm ĐGNL thường thang 1200 -> Cần decimal(6,2) cho chắc
    [Column(TypeName = "decimal(6,2)")]
    public decimal? Dgnl_Score { get; set; }

    [MaxLength(10)] // KV1, KV2, KV2-NT
    public string KhuVuc { get; set; } = "";

    [MaxLength(10)] // UT1, UT2
    public string DoiTuong { get; set; } = "";
}

[Table("ScoreDistributions")] // Bảng phổ điểm
public class ScoreDistribution
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(10)] // A00, B00...
    public string GroupCode { get; set; } = "";

    public int Year { get; set; } // 2024, 2025...

    [Column(TypeName = "decimal(5,2)")] // Điểm phổ (VD: 24.5)
    public decimal Score { get; set; }

    public int StudentCount { get; set; } // Số lượng học sinh đạt điểm này
}