using FinTrack.Application.Models.Request;

namespace FinTrack.Domain.Repositories;

public interface IFinancialGoalRepository
{
    Task Insert(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken);
}
