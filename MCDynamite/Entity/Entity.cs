using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public abstract class Entity
    {
        public delegate void EntityEventHandler();

        public abstract void onDeath();
        public abstract void onSpawn();
        public abstract int health { get; }
        public abstract MobType type { get; }
    }
}
