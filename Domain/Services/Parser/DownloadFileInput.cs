using System.IO;
using MediatR;

namespace Domain.Services.Parser
{
    public class DownloadFileInput: IRequest<Stream>
    {
        public DownloadFileInput(string uri)
        {
            Uri = uri;
        }

        public string Uri { get; set; }
    }
}