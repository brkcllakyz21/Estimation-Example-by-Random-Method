using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimation_Example_by_Random_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayı = new Random();
            int sayaç = 1, soru = 0, cevap = 0;

            soru = sayı.Next(1, 20);
            while (sayaç < 4)
            {
                Console.Write("Tahmininizi giriniz = ");
                cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == soru)
                {
                    Console.WriteLine("Tebrikler " + sayaç + ". adımda kazandınız");
                    Console.WriteLine("Sayı = " + soru);
                    sayaç = 5;
                }
                sayaç++;
            }

            if (sayaç == 4)
            {
                Console.WriteLine("Maalesef kaybettiniz.");
                Console.WriteLine("Sayı = " + soru);
            }



        }
    }
}
