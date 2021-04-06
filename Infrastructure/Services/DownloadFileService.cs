using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Domain.Services.Parser;
using MediatR;

namespace Infrastructure.Services
{
    public class DownloadFileService : IRequestHandler<DownloadFileInput, Stream>
    {
        public Task<Stream> Handle(DownloadFileInput request, CancellationToken cancellationToken)
        {
            var client = new HttpClient();

            return client.GetStreamAsync(request.Uri);
        }
    }
}