using System;
using Microsoft.Extensions.Logging;

namespace ArabicToRoman
{
    public class ConsoleArguments : IConsoleArguments
    {
        private readonly ILogger<ConsoleArguments> logger;
        public decimal ArabicNumber { get; }
        public ConsoleArguments(
            ILogger<ConsoleArguments> logger,
            string[] args
            )
        {
            this.logger = logger;
            try
            {
                ArabicNumber = Convert.ToDecimal(args[0]);
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }
        }
    }
}
