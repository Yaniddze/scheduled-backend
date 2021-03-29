using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Group.Create
{
    public class CreateGroupInput: IUseCaseInput
    {
        public string Name { get; set; }
    }

    public class CreateGroupInputValidator : AbstractValidator<CreateGroupInput>
    {
        public CreateGroupInputValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}