namespace UniGate.Shared.DTOs;

public class DashboardStatsDto
{
    public int TotalUsers { get; set; }
    public int TotalUniversities { get; set; }
    public int TotalMajors { get; set; }

    // Dữ liệu cho biểu đồ: Key=Tên khu vực, Value=Số lượng
    public Dictionary<string, int> UnisByRegion { get; set; } = new();
}