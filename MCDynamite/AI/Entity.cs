using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.AI
{
    public abstract class Entity
    {
        public delegate void MobEventHandler();

        public abstract void onKill();
        public abstract void onSpawn();
        public abstract MobType type { get; }
        public abstract int health { get; }
    }
}
