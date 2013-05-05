using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.API
{
    public abstract class Plugin
    {
        public abstract string name { get; set; }
        public abstract string version { get; set; }
        public abstract string author { get; set; }
        public abstract void onEnable();
        public abstract void onDisable();
    }
}
