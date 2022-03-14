using System;
using ConsoleApp1.Model;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daraqin gulle tutumunu daxil edin:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqdaki gulle sayini daxil edin:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqin bosalma saniyesini daxil edin:");
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Atis modunu secin:");
            Console.ReadLine();


            Weapon bullet = new Weapon(30);
            bullet.Shoot();
        }
    }
}
