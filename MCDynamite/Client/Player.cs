using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Client
{
    public abstract class Player
    {
        public abstract string name { get; }
        public abstract string ip { get; }
    }
}
