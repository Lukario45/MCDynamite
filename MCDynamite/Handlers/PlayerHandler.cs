using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite.Util;

namespace MCDynamite.Handlers
{
    public class PlayerHandler
    {
        public static PlayerList<Player> players = new PlayerList<Player>();

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
