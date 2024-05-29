using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torensvanhanoiopdr1
{
    internal class HanoiDisc
    {
        private int size;
        public HanoiDisc(int set_size)
        {
            size = set_size;
        }
        public int getSize()
        {
            return size;
        }
    }
}
