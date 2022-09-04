using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext:DbContext // Entity framework contexti olabilmesi için bu kütüphaneden inherit etmek gerekiyor
    {
        public DbSet<Product> Products { get; set; } // tablolarda products diye bir şey arıyo
    }
}