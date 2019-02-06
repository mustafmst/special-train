using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ArabicToRoman
{
    public class HostedConverterService : IHostedService
    {
        private readonly ILogger<HostedConverterService> logger;
        private readonly IConverter converter;
        private readonly IConsoleArguments consoleArguments;

        public HostedConverterService(
            ILogger<HostedConverterService> logger,
            IConverter converter,
            IConsoleArguments consoleArguments
            )
        {
            this.logger = logger;
            this.converter = converter;
            this.consoleArguments = consoleArguments;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogTrace("Starting convertion");
            try
            {
                var arabic = Convert.ToDecimal(consoleArguments.ArabicNumber);
                var result = converter.ToRoman(arabic);
                Console.WriteLine($"Arabic: {arabic} | Roman: {result}");
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogTrace("Application closing");
            return Task.CompletedTask;
        }
    }
}
