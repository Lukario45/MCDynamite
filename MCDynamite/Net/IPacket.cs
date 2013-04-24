using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCDynamite.Net
{
    public abstract class IPacket
    {
        public abstract byte hex { get; }
        public abstract void read(Stream stream);
        public abstract void write(Stream stream);
    }
}
