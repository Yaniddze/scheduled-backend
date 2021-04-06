using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Domain.Services.Parser;
using HtmlAgilityPack;
using Infrastructure.Abstractions;
using MediatR;
using Microsoft.Extensions.Options;

namespace Infrastructure.Services
{
    public class FileLinkExtractorService: IRequestHandler<FileLinksExtractorInput, List<string>>
    {
        private readonly HttpClient _client;
        private readonly LinksExtractorConfig _config;

        public FileLinkExtractorService(HttpClient client, IOptions<LinksExtractorConfig> config)
        {
            _client = client;
            _config = config.Value;
        }

        public async Task<List<string>> Handle(FileLinksExtractorInput request, CancellationToken cancellationToken)
        {
            var html = await _client.GetStringAsync(_config.Url);
            
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var divNode = doc.DocumentNode.Descendants("div")
                .FirstOrDefault(x => x.GetAttributeValue("class", "").Contains(_config.FilesDivClass));

            if (divNode is null) 
            {
                throw new Exception("There is no div with links");
            }

            var links = divNode.SelectNodes("//a[@href]")
                .Select(x => x.GetAttributeValue("href", ""))
                .Where(x => x.EndsWith(".docx"))
                .ToList();
            
            return links;
        }
    }
}