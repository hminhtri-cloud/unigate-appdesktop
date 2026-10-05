using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UniGate.Server.Entities;
using UniGate.Server.Services;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class RecommendationController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly ComboScoreService _comboService;

    public RecommendationController(AppDbContext db, ComboScoreService comboService)
    {
        _db = db;
        _comboService = comboService;
    }

    // 1. GỢI Ý THEO ĐIỂM
    [HttpGet("by-score")]
    public async Task<IActionResult> GetByScore([FromQuery] decimal margin = 1.0m)
    {
        var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();
        var userId = int.Parse(userIdStr);

        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);
        if (score == null) return BadRequest("Chưa nhập điểm!");

        var userComboScores = _comboService.CalculateThptCombinations(score);
        // Chỉ lấy những ngành có mã tổ hợp mà user có điểm
        var userGroupCodes = userComboScores.Select(x => x.GroupCode).ToList();

        var allMajors = await _db.Majors
            .Include(m => m.University)
            .Where(m => userGroupCodes.Contains(m.GroupCode)) // Lọc ngay từ SQL cho nhanh
            .ToListAsync();

        var recommendations = new List<MajorRecommendationDto>();

        foreach (var major in allMajors)
        {
            var userGroupScore = userComboScores.FirstOrDefault(x => x.GroupCode == major.GroupCode);
            if (userGroupScore != null)
            {
                decimal diff = userGroupScore.TotalScore - major.CutoffScore;

                // Logic phân loại dựa trên margin của Trí
                string status = diff switch
                {
                    var d when d >= margin => "An toàn",
                    var d when d >= 0 => "Mục tiêu",
                    var d when d >= -margin => "Mạo hiểm",
                    _ => "Rất khó"
                };

                // Tùy chọn: Chỉ add những ngành từ "Mạo hiểm" trở lên để danh sách "sạch" hơn
                if (diff >= -(margin + 2.0m))
                {
                    recommendations.Add(new MajorRecommendationDto
                    {
                        MajorId = major.Id,
                        UniversityName = major.University?.Name ?? "",
                        MajorName = major.MajorName,
                        GroupCode = major.GroupCode,
                        CutoffScore = major.CutoffScore,
                        UserScore = userGroupScore.TotalScore,
                        Deviation = diff,
                        Status = status
                    });
                }
            }
        }
        // Sắp xếp: Ưu tiên những ngành có Deviation (độ lệch) tốt nhất lên đầu
        return Ok(recommendations.OrderByDescending(x => x.Deviation));
    }

    // 2. THEO TỔ HỢP
    [HttpGet("by-targets")]
    public async Task<IActionResult> GetByTargets()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
        var targets = await _db.UserTargets.Where(t => t.UserId == userId).Select(t => t.GroupCode).ToListAsync();

        var majors = await _db.Majors
            .Include(m => m.University)
            .Where(m => targets.Contains(m.GroupCode))
            .Select(m => new MajorRecommendationDto
            {
                MajorId = m.Id, // 👈 QUAN TRỌNG
                UniversityName = m.University != null ? m.University.Name : "",
                MajorName = m.MajorName,
                GroupCode = m.GroupCode,
                CutoffScore = m.CutoffScore,
                Status = "Phù hợp tổ hợp"
            })
            .ToListAsync();
        return Ok(majors);
    }

    [HttpGet("by-holland")]
    public async Task<IActionResult> GetByHolland()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);

        // Lấy kết quả Holland mới nhất
        var holland = await _db.HollandResults
            .Where(r => r.UserId == userId)
            .OrderByDescending(r => r.TestDate)
            .FirstOrDefaultAsync();

        if (score == null || holland == null) return BadRequest("Thiếu dữ liệu điểm hoặc Holland!");

        var userComboScores = _comboService.CalculateThptCombinations(score);

        // 1. Chuyển mã của User thành mảng ký tự để dễ so sánh (VD: "RIA" -> ['R', 'I', 'A'])
        var userCodes = holland.HollandCode.ToCharArray();

        // 2. Lấy danh sách ngành có mã Holland từ DB
        // (Vẫn giữ logic lọc sơ bộ tại SQL để tối ưu hiệu năng)
        var majors = await _db.Majors
            .Include(m => m.University)
            .Where(m => m.HollandCode != null && m.HollandCode != "")
            .ToListAsync();

        // 3. Xử lý Logic đánh giá mức độ phù hợp (Client Evaluation)
        var recommendations = majors
            // Lọc: Chỉ lấy những ngành trùng ít nhất 1 ký tự
            .Where(m => userCodes.Any(c => m.HollandCode!.Contains(c)))
            .Select(m => {
                var bestCombo = userComboScores.FirstOrDefault(x => x.GroupCode == m.GroupCode);

                // --- LOGIC MỚI: ĐẾM ĐỘ TRÙNG KHỚP ---
                // Đếm xem mã ngành chứa bao nhiêu ký tự trong mã của User
                int matchCount = userCodes.Count(c => m.HollandCode!.Contains(c));

                // Đánh giá dựa trên số lượng trùng
                string statusText = matchCount switch
                {
                    >= 3 => "Rất phù hợp (3/3)", // Trùng 3 ký tự trở lên (Perfect Match)
                    2 => "Khá ổn (2/3)",      // Trùng 2 ký tự
                    _ => "Tạm được (1/3)"     // Trùng 1 ký tự
                };

                return new MajorRecommendationDto
                {
                    MajorId = m.Id,
                    UniversityName = m.University?.Name ?? "",
                    MajorName = m.MajorName,

                    // M muốn trả về Mã tính cách thì t kẹp nó vào đây luôn cho tiện hiển thị
                    // VD: "A00 (RIA)"
                    GroupCode = $"{m.GroupCode} ({m.HollandCode})",

                    CutoffScore = m.CutoffScore,
                    UserScore = bestCombo?.TotalScore ?? 0,

                    // Trả về câu đánh giá xịn xò
                    Status = statusText,

                    Deviation = (bestCombo?.TotalScore ?? 0) - m.CutoffScore,

                    // Dùng biến này để sắp xếp: Ưu tiên hợp tính cách nhất (3) -> rồi mới tới 2, 1
                    // Mẹo: Gán vào biến tạm nào đó nếu DTO có, hoặc t sẽ OrderBy bên dưới
                };
            })
            // Sắp xếp: Ưu tiên "Rất phù hợp" lên đầu, sau đó mới xét tới điểm số
            .OrderByDescending(x => x.Status) // Rất phù hợp > Khá ổn > Tạm được (theo bảng chữ cái R > K > T hơi ngược, nên sort tay bên dưới chuẩn hơn)
            .ThenByDescending(x => x.Deviation) // Sau đó mới xếp theo điểm dư
            .ToList();

        // Sắp xếp lại thủ công cho chuẩn Logic (3 -> 2 -> 1)
        recommendations = recommendations.OrderByDescending(x =>
            x.Status.Contains("3/3") ? 3 :
            x.Status.Contains("2/3") ? 2 : 1)
            .ThenByDescending(x => x.Deviation)
            .ToList();

        return Ok(recommendations);
    }
    [HttpGet("by-dgnl")]
    public async Task<IActionResult> GetByDgnl([FromQuery] decimal margin = 50.0m) // Thêm FromQuery để đồng bộ
    {
        var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value!);
        var userScore = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);

        if (userScore == null || userScore.Dgnl_Score == null || userScore.Dgnl_Score == 0)
            return BadRequest("Bạn chưa nhập điểm Đánh giá năng lực trong mục Hồ sơ!");

        // Lấy các ngành có xét tuyển ĐGNL từ SQL
        var majors = await _db.Majors.Include(m => m.University)
            .Where(m => m.DgnlCutoff.HasValue && m.DgnlCutoff > 0)
            .ToListAsync();

        var recommendations = majors.Select(m => {
            decimal diff = userScore.Dgnl_Score.Value - m.DgnlCutoff.Value;

            // Tận dụng cái margin biến thiên từ Client gửi xuống
            string status = diff switch
            {
                var d when d >= margin => "An toàn",
                var d when d >= 0 => "Mục tiêu",
                var d when d >= -margin => "Mạo hiểm",
                _ => "Rất khó"
            };

            return new MajorRecommendationDto
            {
                MajorId = m.Id,
                UniversityName = m.University?.Name ?? "",
                MajorName = m.MajorName,
                GroupCode = "ĐGNL",
                CutoffScore = m.DgnlCutoff.Value,
                UserScore = userScore.Dgnl_Score.Value,
                Deviation = diff, // Quan trọng để Client sắp xếp
                Status = status
            };
        }).OrderByDescending(x => x.Deviation).ToList();

        return Ok(recommendations);
    }

    [HttpGet("best-fit")]
    public async Task<IActionResult> GetBestFit()
    {
        var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();
        var userId = int.Parse(userIdStr);

        // 1. Lấy dữ liệu đầu vào
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);
        var targetGroups = await _db.UserTargets.Where(t => t.UserId == userId).Select(t => t.GroupCode).ToListAsync();
        var holland = await _db.HollandResults.Where(r => r.UserId == userId).OrderByDescending(r => r.TestDate).FirstOrDefaultAsync();

        if (score == null || holland == null) return BadRequest("Bạn cần nhập điểm và làm trắc nghiệm Holland trước!");

        var userComboScores = _comboService.CalculateThptCombinations(score);
        var allMajors = await _db.Majors.Include(m => m.University).ToListAsync();
        var results = new List<MajorRecommendationDto>();

        foreach (var m in allMajors)
        {
            // A. Kiểm tra mức độ hợp tính cách (Holland)
            // Nếu ngành ko có mã Holland thì coi như ko ưu tiên, nhưng ko loại bỏ
            bool isHollandMatch = !string.IsNullOrEmpty(m.HollandCode) && holland.HollandCode.Any(c => m.HollandCode.Contains(c));

            // B. Lấy điểm của user cho khối thi của ngành này
            var uScore = userComboScores.FirstOrDefault(x => x.GroupCode == m.GroupCode);
            if (uScore == null) continue; // Ko có điểm khối này thì chịu

            decimal diff = uScore.TotalScore - m.CutoffScore;
            string status = "";
            int matchScore = 0; // Dùng để sắp xếp

            // C. Phân loại Trạng thái & Tính điểm ưu tiên
            if (isHollandMatch && diff >= 0)
            {
                status = "🌟 PERFECT MATCH"; // Vừa hợp tính cách, vừa đủ điểm
                matchScore = 100;
            }
            else if (isHollandMatch && diff >= -1.5m)
            {
                status = "🚀 NGÀNH MƠ ƯỚC"; // Hợp tính cách, thiếu chút điểm (mơ ước)
                matchScore = 80;
            }
            else if (diff >= 0.5m)
            {
                status = "✅ PHÙ HỢP ĐIỂM"; // Đủ điểm nhưng tính cách có thể ko khớp lắm
                matchScore = 60;
            }
            else if (targetGroups.Contains(m.GroupCode) && diff >= -1.0m)
            {
                status = "⚖️ TIỀM NĂNG"; // Đúng khối mục tiêu, điểm mấp mé
                matchScore = 40;
            }
            else continue; // Các ngành quá xa vời hoặc ko liên quan thì bỏ qua cho đỡ rác

            results.Add(new MajorRecommendationDto
            {
                MajorId = m.Id,
                UniversityName = m.University?.Name ?? "",
                MajorName = m.MajorName,
                GroupCode = m.GroupCode,
                CutoffScore = m.CutoffScore,
                UserScore = uScore.TotalScore,
                Deviation = diff,
                Status = status,
                // M có thể thêm 1 field MatchScore vào DTO nếu muốn sort chính xác hơn
            });
        }

        // Sắp xếp: Ngành xịn nhất lên đầu
        return Ok(results.OrderByDescending(x => x.Status == "🌟 PERFECT MATCH")
                         .ThenByDescending(x => x.Status == "🚀 NGÀNH MƠ ƯỚC")
                         .ThenByDescending(x => x.Deviation));
    }
}