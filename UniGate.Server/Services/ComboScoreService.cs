using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Services;

public class ComboScoreService
{
    // 1. Định nghĩa danh sách các tổ hợp phổ biến
    private readonly Dictionary<string, string[]> _combinations = new()
    {
        { "A00", new[] { "Toán", "Vật lý", "Hóa học" } },
        { "A01", new[] { "Toán", "Vật lý", "Tiếng Anh" } },
        { "D01", new[] { "Toán", "Ngữ văn", "Tiếng Anh" } },
        { "D07", new[] { "Toán", "Hóa học", "Tiếng Anh" } },
        { "B00", new[] { "Toán", "Hóa học", "Sinh học" } },
        { "C00", new[] { "Ngữ văn", "Lịch sử", "Địa lý" } }
    };

    public List<CombinationScoreDto> CalculateThptCombinations(UserScore score)
    {
        var results = new List<CombinationScoreDto>();
        decimal bonus = CalculateBonus(score.KhuVuc, score.DoiTuong);

        foreach (var combo in _combinations)
        {
            decimal total = 0;
            bool missingSubject = false;

            foreach (var subject in combo.Value)
            {
                decimal? subjectScore = GetScoreBySubjectName(score, subject);
                if (subjectScore == null)
                {
                    missingSubject = true;
                    break;
                }
                total += subjectScore.Value;
            }

            if (!missingSubject)
            {
                // Áp dụng công thức giảm điểm ưu tiên nếu tổng >= 22.5 (Quy chế Bộ GD)
                decimal finalBonus = total >= 22.5m ? ((30m - total) / 7.5m) * bonus : bonus;

                results.Add(new CombinationScoreDto
                {
                    GroupCode = combo.Key,
                    Subjects = string.Join(", ", combo.Value),
                    TotalScore = Math.Round(total + finalBonus, 2),
                    IsEligible = true
                });
            }
        }
        return results.OrderByDescending(x => x.TotalScore).ToList();
    }

    // Hàm lấy điểm dựa trên tên môn (Hỗ trợ 2+2)
    private decimal? GetScoreBySubjectName(UserScore s, string name)
    {
        if (name == "Toán") return s.Thpt_Toan;
        if (name == "Ngữ văn") return s.Thpt_Van;

        // Kiểm tra 2 môn tự chọn
        if (s.Thpt_TuChon1_Mon == name) return s.Thpt_TuChon1_Diem;
        if (s.Thpt_TuChon2_Mon == name) return s.Thpt_TuChon2_Diem;

        return null;
    }

    private decimal CalculateBonus(string kv, string dt)
    {
        decimal kvScore = kv switch { "KV1" => 0.75m, "KV2-NT" => 0.5m, "KV2" => 0.25m, _ => 0 };
        decimal dtScore = dt switch { "ƯT1" => 2.0m, "ƯT2" => 1.0m, _ => 0 };
        return kvScore + dtScore;
    }
}