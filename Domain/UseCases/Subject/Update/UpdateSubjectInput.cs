using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Subject.Update
{
    public class UpdateSubjectInput: IUseCaseInput
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
    }

    public class UpdateSubjectInputValidator : AbstractValidator<UpdateSubjectInput>
    {
        public UpdateSubjectInputValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.SubjectId)
                .EntityReference();

            RuleFor(x => x.TeacherId)
                .EntityReference();
        }
    }
}