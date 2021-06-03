using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Parser;

namespace Domain.UseCases.Parser
{
    public class ParserFileUseCase: IUseCase<ParseFileInput>
    {
        private readonly ParserService _service;

        public ParserFileUseCase(ParserService service)
        {
            _service = service;
        }

        public async Task<IOutput> Handle(ParseFileInput request, CancellationToken cancellationToken)
        {
            await _service.Parse(request.File);
            
            return ActionOutput.Success;
        }
    }
}