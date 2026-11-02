using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public abstract class GunDecorator : Gun
    {
        private readonly Gun decoratedGun;
        public override int AmmoCapacity => decoratedGun.AmmoCapacity;
        public override float NoiseLevel => decoratedGun.NoiseLevel;

        public GunDecorator (Gun decoratedGun)
        {
            this.decoratedGun = decoratedGun;
        }
    }
}