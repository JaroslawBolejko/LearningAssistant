using LearningAssistant.Dtos;

namespace LearningAssistant.Services;

public interface ILearningMaterialService
{
    Task<IReadOnlyList<LearningMaterialResponse>> GetAllAsync(
        CancellationToken cancellationToken);
    Task<LearningMaterialResponse> CreateAsync(
        CreateLearningMaterialRequest request,
        CancellationToken cancellationToken);
}
