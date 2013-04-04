using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.WorldPhysics
{
    public class Nanosecond
    {
#pragma warning disable 169, 414
        private int microsecond = 0;
#pragma warning restore 169, 414
        private int m_count;
        private DateTime time;
        public Nanosecond()
        {
            microsecond = 0;
            m_count = 0;
            time = new DateTime();
        }
        public bool RunMiliSecond()
        {
            if (DateTime.Now.Millisecond > time.Millisecond || DateTime.Now.Millisecond < time.Millisecond)
            {
                time = DateTime.Now;
                m_count++;
            }

            if (m_count == 4)
            {
                m_count = 0;
                return true;
            }
            else
                return false;
        }
    }
}
