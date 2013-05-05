using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCDynamite.Net
{
    public class Packet
    {
        public static List<byte> packets = new List<byte>();

        public static void Read(byte[] data, PacketStream ps)
        {
            ps.Read(data, 1, 1); //probably wrong
        }

        public static void Write(byte data, PacketStream ps)
        {
            ps.WriteByte(data);
        }
    }
}
