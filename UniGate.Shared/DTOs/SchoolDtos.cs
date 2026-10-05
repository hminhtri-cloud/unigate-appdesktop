namespace UniGate.Shared.DTOs;

public class UniversityDto
{
    public int UniversityID { get; set; }
    public string UniversityCode { get; set; } = "";
    public string UniversityName { get; set; } = "";
    public string? Province { get; set; }
    public string? Website { get; set; }
    public string? LogoUrl { get; set; }
}

public class MajorAdminDto
{
    public int Id { get; set; }
    public string? MajorCode { get; set; }
    public string? Name { get; set; }
    public decimal CutoffScore { get; set; }
    public int Year { get; set; }
    public List<string> Combos { get; set; } = new();
}