using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Group.Get
{
    public class GetGroupsInput: IUseCaseInput
    {
        
    }

    public class GetGroupsInputValidator : AbstractValidator<GetGroupsInput>
    {
        public GetGroupsInputValidator()
        {
            
        }
    }
}