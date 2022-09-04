using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql=new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add() // değişmek isterswk diğer classta
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer: Database
    {
        public override void Add() // virtualın işe yaraması için override kullanılır
        {
            Console.WriteLine("Added by Sql Code");
           // base.Add(); //inheritance edilmiş halini çalıştırır
        }
    }
    class MySql:Database
    {

    }
}
