using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")] // -> Đường dẫn sẽ là: api/Universities
[ApiController]
public class UniversitiesController : ControllerBase
{
    private readonly AppDbContext _db;

    public UniversitiesController(AppDbContext db) => _db = db;

    // API lấy danh sách trường (Chỉ lấy Id và Name cho nhẹ)
    [HttpGet]
    public async Task<IActionResult> GetUniversities()
    {
        var list = await _db.Universities
            .OrderBy(u => u.Name)
            .Select(u => new UniversityDto
            {
                Id = u.Id,
                Name = u.Name,
                Code = u.Code // Lấy thêm mã trường nếu cần hiển thị
            })
            .ToListAsync();

        return Ok(list);
    }
}