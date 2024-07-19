using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Çalışması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();
            string sentence = "My name is Omer Koy";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Omering Koy";

            bool result3 = sentence.EndsWith("y");//cümlenin sonu y ile mi bitiyor
            bool result4 = sentence.StartsWith("My name");//cümlenin başı my name ile mi başkıyor

            var result5 = sentence.IndexOf("name");//cümlenin içinde name nerede onu söyler
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf("My");//cümlede aramaya sondan başlar

            var result8 = sentence.Insert(0, "Hello, ");//cümlenin istediğimiz yerine o eklentiyi yerleştirir

            var result9 = sentence.Substring(3);//cümleye istediğimiz yerden başlamamızı sağlar

            var result10 = sentence.ToLower();//tüm karakterleri küçük yapare lower yerine upper hepsini büyük yapar

            var result11 = sentence.Replace(" ", "-");// boşluk yerine çizgi koyduk

            var result12 = sentence.Remove(2);//itibaren uçur demek 2 den itibaren hepsini sildi



                Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(string.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
