using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity {get;}
        public abstract float NoiseLevel {get;}

        public void Fire()
        {
            Console.WriteLine($"Ammo Capacity: {AmmoCapacity}");
            Console.WriteLine($"Noise level: {NoiseLevel:f2}");
        } 
    }
}