using System;

namespace Guns
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Gun mGun = new MachineGun();

            Console.WriteLine("======= Basic Machine gun ========");
            mGun.Fire();

            Gun mGunWithCLip = new GunClip(mGun);


            Console.WriteLine("======= Basic Machine gun with clip========");
            mGunWithCLip.Fire();

            mGun = new GunSilencer(new GunSilencer(new GunClip(mGun)));
            Console.WriteLine("======= Bastard Blaster ========");
            mGun.Fire();
        }
    }
}
