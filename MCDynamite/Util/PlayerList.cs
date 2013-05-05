using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Util
{
    public class PlayerList<Player> : List<Player>
    {
        public void Add(Player p)
        {
            base.Add(p);
        }
    }
}
