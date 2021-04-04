using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Services;
using NUnit.Framework;

namespace Tests
{
    public class Test
    {
        [Test]
        public async Task simple_test()
        {
            var service = new FileLinkExtractorService(new HttpClient());

            await service.Handle(null, CancellationToken.None);
            
            Assert.True(true);
        }
    }
}