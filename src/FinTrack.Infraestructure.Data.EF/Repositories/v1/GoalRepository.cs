using FinTrack.Application.Models.Request;
using FinTrack.Domain.Repositories;

namespace FinTrack.Infraestructure.Data.EF.Repositories.v1;

public class GoalRepository : IGoalRepository
{
    private readonly FinTrackDbContext _context;

    public GoalRepository(FinTrackDbContext context)
    {
        _context = context;
    }

    public async Task Insert(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken)
    {
        await _context.AddAsync(request, cancellationToken);
    }
}
