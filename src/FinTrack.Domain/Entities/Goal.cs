using FinTrack.Domain.Enum;

namespace FinTrack.Domain.Entities;

public class Goal
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public decimal GoalAmount { get; set; }

    public DateTime Deadline { get; set; }

    public decimal IdealMonthlySaving { get; set; }

    public GoalStatus Status { get; set; }

    public Transation? Transactions { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }
}
