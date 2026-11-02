using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel => base.NoiseLevel * 0.2f;
        public GunSilencer(Gun decoratedGun) : base(decoratedGun)
        {
        }
    }
}