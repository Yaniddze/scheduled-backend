using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Schedule.Get
{
    public class GetScheduleInput: IUseCaseInput
    {
        public string Date { get; set; }
        public int GroupId { get; set; }
    }

    public class GetScheduleInputValidator : AbstractValidator<GetScheduleInput>
    {
        public GetScheduleInputValidator()
        {
            RuleFor(x => x.Date)
                .NotEmpty();

            RuleFor(x => x.GroupId)
                .EntityReference();
        }
    }
}