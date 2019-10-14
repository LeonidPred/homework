using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DomDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Missile[] Ammo = new Missile[5];
            for(int i = 0; i < 5; ++i)
            {
                Ammo[i] = new Missile();
                Console.WriteLine(Ammo[i].AmountOfExplosives);
            }
            Console.ReadKey();
        }
    }
}
