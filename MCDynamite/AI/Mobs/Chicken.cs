using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.AI.Mobs
{
    public class Chicken : Entity
    {
        public static event MobEventHandler onKillChicken;
        public static event MobEventHandler onSpawnChicken;

        public override void onKill()
        {
            Server.getServer().world.entities.Remove(this);

            if (onKillChicken != null)
            {
                onKillChicken();
            }
        }

        public override void onSpawn()
        {
            Server.getServer().world.entities.Add(this);

            if (onSpawnChicken != null)
            {
                onSpawnChicken();
            }
        }

        public override MobType type
        {
            get { return MobType.Passive; }
        }

        public override int health
        {
            get { return 100; }
        }
    }
}
