using Microsoft.Extensions.Logging;

namespace Project_Valeri_Extended.Loggers
{
    internal class LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new HashLogger(categoryName);
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
