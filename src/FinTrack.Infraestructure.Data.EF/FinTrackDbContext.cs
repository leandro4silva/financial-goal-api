using FinTrack.Domain.Entities;
using FinTrack.Infraestructure.Data.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Infraestructure.Data.EF;

public class FinTrackDbContext : DbContext
{
    public DbSet<FinancialGoal> FinancialGoal => Set<FinancialGoal>();

    public FinTrackDbContext(DbContextOptions<FinTrackDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FinancialGoalConfiguration());
    }
}
