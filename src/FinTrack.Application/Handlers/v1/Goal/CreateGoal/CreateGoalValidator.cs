using FluentValidation;

namespace FinTrack.Application.Handlers.v1.Goal.CreateGoal;

public class CreateGoalValidator : AbstractValidator<CreateGoalCommand>
{
    private readonly string _name = "name";
    private readonly string _goalAmount = "goalAmount";
    private readonly string _deadline = "deadline";
    private readonly string _idealMontlySaving = "idealMontlySaving";
    private readonly string _status = "status";

    public CreateGoalValidator()
    {
        RuleFor(request => request.Payload!.Name)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} é necessário")
            .WithName(_name);

        RuleFor(request => request.Payload!.GoalAmount)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} é necessário")
            .WithName(_goalAmount);

        RuleFor(request => request.Payload!.IdealMonthlySaving)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} é necessário")
            .WithName(_idealMontlySaving);

        RuleFor(request => request.Payload!.Deadline)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} é necessário")
            .WithName(_deadline);

        RuleFor(request => request.Payload!.Status)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} é necessário")
            .WithName(_status);
    }
}
