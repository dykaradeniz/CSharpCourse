using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // classı kullanmak için onun bir örneğinin oluşması lazım
            customerManager.Add();
            customerManager.Update(); // classın içindeki methodu çağırıp kullandık

            ProductManager productManager = new ProductManager();  //önce kılası kullanmak için yaptık
            productManager.Add(); // içindeki methodları çağırdık
            productManager.Update();

            Customer customer = new Customer(); //property kullanarak müşterinin bilgilerini tuttuk
            customer.City = "İstanbul";         // get set olduğu zaman bilgileri daha sonra kendimiz giriyoruz demek
            customer.Id = 298;
            customer.FirstName = "Derya"; // = dediğin zaman set etmiş oluruz ve set bloğu çalışır
            customer.LastName = "Karadeniz";

            // 2 kere de newleyip farklı customer bilgisi girebiliriz
            Customer customer2 = new Customer  // bu şekilde de kullanılabilir
            {
                Id = 108,
                City = "Kocaeli",
                LastName = "Karadeniz",
                FirstName = "Damla"

            };

            Console.WriteLine(customer2.FirstName); // burada eşitlik yok ismi al diyor o yüzden get bloğu

            Console.ReadLine();
        }
    }

}

