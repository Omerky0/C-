using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool doğru veya yanlışı gösterir
            //Console.WriteLine("Hello World");
            
            double number5 = 10.4;//virgüllü sayılar 
            char character = 'B';
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 10;
            long number2 = 996481568;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("charachter is : {0}",(int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=1,Tueasday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
      
}
