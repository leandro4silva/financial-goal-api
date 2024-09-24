using FinTrack.Domain.Entities;
using FinTrack.Domain.Enum;

namespace FinTrack.Application.Models.Request;

public class PostCreateFinancialGoalRequest
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public decimal GoalAmount { get; set; }

    public DateTime Deadline { get; set; }

    public decimal IdealMonthlySaving { get; set; }

    public GoalStatus Status { get; set; } = GoalStatus.InProgress;

    public Transation? Transactions { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public bool IsDeleted { get; set; } = false;
}
