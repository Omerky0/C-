using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            if (number == 10)
            {
                Console.WriteLine("Evet sayı 10");
            }
            else if (number == 20)

            {

                Console.WriteLine("Sayı 20");
            }
            else
            {
                Console.WriteLine("Hayır Sayı 10 veya 20 değil");
            }

            switch (number)
            {
                case 10:
                    Console.WriteLine("Sayı 10");
                    break;
                case 20:
                    Console.WriteLine("Sayı 20");
                    break;
                default:
                    Console.WriteLine("Sayı 10 veya 20 değil");
                    break;
            }

            if (number >= 0 && number <= 100)
            {

                Console.WriteLine("Sayı 0 iler 100 arasındadır");
            }
            else if (number > 100 && number <= 200)
            {

                Console.WriteLine("Sayı 101 ile 200 arasındadır");
            }

            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Sayı 200 den büyük veya 0 dan küçüktür");
            }

            if (number < 100)
            {

                if (number >= 90)
                {


                }



                Console.ReadLine();
            }
        }
    }
}
