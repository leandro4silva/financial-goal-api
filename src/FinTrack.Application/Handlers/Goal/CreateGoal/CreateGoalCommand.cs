using FinTrack.Application.Models.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace FinTrack.Application.Handlers.FinancialGoal.CreateFinancialGoal;

public class CreateGoalCommand : IRequest<CreateGoalResult>
{
    [FromBody]
    public CreateGoalRequest? Payload { get; set; }
}
