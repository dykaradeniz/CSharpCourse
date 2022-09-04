using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirstName = "Derya";
            //customer.City = "İstanbul";

            Person[] persons = new Person[]
            {
                new Customer {FirstName="Derya"},
                new Student {FirstName="Damla"},
                new Person{FirstName="Esra"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }

        class Person // somut bir şey anlam ifade ediyor
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Person2
        {

        }
        //interfaceden farklı olarak sadece 1 kere inheritance yapılabilir.
        class Customer : Person //kalıtım oluyor Person2yi yazamayız
        {
            public string City { get; set; }
        }

        class Student:Person
        {
            public string Department { get; set; }
        }
    }
}
