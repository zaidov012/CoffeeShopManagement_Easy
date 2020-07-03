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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginLabel.Visible)
            {
                loginLabel.Visible = false;
                loginTextBox.Visible = false;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
                openAdminButton.Visible = false;
            }
            else
            {
                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                openAdminButton.Visible = true;
            }
        }

        private void openAdminButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;

            loginTextBox.Text = "";
            passwordTextBox.Text = "";

            if (login.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("Nice to meet you again, admin!");
                using (adminForm admin = new adminForm())
                {
                    admin.ShowDialog();
                }
            }
            else
                MessageBox.Show("Access denied!");
        }
    }
}
