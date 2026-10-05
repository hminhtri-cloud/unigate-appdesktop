using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UniGate.Server.Entities;
using UniGate.Server.Services;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")] // -> Đường dẫn sẽ là: api/Dashboard
[ApiController]
[Authorize]
public class DashboardController : ControllerBase // <--- QUAN TRỌNG: Phải kế thừa cái này mới dùng được User, Ok, Unauthorized
{
    // Khai báo biến BÊN TRONG class
    private readonly AppDbContext _db;
    private readonly ComboScoreService _comboService;

    // Constructor chuẩn
    public DashboardController(AppDbContext db, ComboScoreService comboService)
    {
        _db = db;
        _comboService = comboService;
    }

    [HttpGet("dashboard-stats")]
    public async Task<IActionResult> GetDashboardStats()
    {
        // 1. Lấy UserId
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdClaim)) return Unauthorized();
        var userId = int.Parse(userIdClaim);

        var stats = new StudentDashboardStatsDto();

        // A. Lấy Tên
        var user = await _db.Users.FindAsync(userId);
        stats.FullName = user?.FullName ?? "Sinh viên";

        // B. Lấy Điểm Cao Nhất
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);
        if (score != null)
        {
            var combos = _comboService.CalculateThptCombinations(score);
            var validCombos = combos.Where(c => c.IsEligible).ToList();
            stats.HighestScore = validCombos.Any() ? validCombos.Max(c => c.TotalScore) : null;
        }

        // C. Lấy Số lượng Nguyện vọng (Đếm trong UserFavorites)
        stats.WishlistCount = await _db.UserFavorites.CountAsync(w => w.UserId == userId);

        // D. Lấy Holland
        var lastResult = await _db.HollandResults
                                .Where(h => h.UserId == userId)
                                .OrderByDescending(h => h.TestDate)
                                .FirstOrDefaultAsync();

        stats.HasHolland = lastResult != null;
        stats.HollandResult = lastResult?.HollandCode ?? "";

        return Ok(stats);
    }
}