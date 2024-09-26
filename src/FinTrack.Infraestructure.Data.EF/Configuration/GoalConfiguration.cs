
using FinTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Infraestructure.Data.EF.Configuration;


public class GoalConfiguration : IEntityTypeConfiguration<Goal>
{
    public void Configure(EntityTypeBuilder<Goal> builder)
    {
        builder.HasKey(goal => goal.Id);
        builder.Property(goal => goal.Name).HasMaxLength(255);
        builder.Property(goal => goal.IdealMonthlySaving).HasMaxLength(999_999_999);
    }
}
