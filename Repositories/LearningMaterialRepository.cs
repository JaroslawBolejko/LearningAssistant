using LearningAssistant.Data;
using LearningAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningAssistant.Repositories;

public class LearningMaterialRepository(AppDbContext dbContext) : ILearningMaterialRepository
{
    public async Task<IReadOnlyList<LearningMaterial>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await dbContext.LearningMaterials
            .AsNoTracking()
            .OrderBy(material => material.Id)
            .ToListAsync(cancellationToken);
    }

    public async Task<LearningMaterial> AddAsync(
        LearningMaterial material,
        CancellationToken cancellationToken)
    {
        dbContext.LearningMaterials.Add(material);
        await dbContext.SaveChangesAsync(cancellationToken);

        return material;
    }
}
