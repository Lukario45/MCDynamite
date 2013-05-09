using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite;

namespace MCDynamiteCLI
{
    class Program
    {
        static void OnProcessExit(object sender, EventArgs e)
        {
            Server.getServer().stopServer();
        }

        static void Main(string[] args)
        {
            string s;

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Console.Title = Server.getServer().motd + " | MCDynamite v" + Server.getServer().version;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Server.getLogger().Log("Starting server..");
            Server.getServer().startServer();
            Server.getLogger().Log("Finished setting up server!");

            while (true)
            {
                s = Console.ReadLine();
                Server.getServer().whileRunning();

                if (Server.getServer().OnReadLine != null)
                {
                    Server.getServer().OnReadLine();
                }

                if (s.StartsWith("/"))
                {
                    switch (s)
                    {
                        case "/ping":
                            Server.getLogger().Log("Pong!");
                            break;
                        case "/info":
                            Server.getLogger().Log("This server runs MCDynamite.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Server.getLogger().Log("Invalid command!");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                    }
                }

                if (s.StartsWith("/") == false)
                {
                    Server.getLogger().Log("Console: " + s);
                }
            }
        }
    }
}
