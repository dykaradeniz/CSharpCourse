using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {   // method bittiğinde bir süre sonra bellekten atıyor normalde ama using kullandığıımzda kendisi hemen siliyor
            using (ETradeContext context = new ETradeContext()) // e trade context bellekte çok yer kaplıyor
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {  
                //    List<Product> model = new List<Product>();
                //foreach (var item in context.Products)
                //{
                //    if (item.Name.Contains(key))
                //    {
                //        model.Add(item);
                //    }
                //}
                //return model;

                //burda direkt veritabanından alıyoruz
                return context.Products.Where(x => x.Name.Contains(key)).ToList(); 
            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList(); // fiyata göre filtreliyor
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList(); // fiyata göre filtreliyor
            }
        }
        public List<Product> GetById(int id) // liste değil de tek bir ürün getir
        {
            using (ETradeContext context = new ETradeContext())
            {
                // bir de SingleOrDefault var o da aynısını yapıyo ama kayda uyan birden fazla data bulursa hata veriyor
                return context.Products.Where(p => p.Id==id).ToList(); // bu idye uygun olan ilk kaydı getir bulamazsan null getir
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) // e trade context bellekte çok yer kaplıyor
            {
                context.Products.Add(product);
                //var entity = context.Entry(product); // bizim gönderdiğimiz productı veri tabanındaki productla eşleştiriyo
                //entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            ETradeContext context = new ETradeContext();

            var entity = context.Entry(product); // bizim gönderdiğimiz productı veri tabanındaki productla eşleştiriyo
            entity.State = EntityState.Modified; // durumunu güncellendi işaretliyor
            context.SaveChanges();
            context.Dispose();

        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted; // durumunu silindi işaretliyor
                context.SaveChanges();
            }
        }

    }
}