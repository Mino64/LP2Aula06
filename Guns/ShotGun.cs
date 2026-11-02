using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public class ShotGun : Gun
    {
        public override int AmmoCapacity => 4;

        public override float NoiseLevel => 50.0f;
    }
}