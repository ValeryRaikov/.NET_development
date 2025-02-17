using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Project_Valeri_Extended.Loggers
{
    internal class FileLogger : ILogger
    {
        private readonly string _filePath;
        private readonly string _name;

        public FileLogger(string name, string filePath)
        {
            _name = name;
            _filePath = filePath;
        }

        IDisposable ILogger.BeginScope<TState>(TState state)
        {
            return null;
        }

        bool ILogger.IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        void ILogger.Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var message = $"[{logLevel}] [{_name}] EventId: {eventId.Id} - {formatter(state, exception)}";

            File.AppendAllText(_filePath, message + Environment.NewLine);

            Console.WriteLine($"Logged to file: {_filePath}");
        }
    }
}
