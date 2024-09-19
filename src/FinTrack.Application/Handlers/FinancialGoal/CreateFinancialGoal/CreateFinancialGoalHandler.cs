using MediatR;

namespace FinTrack.Application.Handlers.FinancialGoal.CreateFinancialGoal;
public class CreateFinancialGoalHandler : IRequestHandler<CreateFinancialGoalCommand, CreateFinancialGoalResult>
{
    public CreateFinancialGoalHandler()
    {
        
    }

    public Task<CreateFinancialGoalResult> Handle(CreateFinancialGoalCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
