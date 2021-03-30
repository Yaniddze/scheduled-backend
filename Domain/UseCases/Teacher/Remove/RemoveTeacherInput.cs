using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Teacher.Remove
{
    public class RemoveTeacherInput: IUseCaseInput
    {
        public int TeacherId { get; set; }
    }

    public class RemoveTeacherInputValidator : AbstractValidator<RemoveTeacherInput>
    {
        public RemoveTeacherInputValidator()
        {
            RuleFor(x => x.TeacherId)
                .EntityReference();
        }
    }
}