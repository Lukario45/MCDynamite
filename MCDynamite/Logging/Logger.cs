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
        public static event LogEventHandler onLoggerDelete;

        public string name;

        public Logger(string name)
        {
            this.name = name;
            Server.getServer().loggers.Add(this);
        }

        public void deleteLogger(string name)
        {
            foreach (Logger l in Server.getServer().loggers)
            {
                if (l.name == name)
                {
                    Server.getServer().loggers.Remove(l);

                    if (onLoggerDelete != null)
                    {
                        onLoggerDelete();
                    }
                }
            }
        }

        public static void Log(string log)
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
