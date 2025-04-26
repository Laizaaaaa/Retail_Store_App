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
    public partial class DailySales : Form
    {
        public DailySales()
        {
            InitializeComponent();
        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDailySalesData();
        }
        private void LoadDailySalesData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Daily_Sales_Report";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dailySalesGridView.DataSource = dt;
                }
            }
        }

        private void dailySalesPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            //    dailySalesPanel.ClientRectangle,
            //    Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
            //    Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
            //    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            //{
            //    e.Graphics.FillRectangle(brush, dailySalesPanel.ClientRectangle);
            //}
        }
    }
}
