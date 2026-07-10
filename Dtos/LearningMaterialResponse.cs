namespace LearningAssistant.Dtos;

public record LearningMaterialResponse(
    int Id,
    string Title,
    string? Description,
    DateTime CreatedAt);
