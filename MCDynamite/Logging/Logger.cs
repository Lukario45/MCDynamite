using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Logging
{
    public class Logger
    {
        public delegate void LogEventHandler();
        public static event LogEventHandler onLog;

        public static string name;

        public static string getName()
        {
            return name;
        }

        public void Log(string log)
        {
            if (onLog != null) 
            {
                onLog();
            } 
            else 
            {
                Console.WriteLine("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + log);
            }
        }
    }
}
