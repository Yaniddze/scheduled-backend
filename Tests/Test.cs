using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Abstractions;
using Infrastructure.Services;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Test
    {
        [Test]
        public async Task simple_test()
        {
            var optionsMoq = new Mock<IOptions<LinksExtractorConfig>>();

            optionsMoq.Setup(x => x.Value)
                .Returns(new LinksExtractorConfig {
                    Url = "https://sustec.ru/?p=11546",
                    FilesDivClass = "entry-body",
                });

            var service = new FileLinkExtractorService(new HttpClient(), optionsMoq.Object);

            var result = await service.Handle(null, CancellationToken.None);
            
            Assert.IsNotEmpty(result);
        }
    }
}