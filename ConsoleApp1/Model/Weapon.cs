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

        public Weapon()
        {

        }

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

        public void GetInfo()
        {
            Console.WriteLine($"Darağın güllə tutumu:{bulletCapacity}");
            Console.WriteLine($"Daraqdakı güllə sayı:{currentBullets}");
            Console.WriteLine($"Darağın boşalma saniyəsi:{dischargeSeconds}");
            Console.WriteLine($"Atış modları: {firingModeSingle} {firingModeAuto}");
        }


        public void Shoot(int currentBullets)
        {

            Console.WriteLine($"1 gulle atildi");
            currentBullets = currentBullets - 1;
            Console.WriteLine($"Daraqdaki gulle sayi:{currentBullets}");
        }

        public  void Fire(double dischargeSeconds,double dischargeSeconds1)
        {
            if (dischargeSeconds>0 || dischargeSeconds1>0)
            {
                if (dischargeSeconds>=dischargeSeconds1)
                {
                    currentBullets = currentBullets - currentBullets;
                    Console.WriteLine($"Silahdaki bütün güllələr {dischargeSeconds} saniyədə boşaldı.Qalan gulle sayi:{currentBullets}");
                }
                else if (dischargeSeconds<=dischargeSeconds1)
                {
                    currentBullets = currentBullets - currentBullets;
                    Console.WriteLine($"Atəş zamanı nasazlığa görə güllələr {dischargeSeconds1} saniyədə boşaldı.Qalan gulle sayi:{currentBullets}");

                }
                else
                {
                    Console.WriteLine("Silahda güllə yoxdur");
                }
            }
            else
            {
                Console.WriteLine("Verilən zaman 0-dan kiçik ola bilməz");
            }
        }

        public int GetRemainBulletcount()
        {
            int count = 0;
            for (currentBullets =0; currentBullets < bulletCapacity; currentBullets++)
            {
                if (currentBullets<bulletCapacity)
                {
                    Console.WriteLine("Ehtiyac olan gulle sayi:");
                    count++;
                    
                }
                else if (currentBullets==bulletCapacity)
                {
                    Console.WriteLine("Gulleye ehtiyac yoxdur");
                    count++;
                   
                }
                else
                {
                    Console.WriteLine("gullenin sayi daraqdaki gulle sayindan cox ola bilmez");
                }
                
            }
            return count;
        }

        public int Reload(int currentBullets,int bulletCapacity)
        {
            //int countBullets = 0;
            //countBullets = bulletCapacity - currentBullets;
            //countBullets = countBullets + currentBullets;
            //Console.WriteLine($"Daraqdaki Gulle Sayi:{countBullets}");
            while (currentBullets == 0)
            {
                if (currentBullets < bulletCapacity)
                {
                    Console.WriteLine($"Daraqda yeniden {bulletCapacity} gulle var ");
                }
                else
                {
                    Console.WriteLine($"Daraqdaki güllərin sayı {bulletCapacity} darağın tutumu qədərdir ");
                }
            }
            return currentBullets;
        }

        public void ChangeFireMode()
        {
            string firingModeSingle = "Tekli";
            string firingModeAuto = "Avtomatik";
            Console.WriteLine($"Atəş modu:{firingModeSingle}");
            string firingMode = firingModeSingle.Replace(firingModeSingle,firingModeAuto);
            Console.WriteLine("Atəş modu dəyisdi");
            Console.WriteLine($"Atəş modu:{firingMode}");

        }

        
    }
}
