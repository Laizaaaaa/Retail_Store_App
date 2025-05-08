using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Inventory : Form
    {
        private Home homeForm;

        public Inventory(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
            this.Load += Inventory_Load;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadProducts();
            productsGridView.CellClick += productsGridView_CellClick;
        }

        private void LoadProducts()
        {
            using (MySqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                productsGridView.DataSource = dt;
            }

            AddActionButtons();
        }

        private void AddActionButtons()
        {
            if (!productsGridView.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "Edit";
                editBtn.HeaderText = "";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                productsGridView.Columns.Add(editBtn);
            }

            if (!productsGridView.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Delete";
                deleteBtn.HeaderText = "";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                productsGridView.Columns.Add(deleteBtn);
            }
        }

        private void productsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks or invalid indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= productsGridView.Rows.Count)
                return;

            DataGridView dgv = (DataGridView)sender;

            // Prevent errors if column is not found
            if (e.ColumnIndex >= dgv.Columns.Count)
                return;

            if (!dgv.Columns.Contains("product_id"))
                return;

            var row = dgv.Rows[e.RowIndex];

            // Ensure the product_id cell exists and has a value
            if (!row.Cells.Contains(row.Cells["product_id"]) || row.Cells["product_id"].Value == null)
                return;

            // Convert to int directly without declaring again
            int productId = Convert.ToInt32(row.Cells["product_id"].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "Edit")
            {
                homeForm.OpenChildForm(new AddProduct(homeForm, productId));
            }


            else if (dgv.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection con = DBConnection.GetConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE product_id = @id", con);
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Product deleted.");
                    LoadProducts();
                }
            }
        }


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new AddProduct(homeForm));
        }
    }
}
