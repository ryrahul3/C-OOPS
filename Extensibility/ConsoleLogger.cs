using System;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
