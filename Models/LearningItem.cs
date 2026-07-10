namespace LearningAssistant.Models;

public class LearningItem
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int LearningMaterialId { get; set; }
    public LearningMaterial LearningMaterial { get; set; } = null!;

    public int? LearningSessionId { get; set; }
    public LearningSession? LearningSession { get; set; }
}
