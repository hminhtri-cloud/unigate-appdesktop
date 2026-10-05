namespace UniGate.Server.Entities;

public class SubjectGroup
{
    public int Id { get; set; }
    public string GroupCode { get; set; } = "";
    public string Subjects { get; set; } = "";
    public string Description { get; set; } = "";
}