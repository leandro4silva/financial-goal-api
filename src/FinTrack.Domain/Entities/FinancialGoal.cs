using FinTrack.Domain.Enum;

namespace FinTrack.Domain.Entities;

public class FinancialGoal
{
    public string? Name { get; set; }

    public decimal GoalAmount { get; set; }

    public DateTime Deadline { get; set; }

    public decimal IdealMonthlySaving { get; set; }

    public FinancialGoalStatus Status { get; set; }

    public FinancialGoalTransations? Transactions { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }
}
