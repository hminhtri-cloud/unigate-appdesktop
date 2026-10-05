using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGate.Server.Entities;

[Table("Universities")]
public class University
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)] // Mã trường ngắn thôi (ví dụ: QSC, KSA)
    public string Code { get; set; } = "";

    [Required]
    [MaxLength(255)] // Tên trường
    public string Name { get; set; } = "";

    [MaxLength(500)]
    public string LogoUrl { get; set; } = "";

    [MaxLength(100)]
    public string Region { get; set; } = ""; // Miền Nam, Miền Bắc...

    [MaxLength(500)]
    public string Address { get; set; } = "";

    [MaxLength(255)]
    public string Website { get; set; } = "";

    public string Description { get; set; } = "";

    // --- NAVIGATION PROPERTY ---
    // Giúp m từ Trường có thể lấy danh sách Ngành dễ dàng: university.Majors
    public virtual ICollection<Major> Majors { get; set; } = new List<Major>();
}

[Table("Majors")]
public class Major
{
    [Key]
    public int Id { get; set; }

    // --- KHÓA NGOẠI (Thay vì lưu tên trường, ta lưu ID) ---
    public int UniversityId { get; set; }

    [ForeignKey("UniversityId")]
    public virtual University? University { get; set; } // Để link sang bảng University

    [Required]
    [MaxLength(255)]
    public string MajorName { get; set; } = "";

    [MaxLength(50)]
    public string MajorCode { get; set; } = "";

    [MaxLength(10)]
    public string GroupCode { get; set; } = ""; // A00, A01...

    [Column(TypeName = "decimal(5,2)")] // Điểm chuẩn tối đa 40.00, cần 2 số thập phân
    public decimal CutoffScore { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? DgnlCutoff { get; set; }

    [Column(TypeName = "decimal(18,2)")] // Học phí cần số lớn
    public decimal Tuition { get; set; }

    [MaxLength(50)]
    public string? HollandCode { get; set; }    // R, I, A, S, E, C

    public string? Description { get; set; }
}