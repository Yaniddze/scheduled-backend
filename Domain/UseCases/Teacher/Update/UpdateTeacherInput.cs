using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Teacher.Update
{
    public class UpdateTeacherInput: IUseCaseInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateTeacherInputValidator : AbstractValidator<UpdateTeacherInput>
    {
        public UpdateTeacherInputValidator()
        {
            RuleFor(x => x.Id)
                .EntityReference();

            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}