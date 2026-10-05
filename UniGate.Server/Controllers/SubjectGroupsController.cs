using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UniGate.Server.Entities;
using UniGate.Server.Services;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubjectGroupsController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly ComboScoreService _comboService;
    public SubjectGroupsController(AppDbContext db, ComboScoreService comboService)
    {
        _db = db;
        _comboService = comboService;
    }

    [HttpGet] // Lấy toàn bộ danh sách khối (A00, A01...)
    public async Task<IActionResult> GetGroups()
    {
        var list = await _db.SubjectGroups.ToListAsync();
        return Ok(list);
    }
    [HttpPost("set-target")]
    public async Task<IActionResult> SetTarget([FromBody] UserTargetDto target)
    {
        // 1. Lấy UserId từ Token (Chuẩn bảo mật)
        var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdStr)) return Unauthorized("Không tìm thấy phiên đăng nhập");
        var userId = int.Parse(userIdStr);

        if (string.IsNullOrEmpty(target.GroupCode)) return BadRequest("Mã khối không được để trống");

        // 2. Tìm xem trong DB đã có dòng này chưa
        var existing = await _db.UserTargets
            .FirstOrDefaultAsync(x => x.UserId == userId && x.GroupCode == target.GroupCode);

        if (existing != null)
        {
            // ĐÃ CÓ -> XÓA (Hủy chọn)
            _db.UserTargets.Remove(existing);
            await _db.SaveChangesAsync();
            return Ok(new { message = $"Đã bỏ chọn khối {target.GroupCode}", isSelected = false });
        }
        else
        {
            // CHƯA CÓ -> THÊM (Chọn mới)
            var newTarget = new UserTarget { UserId = userId, GroupCode = target.GroupCode };
            _db.UserTargets.Add(newTarget);
            await _db.SaveChangesAsync();
            return Ok(new { message = $"Đã chọn khối {target.GroupCode}", isSelected = true });
        }
    }

    // --- 4. THỐNG KÊ CÁC KHỐI MỤC TIÊU ---
    [HttpGet("my-targets-stats")]
    public async Task<IActionResult> GetMyTargetsStats()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
        var userScore = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);
        if (userScore == null) return BadRequest("Chưa nhập điểm!");

        var targetGroups = await _db.UserTargets.Where(t => t.UserId == userId).Select(t => t.GroupCode).ToListAsync();
        if (!targetGroups.Any()) return Ok(new List<PercentileResultDto>());

        var allCombos = _comboService.CalculateThptCombinations(userScore);
        var resultList = new List<PercentileResultDto>();

        foreach (var groupCode in targetGroups)
        {
            var combo = allCombos.FirstOrDefault(c => c.GroupCode == groupCode);
            if (combo != null && combo.IsEligible)
            {
                var stats = await CalculatePercentileInternal(groupCode, combo.TotalScore);
                resultList.Add(stats);
            }
        }
        return Ok(resultList.OrderByDescending(x => x.Percentile).ToList());
    }

    [HttpGet("dashboard-stats")]
    public async Task<IActionResult> GetDashboardStats()
    {
        // 1. Lấy UserId từ Token (Dùng ClaimTypes.NameIdentifier là chuẩn nhất)
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdClaim)) return Unauthorized();
        var userId = int.Parse(userIdClaim);

        var stats = new StudentDashboardStatsDto();

        // A. Lấy Tên sinh viên
        var user = await _db.Users.FindAsync(userId);
        stats.FullName = user?.FullName ?? "Sinh viên";

        // B. Lấy Điểm Cao Nhất (Dùng ComboService của m là chuẩn rồi)
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);
        if (score != null)
        {
            var combos = _comboService.CalculateThptCombinations(score);
            var validCombos = combos.Where(c => c.IsEligible).ToList();
            stats.HighestScore = validCombos.Any() ? validCombos.Max(c => c.TotalScore) : null;
        }

        // C. Lấy Số lượng Nguyện vọng (Wishlist - Các trường/ngành đã thả tim)
        // Kiểm tra lại tên bảng của m nhé, thường là UserWishlists
        stats.WishlistCount = await _db.UserTargets.CountAsync(w => w.UserId == userId);

        // D. Lấy Kết quả Holland mới nhất
        var lastResult = await _db.HollandResults
                                  .Where(h => h.UserId == userId)
                                  .OrderByDescending(h => h.TestDate)
                                  .FirstOrDefaultAsync();

        if (lastResult != null)
        {
            stats.HasHolland = true;
            stats.HollandResult = lastResult.HollandCode;
        }
        else
        {
            stats.HasHolland = false;
            stats.HollandResult = "";
        }

        return Ok(stats);
    }

    // --- HELPERS ---
    private async Task<PercentileResultDto> CalculatePercentileInternal(string group, decimal score)
    {
        var distribution = await _db.ScoreDistributions
            .Where(x => x.GroupCode == group && x.Year == 2024)
            .ToListAsync();

        if (!distribution.Any())
            return new PercentileResultDto { SubjectGroup = group, UserScore = score, Percentile = 0 };

        int total = distribution.Sum(x => x.StudentCount);
        int lower = distribution.Where(x => x.Score <= score).Sum(x => x.StudentCount);
        double p = total > 0 ? (double)lower / total * 100 : 0;

        return new PercentileResultDto
        {
            SubjectGroup = group,
            UserScore = score,
            Percentile = Math.Round(p, 2),
            TotalCandidates = total,
            LowerThanCount = lower
        };
    }

}