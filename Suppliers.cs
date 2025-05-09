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
            suppliersGridView.CellClick += suppliersGridView_CellClick;
            LoadSuppliersData();
        }

        private void LoadSuppliersData()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT supplier_id, supplier_name AS 'Supplier Name', contact_number AS 'Contact Number' FROM suppliers";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    suppliersGridView.DataSource = dt;
                }
            }

            AddGridActionButtons();
            ConfigureGridView();
        }

        private void AddGridActionButtons()
        {
            if (!suppliersGridView.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                suppliersGridView.Columns.Add(editButton);
            }

            if (!suppliersGridView.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                suppliersGridView.Columns.Add(deleteButton);
            }
        }

        private void ConfigureGridView()
        {
            suppliersGridView.RowHeadersVisible = false;
            suppliersGridView.AllowUserToResizeColumns = false;
            suppliersGridView.AllowUserToResizeRows = false;
            suppliersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (suppliersGridView.Columns.Contains("Supplier Name"))
                suppliersGridView.Columns["Supplier Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (suppliersGridView.Columns.Contains("Contact Number"))
                suppliersGridView.Columns["Contact Number"].Width = 150;
        }

        private void suppliersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(suppliersGridView.Rows[e.RowIndex].Cells["supplier_id"].Value);
                string supplierName = suppliersGridView.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString();
                string contactNumber = suppliersGridView.Rows[e.RowIndex].Cells["Contact Number"].Value.ToString();

                if (suppliersGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var editForm = new AddSupplier(homeForm, supplierId, supplierName, contactNumber);
                    homeForm.OpenChildForm(editForm);
                }
                else if (suppliersGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        using (var conn = DBConnection.GetConnection())
                        {
                            string deleteQuery = "DELETE FROM suppliers WHERE supplier_id = @id";
                            using (var cmd = new MySqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", supplierId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Supplier deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliersData();
                    }
                }
            }
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new AddSupplier(homeForm));
        }
    }
}
