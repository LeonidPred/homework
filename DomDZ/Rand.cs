using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomDZ
{
    class Rand
    {
        private static Random Next;
        static Rand()
        {
            Next = new Random();
        }
    }
}
