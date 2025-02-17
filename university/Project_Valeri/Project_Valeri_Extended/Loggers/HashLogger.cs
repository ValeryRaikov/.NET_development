using System;
using System.Collections.Concurrent;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Project_Valeri_Extended.Loggers
{
    internal class HashLogger : ILogger
    {
        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public HashLogger(string name)
        {
            _name = name;
            _logMessages = new ConcurrentDictionary<int, string>();
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
            var message = formatter(state, exception);

            switch (logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine("- LOGGER -");
            var messageToBeLogged = new StringBuilder();
            messageToBeLogged.Append($"[{logLevel}]");
            messageToBeLogged.AppendFormat(" [{0}]", _name);
            Console.WriteLine(messageToBeLogged);
            Console.WriteLine($" {formatter(state, exception)}");
            Console.WriteLine("- LOGGER -");
            Console.ResetColor();

            _logMessages[eventId.Id] = message;
        }

        public void PrintAllMessages()
        {
            Console.WriteLine("---- All Logged Messages ----");
            foreach (var entry in _logMessages)
            {
                Console.WriteLine($"EventId: {entry.Key}, Message: {entry.Value}");
            }

            Console.WriteLine("-----------------------------");
        }

        public void PrintMessageByEventId(int eventId)
        {
            if (_logMessages.TryGetValue(eventId, out var message))
            {
                Console.WriteLine($"EventId: {eventId}, Message: {message}");
            }
            else
            {
                Console.WriteLine($"No log found for EventId: {eventId}");
            }
        }

        public void DeleteMessageByEventId(int eventId)
        {
            if (_logMessages.TryRemove(eventId, out _))
            {
                Console.WriteLine($"Log with EventId {eventId} deleted.");
            }
            else
            {
                Console.WriteLine($"No log found for EventId: {eventId}.");
            }
        }
    }
}
