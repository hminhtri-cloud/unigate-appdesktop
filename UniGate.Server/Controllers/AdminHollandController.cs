using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/admin/holland-questions")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminHollandController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminHollandController(AppDbContext db) => _db = db;

    // 1. LẤY DANH SÁCH
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // Sắp xếp theo Nhóm trước, rồi tới ID
        var list = await _db.HollandQuestions
            .OrderBy(q => q.Group)
            .ThenBy(q => q.Id)
            .ToListAsync();

        var dtos = list.Select(q => new HollandQuestionDto
        {
            Id = q.Id,
            Content = q.Content,
            Group = q.Group
        });

        return Ok(dtos);
    }

    // 2. THÊM MỚI
    [HttpPost]
    public async Task<IActionResult> Create(HollandQuestionDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Content)) return BadRequest("Nội dung không được để trống");
        if (!IsValidGroup(dto.Group)) return BadRequest("Nhóm không hợp lệ (Phải là R, I, A, S, E, C)");

        var question = new HollandQuestion
        {
            Content = dto.Content,
            Group = dto.Group.ToUpper()
        };

        _db.HollandQuestions.Add(question);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Thêm câu hỏi thành công!" });
    }

    // 3. CẬP NHẬT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, HollandQuestionDto dto)
    {
        var q = await _db.HollandQuestions.FindAsync(id);
        if (q == null) return NotFound("Không tìm thấy câu hỏi");

        if (!IsValidGroup(dto.Group)) return BadRequest("Nhóm không hợp lệ");

        q.Content = dto.Content;
        q.Group = dto.Group.ToUpper();

        await _db.SaveChangesAsync();
        return Ok(new { message = "Cập nhật thành công!" });
    }

    // 4. XÓA
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var q = await _db.HollandQuestions.FindAsync(id);
        if (q == null) return NotFound();

        _db.HollandQuestions.Remove(q);
        await _db.SaveChangesAsync();
        return Ok(new { message = "Đã xóa câu hỏi!" });
    }

    // Helper check nhóm
    private bool IsValidGroup(string g)
    {
        var validGroups = new[] { "R", "I", "A", "S", "E", "C" };
        return validGroups.Contains(g?.ToUpper());
    }
}