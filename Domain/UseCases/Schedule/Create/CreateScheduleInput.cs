using System;
using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Schedule.Create
{
    public class CreateScheduleInput: IUseCaseInput
    {
        public int GroupId { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }
        public int SubjectId { get; set; }
    }

    public class CreateScheduleInputValidator : AbstractValidator<CreateScheduleInput>
    {
        public CreateScheduleInputValidator()
        {
            RuleFor(x => x.GroupId)
                .EntityReference();

            RuleFor(x => x.StartDate)
                .NotEmpty();

            RuleFor(x => x.SubjectId)
                .EntityReference();

            RuleFor(x => x.DurationInMinutes)
                .GreaterThan(0);
        }
    }
}