
using FinTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrack.Infraestructure.Data.EF.Configuration;


public class FinancialGoalConfiguration : IEntityTypeConfiguration<FinancialGoal>
{
    public void Configure(EntityTypeBuilder<FinancialGoal> builder)
    {
        builder.HasKey(financialGoal => financialGoal.Id);
        builder.Property(financialGoal => financialGoal.Name).HasMaxLength(255);
        builder.Property(financialGoal => financialGoal.IdealMonthlySaving).HasMaxLength(999_999_999);
    }
}
