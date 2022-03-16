using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Weapon
    {
        
        public int bulletCapacity 
        {
            get 
            {
                if (bulletCapacity > 0 && bulletCapacity < 100)
                {
                    Console.WriteLine("Lazimi gulle var");
                }
                else if (bulletCapacity < 0)
                {
                    Console.WriteLine("Gulle yoxdur");
                }
                return 0;
            }
            set 
            {
                if (bulletCapacity>0 && bulletCapacity<100)
                {
                    value = bulletCapacity;
                }
                else if (bulletCapacity<0)
                {
                    value = 0;
                }
            } 
        }   
        public int currentBullets { get; set; }
        public double dischargeSeconds { get; set; }
        public string firingModeSingle { get; set; }
        public string firingModeAuto { get; set; }

        public Weapon()
        {

        }

        public void Edit()
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
            Console.WriteLine($"Daraqin gulle tutumu:{bulletCapacity}");
            Console.WriteLine($"Daraqdakı gulle sayi:{currentBullets}");
            Console.WriteLine($"Daraqın bosalma saniyesi:{dischargeSeconds}");
            Console.WriteLine($"Ates modlari: {firingModeSingle} {firingModeAuto}");
        }


        public void Shoot(int currentBullets)
        {
            bool isFire = false;
            if (isFire==true)
            {
                Console.WriteLine($"1 gulle atildi");
                Console.WriteLine("Partt");
               
            }
            else
            {
                Console.WriteLine($"1 gulle atildi");
                Console.WriteLine("Partt");
                currentBullets = currentBullets - 1;
                Console.WriteLine($"Daraqdaki gulle sayi:{currentBullets}");
            }
           
        }

        public  void Fire(double dischargeSeconds,double dischargeSeconds1)
        {
            if (dischargeSeconds>0 || dischargeSeconds1>0)
            {
                if (dischargeSeconds>=dischargeSeconds1)
                {
                    Console.WriteLine("Dirrrr dirrrrr");
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

        public string ChangeFireMode(string firingModeSingle, string firingModeAuto)
        {
            
            Console.WriteLine($"Atəş modu:{firingModeSingle}");
            string firingMode = firingModeSingle.Replace(firingModeSingle,firingModeAuto);
            Console.WriteLine("Atəş modu dəyisdi");
            Console.WriteLine($"Atəş modu:{firingMode}");
            return firingMode;
        }

        
    }
}
