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
            //Value Types
            //Console.WriteLine("Hello World");

            double number5 = 10.4; // ondalikli sayilari tutar
            decimal number6 = 10.4m;
            char character = 'A'; // tekli karakter tutma
            bool condition = true; // true ya da false
            byte number4 = 0; // 0-255 arasi
            short number3 = -32768;
            int number1 = 2147483647; //2147483647 -2147483648
            long number2 = 2147483649; // long int'in 2kati sayiari tutar
            var number7 = 10;
            //number7 = 'A';

            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is: {0}", character); // (int)character yaparsak karakterin klavyedeki sayısal degerini verir
            Console.ReadLine();
        }
    }

    enum Days // degerler sirasiyla 0dan baslar ama esittir ile degistirebiliriz
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Sturday, Sunday
    }
}

