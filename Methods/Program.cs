using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2();

            //int number1 = 20;
            //int number2 = 100;
            //var result2= Add3(out number1, number2); // number1in degeri gidiyor sadece
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 6));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1, int number2 = 30) // 30 default deger ege  r bir sey eklenmezse bu kullanılır
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) //overloading method
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) // sonsuz değer girmemizi sağlar params
        {
            return numbers.Sum(); // parametre olarak girilen her şeyi toplama fonksiyonu
        }

    }
}
