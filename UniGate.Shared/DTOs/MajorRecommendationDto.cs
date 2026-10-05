using System.Text.Json.Serialization;

namespace UniGate.Shared.DTOs
{
    public class MajorRecommendationDto
    {
        [JsonPropertyName("majorId")]
        public int MajorId { get; set; }

        [JsonPropertyName("universityName")]
        public string UniversityName { get; set; } = "";

        [JsonPropertyName("majorName")]
        public string MajorName { get; set; } = "";

        [JsonPropertyName("groupCode")]
        public string GroupCode { get; set; } = "";

        [JsonPropertyName("cutoffScore")]
        public decimal CutoffScore { get; set; }

        [JsonPropertyName("userScore")]
        public decimal UserScore { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        // --- ĐÂY NÈ TRÍ, THÊM DÒNG NÀY VÀO LÀ HẾT LỖI ---
        [JsonPropertyName("deviation")]
        public decimal Deviation { get; set; }
    }
}