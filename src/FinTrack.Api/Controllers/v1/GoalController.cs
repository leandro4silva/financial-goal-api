using FinTrack.Api.ApiModels;
using FinTrack.Application.Handlers.v1.Goal.CreateGoal;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("v{version:apiVersion}/goal")]
[ApiController]
public class GoalController : ControllerBase
{
    private readonly IMediator _mediator;

    public GoalController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(typeof(ApiResponse<CreateGoalResult>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Post(CreateGoalCommand command, CancellationToken cancellationToken)
    {
        var output = await _mediator.Send(command, cancellationToken);
        return CreatedAtAction(
            "GetById",
            new { output.Id },
            new ApiResponse<CreateGoalResult>(output)
        );
    }

}