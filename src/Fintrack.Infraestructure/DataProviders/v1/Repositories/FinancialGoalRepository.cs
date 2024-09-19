using FinTrack.Application.Models.Request;
using FinTrack.Application.Repositories;
using FinTrack.Domain.Entities;

namespace Fintrack.Infraestructure.DataProviders.v1.Repositories;

public class FinancialGoalRepository : IFinancialGoalRepository
{
    public Task<FinancialGoal> PostCreateAsync(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
