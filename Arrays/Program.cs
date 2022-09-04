using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[2];
            students[0] = "derya";
            students[1] = "damla";

            string[] students3 = new string[2] { "derya", "damla" };

            string[] students2 = { "derya", "damla" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            //çok boyutlu dizi
            string[,] regions = new string[5, 3] // 5 bölge var her blge için 3 şehir
            {
                {"istanbul","izmit","balıkesir" },
                { "ankara","konya","kırıkkale"},
                {"antalya","adana","mersin" },
                { "rize","trabzon","samsun"},
                { "izmir","muğla","manisa"},

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //0.dimenson satırlar
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("****************");
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
