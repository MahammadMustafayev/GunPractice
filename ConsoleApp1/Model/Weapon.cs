using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Weapon
    {
        int bulletCapacity;
        int currentBullets;
        double dischargeSeconds;
        string firingModeSingle;
        string firingModeAuto;


        public Weapon(int bulletCapacity)
        {
            this.bulletCapacity = bulletCapacity;
        }

        public Weapon(int bulletCapacity,int currentBullets):this(bulletCapacity)
        {
            this.currentBullets = currentBullets;
        }

        public Weapon(int bulletCapacity, int currentBullets,double dischargeSeconds):this(bulletCapacity,currentBullets)
        {
            this.dischargeSeconds = dischargeSeconds;
        }

        public Weapon(int bulletCapacity, int currentBullets, double dischargeSeconds,string firingModeSingle):this(bulletCapacity, currentBullets,dischargeSeconds)
        {
            this.firingModeSingle = firingModeSingle;
        }

        public Weapon(int bulletCapacity, int currentBullets, double dischargeSeconds, string firingModeSingle,string firingModeAuto):this(bulletCapacity, currentBullets, dischargeSeconds,firingModeSingle)
        {
            this.firingModeAuto = firingModeAuto;
        }

        public void Shoot()
        {

            Console.WriteLine($"1 gulle atildi");
            currentBullets = bulletCapacity - 1;
            Console.WriteLine($"Daraqdaki gulle sayi:{currentBullets}");
        }

        public  void Fire()
        {
            for (double i = 0; i < dischargeSeconds; i++)
            {

            }
        }

        public int GetRemainBulletcount()
        {
            return 0;
        }

        public int Reload()
        {
            return 0;
        }
    }
}
