namespace LearningAssistant.Models;

public class LearningMaterial
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<LearningItem> Items { get; set; } = [];
}
