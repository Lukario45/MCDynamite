using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public class Server
    {
        public string motd = "[MCDynamite] Default";
        public string version = "1.0.0.0";

        public int port = 25565;

        public bool online = true;
        public bool isRunning = false;

        public static Server server;

        public static Server getServer()
        {
            return server;
        }

        public void startServer()
        {
            Console.Title = motd + " | MCDynamite v" + getServer().version;
        }

        public void stopServer()
        {
            Environment.Exit(0);
        }

        public void whileRunning()
        {
            //handle connections, etc
        }
    }
}
