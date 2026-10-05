namespace UniGate.Shared.DTOs;

public class MajorDetailDto
{
    public int Id { get; set; }
    public int UniversityId { get; set; }
    public string UniversityName { get; set; } = "";
    public string MajorName { get; set; } = "";
    public string MajorCode { get; set; } = "";
    public string GroupCode { get; set; } = "";
    public decimal CutoffScore { get; set; }

    // --- BỔ SUNG MẤY CÁI NÀY ĐỂ SO SÁNH ---
    public decimal Tuition { get; set; }       // Học phí
    public string? HollandCode { get; set; }   // Mã Holland
    public string? Description { get; set; }   // Mô tả
}