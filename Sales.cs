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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadSalesData();
            LoadSaleItemsData();
        }
        private void LoadSalesData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Sales";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    salesGridView.DataSource = dt;
                }
            }
        }

        private void LoadSaleItemsData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Sales_Items";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    saleItemsGridView.DataSource = dt;
                }
            }
        }
    }
}
