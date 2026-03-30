namespace JobTracker.Server.Data;

public class JobApplication
{
    public int Id { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public DateTime DateApplied { get; set; }
    public string Status { get; set; } = "Applied"; // Applied, Interview, Offer, Rejected
    public string Notes { get; set; } = string.Empty;
}