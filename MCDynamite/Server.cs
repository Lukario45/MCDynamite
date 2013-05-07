using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite.Logging;
using MCDynamite;
using MCDynamite.Handlers;
using MCDynamite.Util;
using MCDynamite.API;
using System.IO;

namespace MCDynamite
{
    public class Server
    {

        public Server()
        {
        }

        public string motd = "[MCDynamite] Default";
        public string version = "1.0.0.0";

        public int port = 25565;

        public bool online = true;
        public bool isRunning = false;

        public List<Logger> loggers = new List<Logger>();
        public OpList<Player> operators = new OpList<Player>();
        public PluginList<Plugin> plugins = new PluginList<Plugin>();

        public static Logger logger = new Logger();
        public static Server server = new Server();

        public World world;

        public static Server getServer()
        {
            return server;
        }

        public static Logger getLogger()
        {
            return logger;
        }

        public void startServer()
        {
            Console.Title = getServer().motd + " | MCDynamite v" + getServer().version;
            getServer().createDirsFiles();
            PluginManager.AutoLoadPlugins();
            PluginManager.EnableAllPlugins();
            ConnectionHandler ch = new ConnectionHandler();
        }

        public void createDirsFiles()
        {
            if (!Directory.Exists("plugins"))
            {
                Directory.CreateDirectory("plugins");
            }

            if (!File.Exists("plugins.txt"))
            {
                File.Create("plugins.txt");
            }
            if (!Directory.Exists("text"))
            {
                Directory.CreateDirectory("text");
            }

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
