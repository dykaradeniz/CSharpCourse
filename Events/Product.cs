using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        private string _name;
        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        
      
        public int Stock 
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock=value;
                if (value<=15 && StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }

        public string ProductName { get => _name; set => _name = value; }

        public void Sell(int amount)
        {
            Stock -= amount;
            
            Console.WriteLine("{1} Stock amount: {0}",_stock,_name);
        }
        
    }
}