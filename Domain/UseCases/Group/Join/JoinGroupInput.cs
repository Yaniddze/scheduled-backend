using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Group.Join
{
    public class JoinGroupInput: IUseCaseInput
    {
        public string Name { get; set; }
    }

    public class JoinGroupInputValidator : AbstractValidator<JoinGroupInput>
    {
        public JoinGroupInputValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}