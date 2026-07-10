using LearningAssistant.Models;

namespace LearningAssistant.Repositories;

public interface ILearningMaterialRepository
{
    Task<IReadOnlyList<LearningMaterial>> GetAllAsync(CancellationToken cancellationToken);
    Task<LearningMaterial> AddAsync(
        LearningMaterial material,
        CancellationToken cancellationToken);
}
