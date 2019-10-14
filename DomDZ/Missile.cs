using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DomDZ
{
    public partial class Missile
    {
        public uint AmountOfExplosives { get; }
        private uint ExplodeRadius;
        private string Name;
        private uint FlyLength;

        //возвращает радиус взрыва
        public Missile()
        {
            AmountOfExplosives = (uint)rand.Next(10,100);
            ExplodeRadius = 10;
            FlyLength = 1000;
        }
        Missile(uint amo,uint exp,uint fly)
        {
            AmountOfExplosives = amo;
            ExplodeRadius = exp;
            FlyLength = fly;
        }
        public uint Explode()
        {
            return ExplodeRadius;
        }
        //проверяет, дотянется ли ракета до цели
        public bool IsReach(uint distance)
        {
            return FlyLength > distance ? true : false;
        }
        //возвращает имя
        public string GetName()
        {
            return Name;
        }
        //переименовывает ракету
        public void Rename(string rename)
        {
            Name = rename;
        }
        public uint Attack(ref Task obj)
        {
            return AmountOfExplosives;
        }
    }
}
