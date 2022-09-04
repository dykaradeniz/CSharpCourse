using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo // en temel unsur tabloya karşılık gelen bi nesne
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; } //parasal olduğu için decimal yaptık
        public int StockAmount { get; set; }
    }
}