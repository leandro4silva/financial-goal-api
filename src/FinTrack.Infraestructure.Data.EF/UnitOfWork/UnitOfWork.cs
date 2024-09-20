using FinTrack.Application.Interfaces;

namespace FinTrack.Infraestructure.Data.EF.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly FinTrackDbContext _context;

    public UnitOfWork(FinTrackDbContext context)
    {
        _context = context;
    }

    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public Task Rollback(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
