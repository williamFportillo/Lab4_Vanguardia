using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Infraestructure
{
    public class ConsoleLogger : ILogger
    {
        private static ConsoleLogger _instance = null;

        protected ConsoleLogger()
        {

        }

        public static ConsoleLogger Instance()
        {
            if (_instance == null)
            {
                _instance = new ConsoleLogger();
            }

            return _instance;
        }
        public static void Log(string message) => Console.WriteLine(message);
        
    }
}
