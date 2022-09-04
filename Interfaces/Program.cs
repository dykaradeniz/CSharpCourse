using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            //sqlServerCustomerDal.Add();
            MySqlCustomerDal mySqlCustomerDal = new MySqlCustomerDal();
            ICustomerDal[] customerDals = { sqlServerCustomerDal, oracleCustomerDal, mySqlCustomerDal};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            customerManager.Add(oracleCustomerDal);
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 298,
                Adress = "İstanbul",
                FirstName = "Derya",
                LastName = "Karadeniz"
            };

            //manager.Add(new Customer { Id = 298, Adress = "İstanbul", FirstName = "Derya", LastName = "Karadeniz" });

            Student student = new Student
            {
                Id = 108,
                FirstName = "Damla",
                LastName = "Karadeniz",
                Department = "Science"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) // paametre eklemesi olarak bana bir müşteri nesnesi ver
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
