using System;
using ConsoleApp1.Model;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daraqın gulle tutumunu daxil edin:");
            int bulletCapacity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqdaki gülle sayini daxil edin:");
            int currentBullets=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqın bosalma saniyesini daxil edin:");
            double dischargeSeconds=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ates modunu secin:");
            string firingModeSingle = Console.ReadLine();
            Console.WriteLine("Ates modunu secin:");
            string firingModeAuto = Console.ReadLine();
            


            Weapon bullet = new Weapon();




            int key = 0;
            string value = "";
            do
            {
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1ci metod");
                        bullet.Shoot(currentBullets);

                        Console.WriteLine("----------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("2ci metod");
                        bullet.Fire(dischargeSeconds, 15);
                        Console.WriteLine("----------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("3cu metod");
                        Console.WriteLine(bullet.GetRemainBulletcount());
                        Console.WriteLine("----------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("4cu metod");
                        Console.WriteLine(bullet.Reload(currentBullets, bulletCapacity)); //bullet.Reload(currentBullets,bulletCapacity);
                        Console.WriteLine("----------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("5ci  metod");
                        bullet.ChangeFireMode("Avtomatik","Tekli");
                        Console.WriteLine("----------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("Proqramdan çıxdınız.Sağolun");
                        break;
                    case 0:
                        Console.WriteLine("0ci  metod");
                        bullet.GetInfo();
                        Console.WriteLine("----------------------------------");
                        break;
                        
                    default:
                        Console.WriteLine("Səhv Daxil Etdiniz");
                        break;
                }
            } while (key != 6);

            do
            {
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                value = Console.ReadLine();
                switch (key)
                {
                    case 7:
                        Console.WriteLine("Redakte et");
                        break;
                    case 'T':
                        Console.WriteLine("Tutumu deyisir");
                        break;
                    case 'S':
                        Console.WriteLine("Gulle Sayi");
                        break;
                    case 'D':
                        Console.WriteLine("Sifirlama saniyesi");
                        break;
                    default:
                        break;
                }
            }
                while (true) ;
                

        }
    }
}
