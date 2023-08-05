using Microsoft.Extensions.Logging;
using System;

namespace ApplicationLogger
{
    public class CustomLogger : ICustomLogger
    {
        private readonly ILogger _logger;
        public CustomLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void LogError(string message, Exception exception = null)
        {
            _logger.LogError(exception, message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }
    }
}
