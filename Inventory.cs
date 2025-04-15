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
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    inventoryPanel.ClientRectangle,
                    Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                    Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, inventoryPanel.ClientRectangle);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
