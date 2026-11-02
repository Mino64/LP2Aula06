using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity => base.AmmoCapacity + 100;
        public GunClip(Gun decoratedGun) : base(decoratedGun)
        {
            
        }
    }
}