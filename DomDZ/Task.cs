using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomDZ
{
    public class Task
    {
        private uint Length;
        private uint Width;
        private bool Is_destroyed;
        private uint Durability;
        private Random rand;
        public Task()
        {
            rand = new Random();
            Length = (uint)rand.Next(1, 10);
            Width = (uint)rand.Next(1, 10);
            Durability = (uint)rand.Next(50, 100);
            Is_destroyed = false;
        }
        private void Destroy()
        {
            Durability = 0;
            Is_destroyed = true;
        }
        public void TakeDamage(uint damage)
        {
            if (damage >= Durability&&!Is_destroyed)
            {
                Destroy();
            }
        }
    }
}
