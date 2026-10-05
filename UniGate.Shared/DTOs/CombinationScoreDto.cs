namespace UniGate.Shared.DTOs;

public class CombinationScoreDto
{
    public string GroupCode { get; set; } = ""; // A00, A01, D01...
    public string Subjects { get; set; } = "";  // Toán, Lý, Hóa...
    public decimal TotalScore { get; set; }     // Tổng điểm đã cộng ưu tiên
    public bool IsEligible { get; set; }        // Có đủ 3 môn để xét tổ hợp này không
}