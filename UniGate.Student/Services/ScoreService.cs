using System.Net.Http.Headers;
using System.Net.Http.Json;
using UniGate.Shared.DTOs;

namespace UniGate.Student.Services;

public class ScoreService
{
    private readonly HttpClient _http = new()
    {
        BaseAddress = new Uri("https://localhost:7030/") // Gọi qua Load Balancer
    };

    public async Task<bool> SaveScoreAsync(UserScoreRequest req)
    {
        // Gắn Token vào Header để Server xác thực
        if (!string.IsNullOrEmpty(UserSession.Token))
        {
            _http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", UserSession.Token);
        }

        var res = await _http.PostAsJsonAsync("api/UserScores/save", req);
        return res.IsSuccessStatusCode;
    }
}