using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/majors")]
[ApiController]
[Authorize(Roles = "Admin")] // Chỉ Admin mới được vào
public class AdminMajorsController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminMajorsController(AppDbContext db) => _db = db;

    // 1. LẤY TẤT CẢ (Kèm tên trường để hiển thị)
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _db.Majors.Include(m => m.University).OrderByDescending(m => m.Id).ToListAsync();
        var dtos = list.Select(m => new MajorDetailDto
        {
            Id = m.Id,
            UniversityId = m.UniversityId,
            UniversityName = m.University?.Name ?? "Lỗi tên trường",
            MajorName = m.MajorName,
            MajorCode = m.MajorCode,
            GroupCode = m.GroupCode,
            CutoffScore = m.CutoffScore,
            Tuition = m.Tuition,
            HollandCode = m.HollandCode,
            Description = m.Description
        });
        return Ok(dtos);
    }

    // 2. THÊM MỚI
    [HttpPost]
    public async Task<IActionResult> Create(MajorDetailDto dto)
    {
        var major = new Major
        {
            UniversityId = dto.UniversityId,
            MajorName = dto.MajorName,
            MajorCode = dto.MajorCode,
            GroupCode = dto.GroupCode,
            CutoffScore = dto.CutoffScore,
            Tuition = dto.Tuition,
            HollandCode = dto.HollandCode,
            Description = dto.Description
        };
        _db.Majors.Add(major);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Thêm thành công!" });
    }

    // 3. CẬP NHẬT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, MajorDetailDto dto)
    {
        var major = await _db.Majors.FindAsync(id);
        if (major == null) return NotFound("Không tìm thấy ngành này");

        major.UniversityId = dto.UniversityId; // Cho phép đổi trường
        major.MajorName = dto.MajorName;
        major.MajorCode = dto.MajorCode;
        major.GroupCode = dto.GroupCode;
        major.CutoffScore = dto.CutoffScore;
        major.Tuition = dto.Tuition;
        major.HollandCode = dto.HollandCode;
        major.Description = dto.Description;

        await _db.SaveChangesAsync();
        return Ok(new { message = "Cập nhật thành công!" });
    }

    // 4. XÓA
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var major = await _db.Majors.FindAsync(id);
        if (major == null) return NotFound();

        _db.Majors.Remove(major);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa ngành!" });
    }
}