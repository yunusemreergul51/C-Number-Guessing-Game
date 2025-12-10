using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100);
            bool oyun = false;
            int tur = 0;
            Console.Write("Lütfen bir sayı giriniz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            while (!oyun)
            {
                tur++;
                if (tahmin < sayi)
                {
                    Console.Write("Lütfen daha büyük bir sayı giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                }
                else if (tahmin > sayi)
                {
                    Console.Write("Lütfen daha küçük bir sayı giriniz: ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("----------------------\nTebrikler oyunu kazandınız!!!!\nToplam Tur Sayısı: " + tur);
                    oyun = true;
                }
            }


        }
    }
}
