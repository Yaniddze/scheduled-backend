using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Schedule.Delete
{
    public class DeleteScheduleInput: IUseCaseInput
    {
        public int ScheduledId { get; set; }
    }

    public class DeleteScheduleInputValidator : AbstractValidator<DeleteScheduleInput>
    {
        public DeleteScheduleInputValidator()
        {
            RuleFor(x => x.ScheduledId)
                .EntityReference();
        }
    }
}