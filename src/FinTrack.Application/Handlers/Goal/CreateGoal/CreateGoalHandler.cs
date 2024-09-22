using MediatR;

namespace FinTrack.Application.Handlers.FinancialGoal.CreateFinancialGoal;
public class CreateGoalHandler : IRequestHandler<CreateGoalCommand, CreateGoalResult>
{
    public CreateGoalHandler()
    {
        
    }

    public Task<CreateGoalResult> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
