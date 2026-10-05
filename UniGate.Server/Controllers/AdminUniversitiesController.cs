using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/universities")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminUniversitiesController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminUniversitiesController(AppDbContext db) => _db = db;

    // 1. LẤY DANH SÁCH
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _db.Universities.OrderByDescending(u => u.Id).ToListAsync();
        // Map sang DTO
        var dtos = list.Select(u => new UniversityDto
        {
            Id = u.Id,
            Code = u.Code,
            Name = u.Name,
            LogoUrl = u.LogoUrl,
            Region = u.Region,
            Address = u.Address,
            Website = u.Website,
            Description = u.Description
        });
        return Ok(dtos);
    }

    // 2. THÊM MỚI
    [HttpPost]
    public async Task<IActionResult> Create(UniversityDto dto)
    {
        var uni = new University
        {
            Code = dto.Code,
            Name = dto.Name,
            LogoUrl = dto.LogoUrl,
            Region = dto.Region,
            Address = dto.Address,
            Website = dto.Website,
            Description = dto.Description
        };
        _db.Universities.Add(uni);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Thêm trường thành công!" });
    }

    // 3. CẬP NHẬT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UniversityDto dto)
    {
        var uni = await _db.Universities.FindAsync(id);
        if (uni == null) return NotFound("Không tìm thấy trường này");

        uni.Code = dto.Code;
        uni.Name = dto.Name;
        uni.LogoUrl = dto.LogoUrl;
        uni.Region = dto.Region;
        uni.Address = dto.Address;
        uni.Website = dto.Website;
        uni.Description = dto.Description;

        await _db.SaveChangesAsync();
        return Ok(new { message = "Cập nhật thành công!" });
    }

    // 4. XÓA
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var uni = await _db.Universities.FindAsync(id);
        if (uni == null) return NotFound();

        // Kiểm tra xem trường này có ngành nào không, nếu có thì chặn xóa (để toàn vẹn dữ liệu)
        bool hasMajors = await _db.Majors.AnyAsync(m => m.UniversityId == id);
        if (hasMajors) return BadRequest("Không thể xóa: Trường này đang có ngành học!");

        _db.Universities.Remove(uni);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa trường!" });
    }
}