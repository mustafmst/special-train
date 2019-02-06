using Microsoft.Extensions.Logging;

namespace ArabicToRoman
{
    public class Converter : IConverter
    {
        private readonly ILogger<Converter> logger;

        public Converter(
            ILogger<Converter> logger
        )
        {
            this.logger = logger;
        }
        public string ToRoman(decimal arabic)
        {
            logger.LogTrace("Argument: {}", arabic);
            throw new System.NotImplementedException();
        }
    }
}
