using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public class Server
    {
        public string motd = "[MCDynamite] Default";
        public int port = 25565;
        public bool online = true;
        public string version = "1.0.0.0";

        public static Server server;

        public static Server getServer()
        {
            return server;
        }

        public void startServer()
        {
            Console.Title = motd + " | MCDynamite v" + getServer().version;
        }

        public void whileRunning()
        {
            //handle connections, etc
        }
    }
}
