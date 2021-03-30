using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using FluentValidation;

namespace Domain.UseCases.Subject.Get
{
    public class GetSubjectsInput: IUseCaseInput
    {
        
    }

    public class GetSubjectsInputValidator : AbstractValidator<GetSubjectsInput>
    {
        public GetSubjectsInputValidator()
        {
            
        }
    }
}