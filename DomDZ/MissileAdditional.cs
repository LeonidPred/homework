using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomDZ
{
    public partial class Missile
    {
        private static float Speed;
        private static Random rand { get; }
        static Missile()
        {
            Speed = (float)343.3;//скорость звука
            rand = new Random();
        }
    }
}