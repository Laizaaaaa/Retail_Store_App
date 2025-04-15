using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void showProductsTable(object sender, EventArgs e)
        {
            string conString = "server=localhost; uid=root; pwd=laiza07; database=retail_store;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from products";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            productsGridView.DataSource = dt;
        }

        private void inventoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
