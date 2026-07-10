using LearningAssistant.Dtos;
using LearningAssistant.Exceptions;
using LearningAssistant.Models;
using LearningAssistant.Repositories;

namespace LearningAssistant.Services;

public class LearningMaterialService(ILearningMaterialRepository learningMaterialRepository)
    : ILearningMaterialService
{
    public async Task<IReadOnlyList<LearningMaterialResponse>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        var materials = await learningMaterialRepository.GetAllAsync(cancellationToken);

        return materials.Select(MapToResponse).ToList();
    }

    public async Task<LearningMaterialResponse> CreateAsync(
        CreateLearningMaterialRequest request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Title))
        {
            throw new ValidationException("Title cannot be empty.");
        }

        var material = new LearningMaterial
        {
            Title = request.Title.Trim(),
            Description = request.Description?.Trim()
        };

        var savedMaterial = await learningMaterialRepository.AddAsync(
            material,
            cancellationToken);

        return MapToResponse(savedMaterial);
    }

    private static LearningMaterialResponse MapToResponse(LearningMaterial material)
    {
        return new LearningMaterialResponse(
            material.Id,
            material.Title,
            material.Description,
            material.CreatedAt);
    }
}
