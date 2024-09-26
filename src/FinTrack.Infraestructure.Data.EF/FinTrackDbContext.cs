using FinTrack.Domain.Entities;
using FinTrack.Infraestructure.Data.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Infraestructure.Data.EF;

public class FinTrackDbContext : DbContext
{
    public DbSet<Goal> Goal => Set<Goal>();

    public FinTrackDbContext(DbContextOptions<FinTrackDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GoalConfiguration());
    }
}
