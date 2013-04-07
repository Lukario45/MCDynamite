using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.API.Commands
{
    public abstract class ICommand
    {
        public abstract string name { get; }
        public abstract string author { get; }
        public abstract Version version { get; }

        public abstract void onUse(PlayerClass p, string message);
        public abstract void onHelp(string message);
    }
}
