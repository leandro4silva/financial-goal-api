using FinTrack.Application.Handlers.v1.Goal.CreateGoal;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("v{version:apiVersion}/goal")]
[ApiController]
public class GoalController : ControllerBase
{
    [HttpPost]
    public void Post(CreateGoalCommand command)
    {

    }
}