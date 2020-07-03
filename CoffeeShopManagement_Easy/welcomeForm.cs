using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement_Easy
{
    public partial class welcomeForm : Form
    {
        SqlConnection sqlConnection;
        public static List<String> productListString = new List<string>();

        internal static List<Product> ProductList { get; set; } = new List<Product>();

        public welcomeForm()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            using(aboutForm about = new aboutForm())
            {
                about.ShowDialog();
            }
        }

        private async void welcomeForm_Load(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zaido\source\repos\CoffeeShopManagement_Easy\CoffeeShopManagement_Easy\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Products]", sqlConnection);

            try
            {
                sqlDataReader = await command.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    String result =
                        Convert.ToString(sqlDataReader["ID"]) +         "|" +
                        Convert.ToString(sqlDataReader["Type"]) +       "|" +
                        Convert.ToString(sqlDataReader["Name"]) +       "|" +
                        Convert.ToString(sqlDataReader["Price"]) +      "|" +
                        Convert.ToString(sqlDataReader["ImagePath"]);

                    Product prod = new Product(
                        Convert.ToString(sqlDataReader["Type"]),
                        Convert.ToString(sqlDataReader["Name"]),
                        Convert.ToDouble(sqlDataReader["Price"]),
                        Convert.ToString(sqlDataReader["ImagePath"])
                        );

                    ProductList.Add(prod);
                    productListString.Add(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
            }
        }

        private void welcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sqlConnection != null && sqlConnection.State  != ConnectionState.Closed)
                sqlConnection.Close();
        }

    }
}
