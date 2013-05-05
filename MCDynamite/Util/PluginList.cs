using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Util
{
    public class PluginList<Plugin> : List<Plugin>
    {
        public void Add(Plugin p)
        {
            base.Add(p);
        }

        public void Remove(Plugin p)
        {
            base.Remove(p);
        }
    }
}
