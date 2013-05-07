using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCDynamite.Blocks;

namespace MCDynamite
{
    public abstract class World
    {
        public abstract string name { get; }
        public abstract BlockData[] blocks { get; }
        public List<Entity> entities = new List<Entity>();

        public void Compress()
        {
        }

        public void Decompress()
        {
        }
    }
}
