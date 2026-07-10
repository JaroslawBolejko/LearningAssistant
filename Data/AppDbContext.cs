using LearningAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningAssistant.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<LearningMaterial> LearningMaterials => Set<LearningMaterial>();
    public DbSet<LearningSession> LearningSessions => Set<LearningSession>();
    public DbSet<LearningItem> LearningItems => Set<LearningItem>();
}
