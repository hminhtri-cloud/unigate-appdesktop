using System.Text.Json.Serialization; // <--- QUAN TRỌNG: Phải có thư viện này

namespace UniGate.Shared.DTOs
{
    public class StudentDashboardStatsDto
    {
        // Server trả về "fullName" -> Map vào biến FullName
        [JsonPropertyName("fullName")]
        public string FullName { get; set; } = "";

        // Server trả về "highestScore" -> Map vào biến HighestScore
        [JsonPropertyName("highestScore")]
        public decimal? HighestScore { get; set; }

        // Server trả về "wishlistCount" -> Map vào biến WishlistCount
        [JsonPropertyName("wishlistCount")]
        public int WishlistCount { get; set; }

        // Server trả về "hasHolland" -> Map vào biến HasHolland
        [JsonPropertyName("hasHolland")]
        public bool HasHolland { get; set; }

        // Server trả về "hollandResult" -> Map vào biến HollandResult
        [JsonPropertyName("hollandResult")]
        public string HollandResult { get; set; } = "";
    }
}