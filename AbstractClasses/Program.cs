using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database= new Oracle(); // o onun babası olduğu için başa Database yazıp newleyebiliriz
            database.Add();
            database.Delete();
            
            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
            
            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add() // ekleme işemi aynı hepsinde
        {
            Console.WriteLine("Added by default"); 
        }
        // abstract classlar newlenmez
        public abstract void Delete(); // silme işlemi hesinde farklı
    }

    class SqlServer : Database // abstract olarak yaptığımız için kesin eklemek gerekioyr
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
