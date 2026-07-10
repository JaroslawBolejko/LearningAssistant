namespace LearningAssistant.Dtos;

public class CreateLearningMaterialRequest
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
}
