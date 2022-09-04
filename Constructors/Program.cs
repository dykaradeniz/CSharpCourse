using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            Product product = new Product { Id = 8, Name = "Derya" };
            Product product2 = new Product(10, "Damla");

            EmployeeManager employeeManager= new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Tree");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSmth(); // static olunca direkt çağırabiliriz
            Manager manager = new Manager();
            manager.DoSmth2(); // statc değilse normal çağırırız
           
            
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 8; // private değişkenler _ ile kullanılır
        public CustomerManager(int count) // method halinde ise kullanılmaz
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }

    }

    class Product
    {
        public Product()
        {

        }
        
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        string _message;
        public BaseClass(string message)
        {
            _message = message;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _message);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string message):base(message)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
        
    }

    static class Teacher // ortak kullanılır bir yerde değişirde her yerde değişir farklı kullanılamaz
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            // mutlaka çalışmasını istediğin kod bloğu
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSmth()
        {
            Console.WriteLine("Done");
        }

        public void DoSmth2()
        {
            Console.WriteLine("Done2");
        }
    }
}
