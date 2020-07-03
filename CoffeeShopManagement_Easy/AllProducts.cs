using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement_Easy
{
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            //foreach(String item in welcomeForm.productListString)
            //{
            //    listBox1.Items.Add(item);
            //}

            foreach(Product product in welcomeForm.ProductList)
            {
                listBox1.Items.Add(product.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
