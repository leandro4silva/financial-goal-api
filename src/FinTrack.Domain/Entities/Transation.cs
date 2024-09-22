using FinTrack.Domain.Enum;

namespace FinTrack.Domain.Entities;

public class Transation
{
    public Guid Id { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime TransactionDate { get; set; }

    public TransactionType TransactionType { get; set; }

    public bool IsDeleted { get; set; }
}
