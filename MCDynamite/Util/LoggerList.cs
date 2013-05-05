using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Util
{
    public class LoggerList<Logger> : List<Logger>
    {
        public void Add(Logger l)
        {
            base.Add(l);
        }

        public void Remove(Logger l)
        {
            base.Remove(l);
        }

        public void changeMainLogger(Logger l)
        {
            Server.logger.Equals(l);
        }
    }
}
