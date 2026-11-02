using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guns
{
    public class MachineGun : Gun
    {
      public override int AmmoCapacity => 80;

        public override float NoiseLevel => 20.0f ;

    }
}