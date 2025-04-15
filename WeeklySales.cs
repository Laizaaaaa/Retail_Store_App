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
    public partial class WeeklySales : Form
    {
        public WeeklySales()
        {
            InitializeComponent();
        }

        private void WeeklySales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadWeeklySalesData();
        }
        private void LoadWeeklySalesData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Weekly_Sales_Report";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    weeklySalesGridView.DataSource = dt;
                }
            }
        }
    }
}
