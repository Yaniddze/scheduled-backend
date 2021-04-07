using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var services = _provider.CreateScope();

            var logger = services.ServiceProvider.GetRequiredService<ILogger<ParserBackgroundService>>();
            var service = services.ServiceProvider.GetRequiredService<ParserService>();
            var unitCreator = services.ServiceProvider.GetRequiredService<IUnitOfWorkCreator>();

            logger.LogInformation("Start subjects parsing");

            using var unit = unitCreator.CreateUnitOfWork();

            try {
                await service.ParseSubjects();
                await unit.Apply();
            }
            catch (Exception e) {
                logger.LogError("Parsing failed", e.Message);
                await unit.Cancel();
            }
            finally {
                await Task.Delay(1000 * 60 * 30);
            }
        }
    }
}