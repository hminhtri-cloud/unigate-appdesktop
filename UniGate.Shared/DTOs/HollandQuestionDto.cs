namespace UniGate.Shared.DTOs;
public class HollandQuestionDto
{
    public int Id { get; set; }
    public string Content { get; set; } = "";
    public string Group { get; set; } = "";
}

public class HollandResultDto
{
    public string HollandCode { get; set; } = "";
    public string Description { get; set; } = "";
    // Thêm dòng này để fix lỗi bên FormHollandResult nếu code cũ có dùng
    public List<string> SuggestedMajors { get; set; } = new List<string>();
}

public class HollandAnswerRequest
{
    public Dictionary<string, int> GroupScores { get; set; } = new();
}

public class HollandHistoryDto
{
    public int Id { get; set; }
    public string HollandCode { get; set; } = "";
    public DateTime TestDate { get; set; }
    public string Description { get; set; } = "";
}