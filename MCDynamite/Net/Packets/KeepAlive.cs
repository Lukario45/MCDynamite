using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Net.Packets
{
    public class KeepAlive : IPacket
    {
        public override byte hex
        {
            get { return PacketList.KeepAlive; }
        }

        public override void read(System.IO.Stream stream)
        {
            byte[] number = Encoding.ASCII.GetBytes(hex.ToString());
            stream.Read(number, 0, 0);
        }

        public override void write(System.IO.Stream stream)
        {
            byte[] number = Encoding.ASCII.GetBytes(hex.ToString()); //not sure if this is right
            stream.Write(number, 0, 0);
        }
    }
}
