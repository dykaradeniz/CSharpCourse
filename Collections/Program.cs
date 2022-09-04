using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
            // List();

            Dictionary<string, string> dictionary= new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table","masa");  // Bir anahtarla değere ulaşmayı hedeflediimiz ortamalrda kullanılır
            dictionary.Add("mermaid","deniz kizi");

            //Console.WriteLine(dictionary["table"]); // indexer vasıtasıyla girdiğimiz şeyin değerini istiyoruz dictionary içindeki
            //Console.WriteLine(dictionary["bardak"]); // bardak diye bir şey olmadığı için değeri de yoktur o yüzden hata verir

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);  
            }

            Console.WriteLine(dictionary.ContainsValue("kitap")); //o değer var mı diye arar
            Console.WriteLine(dictionary.ContainsKey("table")); // o anahtar kelime var mı diye arar

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Paris");
            cities.Add("München");

            Console.WriteLine(cities.Contains("Paris")); //içinde var mı

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { FirstName = "Derya", Id = 298 });
            //customers.Add(new Customer { FirstName = "Damla", Id = 215 });

            List<Customer> customers = new List<Customer>()
            {
                new Customer {FirstName = "Derya", Id = 298 },
                new Customer {FirstName = "Damla", Id = 215  }
            };


            var customer2 = new Customer
            {
                Id = 634,
                FirstName = "Esra"
            };
            customers.Add(customer2); //ekle
            customers.AddRange(new Customer[2] // bunu anlamadım
            {
                new Customer{Id = 108, FirstName="Kağan"},
                new Customer{Id= 30, FirstName="Beyda"}
            });

            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();

            var index = customers.IndexOf(customer2); //baştan bakmaya baaşlar
            Console.WriteLine("Index is {0}", index);

            customers.Add(customer2);
            var lastIndex = customers.LastIndexOf(customer2); // aramaya sondan başlar
            Console.WriteLine("LastIndex is {0}", lastIndex);

            customers.Insert(0, customer2); // kaçıncı sıraya neyi eklemek istiyorsun

            customers.Remove(customer2); // bulduğu ilk değeri remove yapar ve bitirir
            customers.RemoveAll(c => c.FirstName == "Esra"); // müşterilerden izmi esra olanalrı bul ve sil

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.Id);
            }
            var count = customers.Count; //eleman sayısı sayar
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Kocaeli");
            cities.Add("İzmir");
            cities.Add("Manisa");


            cities.Add("Karabük");
            cities.Add(16);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[3]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
