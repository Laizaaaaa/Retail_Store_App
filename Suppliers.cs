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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadSuppliersData();
        }
        private void LoadSuppliersData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Suppliers";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    suppliersGridView.DataSource = dt;
                }
            }
        }

        private void suppliersPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                suppliersPanel.ClientRectangle,
                Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, suppliersPanel.ClientRectangle);
            }
        }
    }
}
