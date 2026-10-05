using System.Text.Json.Serialization;

namespace UniGate.Shared.DTOs;

public class UserScoreRequest
{
    public int UserId { get; set; }

    // --- 10 MÔN HỌC BẠ (Trung bình 3 năm) ---
    public decimal? HB_Toan { get; set; }
    public decimal? HB_Van { get; set; }
    public decimal? HB_Anh { get; set; }
    public decimal? HB_Ly { get; set; }
    public decimal? HB_Hoa { get; set; }
    public decimal? HB_Sinh { get; set; }
    public decimal? HB_Su { get; set; }
    public decimal? HB_Dia { get; set; }
    public decimal? HB_GDKTPL { get; set; }
    public decimal? HB_TinHoc { get; set; }

    // --- ĐIỂM THI TNTHPT (2 bắt buộc + 2 tự chọn) ---
    public decimal? Thpt_Toan { get; set; }
    public decimal? Thpt_Van { get; set; }

    public string? Thpt_TuChon1_Mon { get; set; }
    public decimal? Thpt_TuChon1_Diem { get; set; }

    public string? Thpt_TuChon2_Mon { get; set; }
    public decimal? Thpt_TuChon2_Diem { get; set; }

    // --- THÔNG TIN KHÁC ---
    public decimal? Dgnl_Score { get; set; }
    public string KhuVuc { get; set; } = "KV3";
    public string DoiTuong { get; set; } = "BT";
}


public class PercentileResultDto
{
    [JsonPropertyName("subjectGroup")]
    public string SubjectGroup { get; set; }

    [JsonPropertyName("userScore")]
    public decimal UserScore { get; set; }

    [JsonPropertyName("percentile")]
    public double Percentile { get; set; }

    [JsonPropertyName("lowerThanCount")]
    public int LowerThanCount { get; set; }

    [JsonPropertyName("totalCandidates")]
    public int TotalCandidates { get; set; }
}