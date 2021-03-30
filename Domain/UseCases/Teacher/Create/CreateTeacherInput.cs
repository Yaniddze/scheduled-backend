using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Teacher.Create
{
    public class CreateTeacherInput: IUseCaseInput
    {
        public string Name { get; set; }
    }

    public class CreateTeacherInputValidator : AbstractValidator<CreateTeacherInput>
    {
        public CreateTeacherInputValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}