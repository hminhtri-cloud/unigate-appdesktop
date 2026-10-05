using System;
using System.Collections.Generic;
using System.Linq;
using UniGate.Shared.DTOs;

namespace UniGate.Student.Helpers // M nhớ namespace này nhé
{
    public static class ScoreHelper
    {
        // Định nghĩa các tổ hợp môn
        private static readonly Dictionary<string, string[]> _combinations = new Dictionary<string, string[]>
        {
            { "A00", new[] { "Toán", "Vật lí", "Hóa học" } },
            { "A01", new[] { "Toán", "Vật lí", "Tiếng Anh" } },
            { "B00", new[] { "Toán", "Hóa học", "Sinh học" } },
            { "C00", new[] { "Ngữ văn", "Lịch sử", "Địa lí" } },
            { "D01", new[] { "Toán", "Ngữ văn", "Tiếng Anh" } },
            { "D07", new[] { "Toán", "Hóa học", "Tiếng Anh" } },
            { "H00", new[] { "Ngữ văn", "Năng khiếu 1", "Năng khiếu 2" } } // Ví dụ thêm
        };

        public static decimal Calculate(string groupCode, UserScoreRequest score)
        {
            if (!_combinations.ContainsKey(groupCode) || score == null) return 0;

            var subjects = _combinations[groupCode];
            decimal total = 0;
            bool missingSubject = false;

            foreach (var subject in subjects)
            {
                decimal? sScore = GetScoreBySubjectName(score, subject);
                if (sScore == null)
                {
                    missingSubject = true;
                    break;
                }
                total += sScore.Value;
            }

            if (missingSubject) return 0;

            // Cộng điểm ưu tiên (Khu vực + Đối tượng)
            decimal bonus = CalculateBonus(score.KhuVuc, score.DoiTuong);

            // Quy tắc làm tròn và điểm liệt (nếu cần)
            return total + bonus;
        }

        private static decimal? GetScoreBySubjectName(UserScoreRequest s, string name)
        {
            // 1. Môn bắt buộc
            if (IsMatch(name, "Toán")) return s.Thpt_Toan;
            if (IsMatch(name, "Ngữ văn")) return s.Thpt_Van;
            if (IsMatch(name, "Tiếng Anh")) return s.HB_Anh; // Tạm dùng HB Anh nếu chưa có điểm thi, hoặc s.Thpt_Anh nếu có

            // 2. Môn học bạ (nếu m muốn dùng HB để thay thế khi chưa thi)
            // if (IsMatch(name, "Vật lí")) return s.HB_Ly; 
            // ... (Tùy logic m muốn ưu tiên cái nào)

            // 3. Môn tự chọn (Quan trọng nhất: 2 môn tự chọn trong DTO)
            if (IsMatch(s.Thpt_TuChon1_Mon, name)) return s.Thpt_TuChon1_Diem;
            if (IsMatch(s.Thpt_TuChon2_Mon, name)) return s.Thpt_TuChon2_Diem;

            // 4. Map ngược lại vào các môn học bạ nếu môn tự chọn ko có (Backup)
            if (IsMatch(name, "Vật lí")) return s.HB_Ly;
            if (IsMatch(name, "Hóa học")) return s.HB_Hoa;
            if (IsMatch(name, "Sinh học")) return s.HB_Sinh;
            if (IsMatch(name, "Lịch sử")) return s.HB_Su;
            if (IsMatch(name, "Địa lí")) return s.HB_Dia;
            if (IsMatch(name, "GDCD")) return s.HB_GDKTPL;

            return null;
        }

        private static bool IsMatch(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
            // So sánh không phân biệt hoa thường và dấu (để Vật lý == Vật lí)
            return string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase) == 0 ||
                   (s1.Contains("Lý") && s2.Contains("Lí")) ||
                   (s1.Contains("Lí") && s2.Contains("Lý"));
        }

        private static decimal CalculateBonus(string kv, string dt)
        {
            decimal kvScore = kv switch { "KV1" => 0.75m, "KV2-NT" => 0.5m, "KV2" => 0.25m, _ => 0 };
            decimal dtScore = dt switch { "ƯT1" => 2.0m, "ƯT2" => 1.0m, _ => 0 };
            return kvScore + dtScore;
        }
    }
}