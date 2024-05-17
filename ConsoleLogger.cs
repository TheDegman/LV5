using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    using System;

    public class ConsoleLogger
    {
        private static ConsoleLogger consoleLogger;
        private static readonly object LockCheck = new object();

        private ConsoleLogger() { }

        public static ConsoleLogger Instance
        {
            get
            {
                lock (LockCheck)
                {
                    if (consoleLogger == null)
                    {
                        consoleLogger = new ConsoleLogger();
                    }
                    return consoleLogger;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Data accessed at {DateTime.Now}");
        }
    }

}
