using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Domain.Services.Parser;
using HtmlAgilityPack;
using MediatR;

namespace Infrastructure.Services
{
    public class FileLinkExtractorService: IRequestHandler<FileLinksExtractorInput, List<string>>
    {
        private readonly HttpClient _client;

        public FileLinkExtractorService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<string>> Handle(FileLinksExtractorInput request, CancellationToken cancellationToken)
        {
            var html = await _client.GetStringAsync("https://sustec.ru/?p=11546");
            
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var values = doc.DocumentNode.Descendants("div")
                .Where(x => x.GetAttributeValue("class", "").Contains("entry-body"));
            
            return new List<string>();
        }
    }
}