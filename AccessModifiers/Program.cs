using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
       protected int Id { get; set; }
        public void Delete()
        {
            
        }
        public void Save()
        {


        }
    }

    class Student: Customer
    {
        public void Save2()
        {
           
           
        }
    }
    public class Course // bi classın defaultu internaldır
    {
        public string Name { get; set; }

        private class NestedClass // private iç içe classlada kullanılırz
        {

        }
    }
}
