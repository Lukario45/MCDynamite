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
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Server server = new Server(); //throws a weird exception here..
            server.startServer();

            while (true)
            {
                Server.getServer().whileRunning();
            }
        }
    }
}
