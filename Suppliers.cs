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
        private Home homeForm;

        public Suppliers(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
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

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new AddSupplier(homeForm));
        }
    }
}
