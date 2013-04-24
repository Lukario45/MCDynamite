using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite;

namespace MCDynamiteCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.getServer().startServer();

            while (true)
            {
            }
        }
    }
}
