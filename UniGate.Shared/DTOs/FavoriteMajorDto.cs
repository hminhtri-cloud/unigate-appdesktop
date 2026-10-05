namespace UniGate.Shared.DTOs;
public class FavoriteMajorDto
{
    public int MajorId { get; set; }
    public string UniversityName { get; set; } = ""; // Tên trường
    public string MajorName { get; set; } = "";
    public string GroupCode { get; set; } = "";
    public decimal CutoffScore { get; set; }
    public DateTime SavedAt { get; set; }
}