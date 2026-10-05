using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniGate.Server.Entities;
using UniGate.Shared.DTOs;
using Microsoft.EntityFrameworkCore;


namespace UniGate.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Bảo mật bằng Token
public class HollandController : ControllerBase
{
    private readonly AppDbContext _db;
    public HollandController(AppDbContext db) => _db = db;

    [HttpGet("questions")]
    public async Task<IActionResult> GetQuestions() => Ok(await _db.HollandQuestions.ToListAsync());

    [HttpPost("submit")]
    public async Task<IActionResult> Submit(HollandAnswerRequest req)
    {
        // Lấy UserId từ Token JWT (Mục 8)
        var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value!);

        // Logic: Sắp xếp lấy 3 nhóm điểm cao nhất để tạo mã
        var top3Groups = req.GroupScores
            .OrderByDescending(x => x.Value)
            .Take(3)
            .Select(x => x.Key);

        var code = string.Join("", top3Groups);

        // Lưu lịch sử làm bài (Mục 5)
        var result = new HollandResult
        {
            UserId = userId,
            HollandCode = code
        };
        _db.HollandResults.Add(result);
        await _db.SaveChangesAsync();

        return Ok(new HollandResultDto
        {
            HollandCode = code,
            Description = GetDescription(code)
        });
    }

    [HttpGet("history")]
    public async Task<IActionResult> GetHistory()
    {
        // Lấy UserId từ Token JWT của người đang đăng nhập
        var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value!);

        var history = await _db.HollandResults
            .Where(r => r.UserId == userId)
            .OrderByDescending(r => r.TestDate)
            .Select(r => new HollandHistoryDto
            {
                Id = r.Id,
                HollandCode = r.HollandCode,
                TestDate = r.TestDate
            })
            .ToListAsync();

        return Ok(history);
    }
    private string GetDescription(string code)
    {
        // Lấy nhóm mạnh nhất (chữ cái đầu tiên trong mã)
        char strongest = code[0];

        return strongest switch
        {
            'R' => "Bạn là người **Thực tế**. Bạn thích làm việc với máy móc, dụng cụ hoặc cây cối. Bạn có tính cách mạnh mẽ, kiên trì và rất giỏi giải quyết các vấn đề kỹ thuật.",
            'I' => "Bạn là người **Nghiên cứu**. Bạn có tư duy logic, thích quan sát, học hỏi và giải quyết vấn đề bằng cách phân tích. Bạn là người tò mò và luôn tìm kiếm sự thật.",
            'A' => "Bạn là người **Nghệ thuật**. Bạn sở hữu tâm hồn sáng tạo, trực giác nhạy bén và không thích những quy tắc gò bó. Bạn thích phiêu lưu trong thế giới của cái đẹp và ý tưởng.",
            'S' => "Bạn là người **Xã hội**. Bạn có lòng trắc ẩn, thích giúp đỡ, giảng dạy và chăm sóc người khác. Bạn giao tiếp tốt và luôn là sợi dây gắn kết mọi người.",
            'E' => "Bạn là người **Quản lý**. Bạn đầy năng lượng, có khả năng thuyết phục và lãnh đạo. Bạn thích kinh doanh, dám chấp nhận rủi ro và có định hướng thành công rất cao.",
            'C' => "Bạn là người **Nghiệp vụ**. Bạn rất cẩn thận, tỉ mỉ và tôn trọng quy trình. Bạn giỏi làm việc với số liệu, hồ sơ và luôn đảm bảo mọi thứ được tổ chức ngăn nắp.",
            _ => "Bạn có tính cách đa dạng và linh hoạt trong nhiều môi trường."
        };
    }

}