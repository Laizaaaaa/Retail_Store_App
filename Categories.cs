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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCategoriesData();
        }
        private void LoadCategoriesData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Categories";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    categoriesGridView.DataSource = dt;
                }
            }
        }

        private void categoriesPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                categoriesPanel.ClientRectangle,
                Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, categoriesPanel.ClientRectangle);
            }
        }
    }
}
