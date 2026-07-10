using LearningAssistant.Dtos;
using LearningAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningAssistant.Controllers;

[ApiController]
[Route("api/learning-materials")]
public class LearningMaterialsController(ILearningMaterialService learningMaterialService)
    : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<LearningMaterialResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var materials = await learningMaterialService.GetAllAsync(cancellationToken);

        return Ok(materials);
    }

    [HttpPost]
    public async Task<ActionResult<LearningMaterialResponse>> Create(
        CreateLearningMaterialRequest request,
        CancellationToken cancellationToken)
    {
        var material = await learningMaterialService.CreateAsync(request, cancellationToken);

        return Ok(material);
    }
}
