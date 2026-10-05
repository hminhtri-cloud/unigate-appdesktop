public class UniversityDto
{
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string LogoUrl { get; set; } = ""; // Thêm dòng này
    public string Region { get; set; } = "";
    public string Address { get; set; } = "";
    public string Website { get; set; } = "";
    public string Description { get; set; } = "";
}