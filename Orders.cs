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
        private Home homeForm;

        public Orders(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadOrdersData();
            LoadOrderItemsData();
            LoadSuppliersToComboBox();
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

        private void LoadSuppliersToComboBox()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT supplier_id, supplier_name FROM suppliers";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    supplierComboBox.DataSource = dt;
                    supplierComboBox.DisplayMember = "supplier_name";
                    supplierComboBox.ValueMember = "supplier_id";
                    supplierComboBox.SelectedIndex = -1; // No selection initially
                }
            }
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            if (supplierComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier before adding a new order.", "Missing Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedSupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);

            using (var conn = DBConnection.GetConnection())
            {
                string insertQuery = @"INSERT INTO orders (supplier_id)
                               VALUES (@selectedSupplierId); SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedSupplierId", selectedSupplierId);
                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    homeForm.OpenChildForm(new AddOrder(homeForm, selectedSupplierId, orderId));
                }
            }

            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Failed to create a new order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
