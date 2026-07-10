namespace LearningAssistant.Models;

public class LearningSession
{
    public int Id { get; set; }
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }

    public ICollection<LearningItem> Items { get; set; } = [];
}
