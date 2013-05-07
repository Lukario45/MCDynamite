using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite
{
    public class Pig : Entity
    {
        public override void onDeath()
        {
        }

        public override void onSpawn()
        {
        }

        public override int hearts
        {
            get { return 20; } //10 hearts
        }

        public override MobType type
        {
            get { return MobType.Passive; }
        }

        public override int attack
        {
            get { return 0; }
        }
    }
}
