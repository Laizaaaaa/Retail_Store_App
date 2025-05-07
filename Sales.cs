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
        private Home homeForm;

        public Sales(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
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

        private void newTransactionBtn_Click(object sender, EventArgs e)
        {
            int newSaleId = -1;

            using (var conn = DBConnection.GetConnection())
            {
                string insertQuery = @"INSERT INTO Sales (sale_date, total_amount, total_items)
                               VALUES (NOW(), 0, 0); SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(insertQuery, conn))
                {
                    newSaleId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            if (newSaleId > 0)
            {
                homeForm.OpenChildForm(new AddNewTransaction(homeForm, newSaleId));
            }
            else
            {
                MessageBox.Show("Failed to create a new sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
