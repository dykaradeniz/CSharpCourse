using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    DortIslem dortIslem = new DortIslem(2, 3);
            //    Console.WriteLine(dortIslem.Topla2()); // topla2 ilk girdiğimiz constructordaki değerlerden çalışıyor
            //    Console.WriteLine(dortIslem.Topla(5,6));// topla1 kendisi parametre istiyor

            var tip = typeof(DortIslem); // benim çalışacağım bir tip var o da dört işlem
            // bunu yaparak newi çalışma anında yapmış oluyoruz
            // gelen tipe göre göre bunu gerçekleştiriyoruz        // parametereli ctor için 6 7 yazdık
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7);//  =  DortIslem dortIslem = new DortIslem(2, 3);
            //DortIslem tipinde bir veri döndürüceğimiz için onu yazdık aslında
            Console.WriteLine(dortIslem.Topla(4, 5));
            Console.WriteLine(dortIslem.Topla2());

            var instance = (DortIslem)Activator.CreateInstance(tip, 6, 7);

            // get methodla istediğin methoda ulaşıyosun invokela onu çalıştırıyosun

            Console.WriteLine(instance.GetType().GetMethod("Topla").Invoke(instance, new object[] { 5, 7 })); // method bilgisi oluşturuyor

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); // burda sadece method bilgisi toplayıp instacne la olan bağı kaybediyouz
            methodInfo.Invoke(instance, null); // burda da hangi örneğin topla2sini çalıştırayım instanceın çalıştırayım

            var methods = tip.GetMethods();

            foreach (var info in methods)
            {
                var parameters = info.GetParameters();

                Console.WriteLine("Method adı: {0}", info.Name);
                foreach (var parameter in parameters)
                {
                    Console.WriteLine("Parametre: {0}", parameter.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2) // kullanıcıdan sayı almak için
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {

            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;
        }

        public int Topla2()
        {

            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {

            return _sayi1 * _sayi2;
        }
    }

    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}