using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/subject-groups")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminSubjectGroupsController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminSubjectGroupsController(AppDbContext db) => _db = db;

    // 1. LẤY DANH SÁCH
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _db.SubjectGroups.OrderBy(g => g.GroupCode).ToListAsync();
        var dtos = list.Select(g => new SubjectGroupDto
        {
            Id = g.Id,
            GroupCode = g.GroupCode,
            Subjects = g.Subjects,
            Description = g.Description
        });
        return Ok(dtos);
    }

    // 2. THÊM MỚI
    [HttpPost]
    public async Task<IActionResult> Create(SubjectGroupDto dto)
    {
        // Kiểm tra trùng mã (A00 trùng A00 là không được)
        if (await _db.SubjectGroups.AnyAsync(g => g.GroupCode == dto.GroupCode))
            return BadRequest("Mã khối này đã tồn tại rồi!");

        var group = new SubjectGroup
        {
            GroupCode = dto.GroupCode,
            Subjects = dto.Subjects,
            Description = dto.Description
        };
        _db.SubjectGroups.Add(group);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Thêm khối thi thành công!" });
    }

    // 3. CẬP NHẬT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, SubjectGroupDto dto)
    {
        var group = await _db.SubjectGroups.FindAsync(id);
        if (group == null) return NotFound("Không tìm thấy khối này");

        group.GroupCode = dto.GroupCode;
        group.Subjects = dto.Subjects;
        group.Description = dto.Description;

        await _db.SaveChangesAsync();
        return Ok(new { message = "Cập nhật thành công!" });
    }

    // 4. XÓA (CÓ BẢO VỆ)
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var group = await _db.SubjectGroups.FindAsync(id);
        if (group == null) return NotFound();

        // Kiểm tra xem có ngành nào đang dùng khối này không
        // (Ví dụ: Ngành CNTT đang dùng A00 thì không được xóa A00)
        bool isUsed = await _db.Majors.AnyAsync(m => m.GroupCode == group.GroupCode);
        if (isUsed)
        {
            return BadRequest($"Không thể xóa khối {group.GroupCode} vì đang có ngành sử dụng nó!");
        }

        _db.SubjectGroups.Remove(group);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa khối thi!" });
    }
}