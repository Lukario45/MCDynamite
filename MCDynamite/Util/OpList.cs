using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Util
{
    public class OpList<Player> : List<Player>
    {
        public void Add(Player p)
        {
            base.Add(p);
        }

        public void Remove(Player p)
        {
            base.Remove(p);
        }
    }
}
