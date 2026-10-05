using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/dashboard")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminDashboardController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminDashboardController(AppDbContext db) => _db = db;

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats()
    {
        var stats = new DashboardStatsDto
        {
            TotalUsers = await _db.Users.CountAsync(u => u.Role == "Student"),
            TotalUniversities = await _db.Universities.CountAsync(),
            TotalMajors = await _db.Majors.CountAsync(),
        };

        // Thống kê trường theo khu vực (cho biểu đồ)
        var regionStats = await _db.Universities
            .GroupBy(u => u.Region)
            .Select(g => new { Region = g.Key, Count = g.Count() })
            .ToListAsync();

        foreach (var item in regionStats)
        {
            if (!string.IsNullOrEmpty(item.Region))
                stats.UnisByRegion.Add(item.Region, item.Count);
        }

        return Ok(stats);
    }
}