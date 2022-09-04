using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();

            ActionDemo(); 

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(4, 5));

            Func<int> getRandomNumber = delegate ()  // parametresiz methodlara delege yapıyo ve int gönderiyo
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100); // aynı şey ama kısa yazım

            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(2);
            Console.WriteLine(getRandomNumber());

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); }); // ben buraya bir method göndericem ve bu methodun karşılı bit küme
                                                // bu içerdi yazanlar actiona karşılık geliyor
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void HandleException(Action action) // paametresiz method bloğudur. void operasyonlar için kullanılır ve herhangi bir rerturn almaz
        {
            try
            {
                action.Invoke(); // parametre olarak gönderdiğimiz findı çalıştır demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
               
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ayşe", "Zeynep", "Mehmet" };

            if (!students.Contains("Ahmet")) // ! yoksa anlamına gelir yani onu koymadan yapsaydık else kısmı gibi olacaktı
            {
                throw new RecordNotFoundException ("Record Not Found");
            }
            else
            {
                Console.WriteLine("Kayıt bulundu");
            }
        }

        private static void ExceptionIntro()
        {
            try  //hata yakalayıp söyleme
            {
                string[] students = new string[3] { "Derya", "Damla", "Esra" };
                students[3] = "Kağan";
            }
            catch (DivideByZeroException exception) // aldığı hata buysa
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) // hata varsa o hata bilgisi burda exception diye bir nesneye akatarılıyor
            {
                Console.WriteLine(exception.Message); // bunu kullanıcıya göstermek yerine kendimiz göebileceğimiz şekilde logglarız
                Console.WriteLine(exception.InnerException); // exception hakkında varsa daha detaylı bilgi verir

            }
        }
    }
}