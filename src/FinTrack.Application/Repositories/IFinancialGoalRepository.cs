using FinTrack.Application.Models.Request;
using FinTrack.Domain.Entities;

namespace FinTrack.Application.Repositories;

public interface IFinancialGoalRepository
{
    Task<FinancialGoal> PostCreateAsync(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken);
}
