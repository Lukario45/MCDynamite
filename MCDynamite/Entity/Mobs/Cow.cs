using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public abstract class Cow : Entity
    {
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
            get { return MobType.Passive; }
        }
    }
}
