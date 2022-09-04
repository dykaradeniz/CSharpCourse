using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Product
    {
        private decimal unitPrice;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; } //parasal olduğu için decimal yaptık
        public int StockAmount { get; set; }
    }
}