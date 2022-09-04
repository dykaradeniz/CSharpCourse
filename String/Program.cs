using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "my name is derya";

            var result = sentence.Length;
            var result2 = sentence.Clone(); // klonluyor tam anlamadım
            sentence = "my name is damla";

            bool result3=sentence.EndsWith("a"); //bitiyor mu
            bool result4 = sentence.StartsWith("my name"); //başlıyor mu 

            var result5 = sentence.IndexOf("name"); //kaçıncı sırada başlıyor
            var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğu sayar ve aramaya devam etmez
            var result7 = sentence.LastIndexOf(" "); // aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, "); // girilen kısma eklemek için
            var result9 = sentence.Substring(3,4); //metni girilen yerden parçalar
            var result10 = sentence.ToLower(); // tüm karakterleri küçültür
            var result11 = sentence.ToUpper(); //tüm karakterleri büyütür
            var result12 = sentence.Replace(" ", "-"); //onu onunla değiştir
            var result13 = sentence.Remove(2,5); // belli bir indexten sonrasını atamaya sağlar
            
            //Console.WriteLine(result6);
            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "istanbul";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "ankara";
            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
