using System.IO;
using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Parser
{
    public class ParseFileInput: IUseCaseInput
    {
        public Stream File { get; set; }
    }

    public class ParseFileInputValidator : AbstractValidator<ParseFileInput>
    {
        public ParseFileInputValidator()
        {
            
        }
    }
}