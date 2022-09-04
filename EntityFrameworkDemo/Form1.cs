using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void ReLoad()
        {
            dgwProducts.DataSource = _productDal.GetById(1);
        }

        private void SearchProducts(int id)
        {                                                       // küçük büyük harf duyarlılığını kaldırmak için hepsini küçük yaptık
            // var result = _productDal.GetAll().Where(x=>x.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = _productDal.GetById(id); // bu sorgu veri tabanından getirir
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name= tbxName.Text, // name kutusuna yazdığımız texti alıyoruz
                UnitPrice= Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount= Convert.ToInt32(tbxStockAmount.Text),
            });
            ReLoad();
            MessageBox.Show("Product Added!");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text, // değiştirdiğindeki değer
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
            });
            ReLoad();
            MessageBox.Show("Product Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();  // tıkladığın yerdeki her değeri text boxlara atıuor sonra biz değiştirip update yapıyoruz
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value), // hangisi olduğunu anlamak için Id yi gönderiyoruz
            });

            ReLoad();
            MessageBox.Show("Product Deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            SearchProducts(Convert.ToInt32(tbxSearch.Text));
        }
    }
}