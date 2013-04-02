using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.ServerPackets
{
    public class CreateInventoryPacket : PacketHandler
    {
        public slot Slot
        {
            get;
            set;
        }

        public CreateInventoryPacket(PacketType pt)
            : base(pt)
        {

        }

        public override bool BuildPacket()
        {
            AddSlot(Slot);
            return base.BuildPacket();
        }
    }
}
