using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Yilmaz", Age = 12 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.AddNew(customer);

            Console.ReadLine();
        }

        [ToTable("Customers")] // attribute a parametre yolluyor
        [ToTable("TblCustomers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }

        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use AddNew Method")] // hazır attribute
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1}{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1}{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }

        // [AttributeUsage(AttributeTargets.All)] // bu attributeı her şeye kullanabilirsin
        // [AttributeUsage(AttributeTargets.Class)] // bu attribute sadece classda kullanılabilir
        // [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] // all kullanmadan iki farklı yerde kullanmak istersek
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)] // allow multipe birden fazla aynı şeyde kullanabilir miyim demek
        class RequiredPropertyAttribute : Attribute
        {

        }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        class ToTableAttribute : Attribute
        {
            string _tableName;
            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }
    }
}