using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppDP
{
    //Singleton logger so we make sure its only one instance of it
    public class Logger
    {
        private static Logger _instance;
   
        private Logger()
        {
        }

        //Here we check if the instance of the logger is already created, if it is we return that. Else we create it for the first time and then return it. THis makes sure its only one instance of the logger in the application
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public void LogError(string message)
        {
            WriteConsole("Error: ", message);
        }

        public void LogInformation(string message)
        {
            WriteConsole("Information: ", message);
        }

        public void LogDebug(string message)
        {
            WriteConsole("Debug: ", message);
        }

        private void WriteConsole(string type, string message)
        {
            Console.WriteLine($"{DateTime.Now}: {type}{message}");
        }
    }
}
