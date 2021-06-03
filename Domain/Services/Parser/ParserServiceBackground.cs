using System.Threading.Tasks;
using MediatR;

namespace Domain.Services.Parser
{
    public class ParserServiceBackground
    {
        private readonly IMediator _mediator;
        private readonly ParserService _service;

        public ParserServiceBackground(IMediator mediator, ParserService service)
        {
            _mediator = mediator;
            _service = service;
        }

        public async Task ParseSubjects()
        {
            var links = await _mediator.Send(new FileLinksExtractorInput());

            foreach (var link in links)
            {
                var file = await _mediator.Send(new DownloadFileInput(link));

                await _service.Parse(file);
            }
        }
    }
}