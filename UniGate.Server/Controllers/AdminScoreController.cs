using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/scores")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminScoreController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminScoreController(AppDbContext db) => _db = db;

    // 1. LẤY DANH SÁCH
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _db.ScoreDistributions
                            .OrderByDescending(x => x.Year)
                            .ThenBy(x => x.GroupCode)
                            .ThenBy(x => x.Score)
                            .Take(200) // Lấy 200 dòng demo thôi cho nhẹ
                            .ToListAsync();
        return Ok(list);
    }

    // 2. THÊM MỚI (Nhập tay từng dòng)
    [HttpPost]
    public async Task<IActionResult> Create(ScoreDistributionDto dto)
    {
        // Kiểm tra xem mức điểm này của khối này đã nhập chưa
        if (await _db.ScoreDistributions.AnyAsync(x => x.GroupCode == dto.GroupCode && x.Score == dto.Score && x.Year == dto.Year))
        {
            return BadRequest("Mức điểm này của khối này đã có rồi!");
        }

        var item = new ScoreDistribution
        {
            GroupCode = dto.GroupCode,
            Year = dto.Year,
            Score = dto.Score,
            StudentCount = dto.StudentCount
        };

        _db.ScoreDistributions.Add(item);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã thêm dữ liệu!" });
    }

    // 3. SỬA
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ScoreDistributionDto dto)
    {
        var item = await _db.ScoreDistributions.FindAsync(id);
        if (item == null) return NotFound();

        item.GroupCode = dto.GroupCode;
        item.Year = dto.Year;
        item.Score = dto.Score;
        item.StudentCount = dto.StudentCount;

        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã cập nhật!" });
    }

    // 4. XÓA
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _db.ScoreDistributions.FindAsync(id);
        if (item == null) return NotFound();

        _db.ScoreDistributions.Remove(item);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa!" });
    }
}