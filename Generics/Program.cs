using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Kocaeli", "Istanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Kağan" }, new Customer { FirstName = "Esra" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            string[] test = { "kadir", "alper" }; // array
            List<string> testListesi = test.ToList(); // listeye çevirdi
            testListesi.Add("derya"); // listeye yeni eleman ekledi
            test = testListesi.ToArray(); // array formatına geri çevirdi

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<A> BuildList<A>(params A[] items)
        {
            return new List<A>(items);
        }
    }

    class Product : IEntity
    {
        public void Select()
        {
            Console.WriteLine("Selected!");
        }
    }
    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal : IRepository<Customer>
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student : IEntity //IEntityden implemente edilen bir sınıf veri tabanı nesnesidir
    {

    }

    interface IEntity
    {

    }

    // ben repository diye bir şey yapıcam ama bana çalışıcağım tipi ver
    interface IRepository<T> where T : class, IEntity, new() // generic bir yapıyı oluşturmak için interface classın sonuna <ICINDE HERHANGİ BIR SEY> yazmamız yeterli
    {   // sadece değer tip yapmak isteseydik struct yazcaktık
        List<T> GetAll();
        T Get(int id); //T döndüren bir fonksiyon

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            product.Select();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}