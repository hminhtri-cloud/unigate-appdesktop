namespace UniGate.Shared.DTOs;
public class ScoreDistributionDto
{
    public int Id { get; set; }
    public string GroupCode { get; set; } = "";
    public int Year { get; set; }
    public decimal Score { get; set; }
    public int StudentCount { get; set; }
}