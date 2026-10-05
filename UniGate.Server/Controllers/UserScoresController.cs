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
public class UserScoresController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly ComboScoreService _comboService;

    public UserScoresController(AppDbContext db, ComboScoreService comboService)
    {
        _db = db;
        _comboService = comboService;
    }

    // --- 1. LƯU ĐIỂM ---
    [HttpPost("save")]
    public async Task<IActionResult> SaveScore(UserScoreRequest req)
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);

        if (score == null)
        {
            score = new UserScore { UserId = userId };
            _db.UserScores.Add(score);
        }

        score.HB_Toan = req.HB_Toan; score.HB_Van = req.HB_Van; score.HB_Anh = req.HB_Anh;
        score.HB_Ly = req.HB_Ly; score.HB_Hoa = req.HB_Hoa; score.HB_Sinh = req.HB_Sinh;
        score.HB_Su = req.HB_Su; score.HB_Dia = req.HB_Dia;
        score.HB_GDKTPL = req.HB_GDKTPL; score.HB_TinHoc = req.HB_TinHoc;

        score.Thpt_Toan = req.Thpt_Toan; score.Thpt_Van = req.Thpt_Van;
        score.Thpt_TuChon1_Mon = req.Thpt_TuChon1_Mon; score.Thpt_TuChon1_Diem = req.Thpt_TuChon1_Diem;
        score.Thpt_TuChon2_Mon = req.Thpt_TuChon2_Mon; score.Thpt_TuChon2_Diem = req.Thpt_TuChon2_Diem;

        score.Dgnl_Score = req.Dgnl_Score;
        score.KhuVuc = req.KhuVuc;
        score.DoiTuong = req.DoiTuong;

        await _db.SaveChangesAsync();
        return Ok("Lưu điểm thành công!");
    }

    // --- 2. LẤY ĐIỂM CỦA TÔI ---
    [HttpGet("my-score")]
    public async Task<IActionResult> GetMyScore()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
        var score = await _db.UserScores.FirstOrDefaultAsync(s => s.UserId == userId);

        if (score == null) return Ok(null);

        return Ok(new UserScoreRequest
        {
            UserId = score.UserId,
            HB_Toan = score.HB_Toan,
            HB_Van = score.HB_Van,
            HB_Anh = score.HB_Anh,
            HB_Ly = score.HB_Ly,
            HB_Hoa = score.HB_Hoa,
            HB_Sinh = score.HB_Sinh,
            HB_Su = score.HB_Su,
            HB_Dia = score.HB_Dia,
            HB_GDKTPL = score.HB_GDKTPL,
            HB_TinHoc = score.HB_TinHoc,
            Thpt_Toan = score.Thpt_Toan,
            Thpt_Van = score.Thpt_Van,
            Thpt_TuChon1_Mon = score.Thpt_TuChon1_Mon,
            Thpt_TuChon1_Diem = score.Thpt_TuChon1_Diem,
            Thpt_TuChon2_Mon = score.Thpt_TuChon2_Mon,
            Thpt_TuChon2_Diem = score.Thpt_TuChon2_Diem,
            Dgnl_Score = score.Dgnl_Score,
            KhuVuc = score.KhuVuc,
            DoiTuong = score.DoiTuong
        });
    }

    // --- 3. TÍNH PHÂN VỊ ---
    [HttpGet("percentile")]
    public async Task<IActionResult> GetPercentile(string group, decimal score)
    {
        var distribution = await _db.ScoreDistributions
            .Where(x => x.GroupCode == group && x.Year == 2024)
            .ToListAsync();

        if (!distribution.Any()) return Ok(new PercentileResultDto { Percentile = 0, SubjectGroup = group });

        int totalCandidates = distribution.Sum(x => x.StudentCount);
        int lowerThanCount = distribution.Where(x => x.Score <= score).Sum(x => x.StudentCount);
        double percentile = totalCandidates > 0 ? (double)lowerThanCount / totalCandidates * 100 : 0;

        return Ok(new PercentileResultDto
        {
            SubjectGroup = group,
            UserScore = score,
            Percentile = Math.Round(percentile, 2),
            TotalCandidates = totalCandidates,
            LowerThanCount = lowerThanCount
        });
    }

    
}