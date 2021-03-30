using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Group.GetDetailed
{
    public class GetDetailedGroupInput: IUseCaseInput
    {
        public int Id { get; set; }
    }

    public class GetDetailedGroupInputValidator : AbstractValidator<GetDetailedGroupInput>
    {
        public GetDetailedGroupInputValidator()
        {
            RuleFor(x => x.Id)
                .EntityReference();
        }
    }
}