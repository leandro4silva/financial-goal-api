using FinTrack.Application.Models.Request;
using FinTrack.Domain.Repositories;

namespace FinTrack.Infraestructure.Data.EF.Repositories;

public class FinancialGoalRepository : IFinancialGoalRepository
{
    private readonly FinTrackDbContext _context;

    public FinancialGoalRepository(FinTrackDbContext context)
    {
        _context = context;
    }

    public async Task Insert(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken)
    {
         await _context.AddAsync(request, cancellationToken);
    }
}
