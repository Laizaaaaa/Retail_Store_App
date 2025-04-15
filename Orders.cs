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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadOrdersData();
            LoadOrderItemsData();
        }
        private void LoadOrdersData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Orders";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ordersGridView.DataSource = dt;
                }
            }
        }

        private void LoadOrderItemsData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Order_Items";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    orderItemsGridView.DataSource = dt;
                }
            }
        }

        private void ordersPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                ordersPanel.ClientRectangle,
                Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, ordersPanel.ClientRectangle);
            }
        }
    }
}
