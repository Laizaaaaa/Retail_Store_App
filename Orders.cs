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

        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new AddOrder(homeForm));
        }
    }
}
