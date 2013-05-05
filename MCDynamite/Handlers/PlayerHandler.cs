using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Handlers
{
    public class PlayerHandler
    {
        public static List<Player> players = new List<Player>();

        public static void newPlayer(Player p)
        {
            players.Add(p);
        }

        public static void delPlayer(Player p)
        {
            players.Remove(p);
        }
    }
}
