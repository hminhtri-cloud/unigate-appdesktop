using Microsoft.AspNetCore.Authorization; // Cho phép Authorize
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Bắt buộc đăng nhập mới xem được danh sách (để bảo mật)
public class MajorsController : ControllerBase
{
    private readonly AppDbContext _db;

    public MajorsController(AppDbContext db)
    {
        _db = db;
    }

    // API: api/Majors/all-details
    [HttpGet("all-details")]
    public async Task<IActionResult> GetAllDetails()
    {
        var list = await _db.Majors
            .Include(m => m.University) // KÈM TÊN TRƯỜNG
            .OrderBy(m => m.University.Name) // Sắp xếp theo tên trường cho dễ tìm
            .ThenBy(m => m.MajorName)
            .Select(m => new MajorDetailDto
            {
                Id = m.Id,
                UniversityId = m.UniversityId,
                UniversityName = m.University != null ? m.University.Name : "Đang cập nhật",
                MajorName = m.MajorName,
                MajorCode = m.MajorCode,
                GroupCode = m.GroupCode,
                CutoffScore = m.CutoffScore,
                Tuition = m.Tuition,       // Lấy học phí
                HollandCode = m.HollandCode, // Lấy mã Holland
                Description = m.Description  // Lấy mô tả
            })
            .ToListAsync();

        return Ok(list);
    }

    // API: Lấy chi tiết 1 ngành (Phòng hờ sau này m cần click vào xem chi tiết)
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var m = await _db.Majors.Include(u => u.University).FirstOrDefaultAsync(x => x.Id == id);
        if (m == null) return NotFound();

        return Ok(new MajorDetailDto
        {
            Id = m.Id,
            UniversityName = m.University?.Name ?? "",
            MajorName = m.MajorName,
            CutoffScore = m.CutoffScore,
            Tuition = m.Tuition,
            Description = m.Description
        });
    }
}