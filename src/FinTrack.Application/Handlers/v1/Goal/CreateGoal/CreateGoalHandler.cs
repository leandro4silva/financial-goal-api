﻿using AutoMapper;
using FinTrack.Application.Interfaces;
using FinTrack.Application.Models.Request;
using FinTrack.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FinTrack.Application.Handlers.v1.Goal.CreateGoal;
public class CreateGoalHandler : IRequestHandler<CreateGoalCommand, CreateGoalResult>
{
    private readonly IMapper _mapper;
    private readonly ILogger<CreateGoalHandler> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGoalRepository _goalRepository;

    public CreateGoalHandler(IMapper mapper, ILogger<CreateGoalHandler> logger, IUnitOfWork unitOfWork, IGoalRepository goalRepository)
    {
        _mapper = mapper;
        _logger = logger;
        _unitOfWork = unitOfWork;
        _goalRepository = goalRepository;
    }

    public async Task<CreateGoalResult> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(
            "{class} - {method} - Trace - Request {@request}", 
            nameof(CreateGoalHandler), nameof(Handle), request);

        var input = _mapper.Map<PostCreateFinancialGoalRequest>(request);

        await _goalRepository.Insert(input, cancellationToken);
        await _unitOfWork.Commit(cancellationToken);

        var response = _mapper.Map<CreateGoalResult>(input);

        return response;
    }
}
