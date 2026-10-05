using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;

namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Bắt buộc đăng nhập mới được dùng
public class FavoritesController : ControllerBase
{
    private readonly AppDbContext _db;

    public FavoritesController(AppDbContext db) => _db = db;

    // 1. THẢ TIM (Logic này giữ nguyên vì ID không đổi)
    [HttpPost("toggle")]
    public async Task<IActionResult> ToggleFavorite([FromBody] ToggleFavoriteRequest req)
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value!);

        // Kiểm tra xem đã lưu chưa
        var existingFav = await _db.UserFavorites
            .FirstOrDefaultAsync(f => f.UserId == userId && f.MajorId == req.MajorId);

        if (existingFav != null)
        {
            // Có rồi -> Xóa đi (Un-heart)
            _db.UserFavorites.Remove(existingFav);
            await _db.SaveChangesAsync();
            return Ok(new { message = "Đã bỏ lưu!", isSaved = false });
        }
        else
        {
            // Chưa có -> Thêm vào
            var newFav = new UserFavorite { UserId = userId, MajorId = req.MajorId, SavedAt = DateTime.Now };
            _db.UserFavorites.Add(newFav);
            await _db.SaveChangesAsync();
            return Ok(new { message = "Đã lưu thành công!", isSaved = true });
        }
    }

    // 2. XEM DANH SÁCH ĐÃ LƯU (Code mới dùng .Include)
    [HttpGet("my-favorites")]
    public async Task<IActionResult> GetMyFavorites()
    {
        var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();
        var userId = int.Parse(userIdStr);

        // --- CÁCH MỚI: DÙNG INCLUDE ---
        // Không cần Join thủ công lằng nhằng nữa
        var list = await _db.UserFavorites
            .Where(f => f.UserId == userId)
            .Include(f => f.Major)              // 1. Kéo bảng Ngành
                .ThenInclude(m => m.University) // 2. Từ Ngành kéo tiếp bảng Trường
            .OrderByDescending(f => f.SavedAt)
            .Select(f => new FavoriteMajorDto
            {
                MajorId = f.MajorId,
                // Lấy tên trường từ bảng University thông qua quan hệ
                UniversityName = f.Major!.University!.Name ?? "Trường ẩn",
                MajorName = f.Major.MajorName,
                GroupCode = f.Major.GroupCode,
                CutoffScore = f.Major.CutoffScore,
                SavedAt = f.SavedAt
            })
            .ToListAsync();

        return Ok(list);
    }

    // 3. XÓA KHỎI DANH SÁCH (API mà Client đang gọi)
    [HttpDelete("remove")]
    public async Task<IActionResult> RemoveFavorite([FromQuery] int majorId)
    {
        var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();
        var userId = int.Parse(userIdStr);

        // Tìm xem user có lưu ngành này chưa
        var fav = await _db.UserFavorites
            .FirstOrDefaultAsync(f => f.UserId == userId && f.MajorId == majorId);

        if (fav == null)
        {
            return NotFound("Ngành này không có trong danh sách yêu thích của bạn.");
        }

        // Xóa và lưu
        _db.UserFavorites.Remove(fav);
        await _db.SaveChangesAsync();

        return Ok(new { message = "Đã xóa thành công!" });
    }

}