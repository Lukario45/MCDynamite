using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public abstract class Player : Entity
    {
        public abstract string name { get; }
        public abstract string ip { get; }

        public override void onDeath()
        {
        }

        public override void onSpawn()
        {
        }

        public override int health
        {
            get { return 100; }
        }

        public override MobType type
        {
            get { return MobType.Player; }
        }
    }
}
