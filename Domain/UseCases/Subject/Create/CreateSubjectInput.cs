using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Subject.Create
{
    public class CreateSubjectInput: IUseCaseInput
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
    }

    public class CreateSubjectInputValidator : AbstractValidator<CreateSubjectInput>
    {
        public CreateSubjectInputValidator()
        {
            RuleFor(x => x.TeacherId)
                .EntityReference();

            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}