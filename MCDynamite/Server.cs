using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite.Logging;
using MCDynamite;
using MCDynamite.Handlers;

namespace MCDynamite
{
    public class Server
    {
        public string motd = "[MCDynamite] Default";
        public string version = "1.0.0.0";

        public int port = 25565;

        public bool online = true;
        public bool isRunning = false;

        public List<Logger> loggers = new List<Logger>();

        public static Server server = new Server();

        public World world;

        public static Server getServer()
        {
            return server;
        }

        public void startServer()
        {
            Console.Title = motd + " | MCDynamite v" + getServer().version;
            ConnectionHandler ch = new ConnectionHandler();
        }

        public void stopServer()
        {
            Environment.Exit(0);
        }

        public void whileRunning()
        {
            foreach (Player p in PlayerHandler.players)
            {
                p.pThread.Start(); p.threadRunning = true;
            }
        }
    }
}
