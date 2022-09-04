using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); //elçilik
    // void olan ve herhangi bir parametresi olmayan methodlara elçilik yapmak için kullanılan bir operasyondur
    
    public delegate void MyDelegate2(string text);
    // bir şey döndürmeyen ama string diye bir parametre alan methodlara

    public delegate int MyDelegate3(int number1, int number2);
    // iki int parametre isteyen ve int dönen methodlar

    public delegate string MyDelegate4(string message); // bu şekilde bir değer döndüren methodlar için kullanılırsa son eklediğine göre çalıştırır
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            // bu elçi customerManager'in SendMessageına delege edilmiş
            MyDelegate myDelegate = customerManager.SendMessage; //özel bir elçi
            myDelegate += customerManager.ShowAlert;
            myDelegate -=customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.ShowAlert2;
            myDelegate2 += customerManager.SendMessage2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            
            myDelegate3 += matematik.Carp;

            var sonuc=myDelegate3(4, 6);
            Console.WriteLine(sonuc);

            Messages message = new Messages();
            MyDelegate4 myDelegate4 = message.Text2;
            myDelegate4 += message.Text;

            Console.WriteLine(myDelegate4("su"));

            myDelegate2("hello"); // aynı parametreyi iki method için de gönderiyo
     
            myDelegate();

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }

    class Messages
    {
        public string Text(string text)
        {
            return text + "...";
        }

        public string Text2(string text)
        {
            return text;
        }
    }
}