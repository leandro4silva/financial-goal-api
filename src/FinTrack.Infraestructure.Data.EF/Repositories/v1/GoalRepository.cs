using AutoMapper;
using FinTrack.Application.Models.Request;
using FinTrack.Domain.Entities;
using FinTrack.Domain.Repositories;
using Microsoft.Extensions.Logging;
using System.Reflection.Metadata;

namespace FinTrack.Infraestructure.Data.EF.Repositories.v1;

public class GoalRepository : IGoalRepository
{
    private readonly ILogger<GoalRepository> _logger;
    private readonly FinTrackDbContext _context;
    private readonly IMapper _mapper;

    public GoalRepository(ILogger<GoalRepository> logger, FinTrackDbContext context, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    public async Task Insert(PostCreateFinancialGoalRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(
            "{class} - {method} - Trace - Request {@request}",
            nameof(GoalRepository), nameof(Handle), request);

        var goal = _mapper.Map<Goal>(request);

        await _context.AddAsync(goal, cancellationToken);
    }
}
