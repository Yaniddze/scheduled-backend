using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Services.Parser;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Domain.Background
{
    public class ParserBackgroundService : Domain.Background.Abstractions.BackgroundService
    {
        private IServiceProvider _provider;

        public ParserBackgroundService(IServiceProvider provider)
        {
            _provider = provider;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var services = _provider.CreateScope();

            var logger = services.ServiceProvider.GetRequiredService<ILogger<ParserBackgroundService>>();
            var service = services.ServiceProvider.GetRequiredService<ParserService>();

            logger.LogInformation("Start subjects parsing");

            try {
                await service.ParseSubjects();
            }
            catch (Exception e) {
                logger.LogError("Parsing failed", e.Message);
            }
            finally {
                await Task.Delay(1000 * 60 * 30);
            }
        }
    }
}