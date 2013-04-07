using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.API.Plugins
{
    public abstract class IPlugin
    {
        public abstract string name { get; }
        public abstract string author { get; }
        public abstract Version version { get; }

        public abstract void onEnable();
        public abstract void onDisable();

        /* --------- Events ---------
         * onServerStart();
         * onServerStop();
         * onBukkitPluginEnable();
         * onBukkitPluginDisable();
         * onClientListenerStart();
         * onClientListenerStop();
         */
    }
}
