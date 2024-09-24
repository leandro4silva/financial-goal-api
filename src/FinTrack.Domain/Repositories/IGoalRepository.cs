using FinTrack.Application.Models.Request;

namespace FinTrack.Domain.Repositories;

public interface IGoalRepository
{
    Task Insert(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken);
}
