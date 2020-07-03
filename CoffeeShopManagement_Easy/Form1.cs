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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
            Product product = new Product();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            using(aboutForm about = new aboutForm())
            {
                about.ShowDialog();
            }
        }
    }
}
