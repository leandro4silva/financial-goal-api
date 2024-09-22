using FinTrack.Application.Handlers.FinancialGoal.CreateFinancialGoal;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Controllers;
[Route("api/[controller]")]
public class GoalController : ControllerBase
{
    [HttpPost]
    public void Post(CreateGoalCommand command)
    {

    }   
}