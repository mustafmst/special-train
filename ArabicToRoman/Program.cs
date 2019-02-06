using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace ArabicToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IConsoleArguments>(sp =>
                    {
                        return new ConsoleArguments(
                            sp.GetService<ILogger<ConsoleArguments>>(),
                            args);
                    });
                    services.AddSingleton<IConverter, Converter>();
                    services.AddHostedService<HostedConverterService>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                    logging.SetMinimumLevel(LogLevel.Trace);
                })
                .Build();
                host.StartAsync(new System.Threading.CancellationToken());
                host.StopAsync(new System.Threading.CancellationToken());
                host.Dispose();
        }
    }
}
