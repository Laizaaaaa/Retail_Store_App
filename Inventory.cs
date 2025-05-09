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
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCategoryFilter();
            LoadProducts();
            AddActionButtons();
        }

        private void LoadCategoryFilter()
        {
            categoryFilterComboBox.Items.Clear();
            categoryFilterComboBox.Items.Add("All");
            categoryFilterComboBox.Items.Add("Others");

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT category_name FROM categories WHERE category_name IS NOT NULL";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryFilterComboBox.Items.Add(reader.GetString("category_name"));
                    }
                }
            }

            categoryFilterComboBox.SelectedIndex = 0;
            categoryFilterComboBox.SelectedIndexChanged += CategoryFilterComboBox_SelectedIndexChanged;
        }

        private void CategoryFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            string selectedCategory = categoryFilterComboBox.SelectedItem.ToString();
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
        SELECT 
            p.product_id,
            p.product_name as 'Product',
            p.net_weight as 'Net Weight',
            p.unit_price as 'Unit Price',
            p.retail_price as 'Retail Price',
            c.category_name,
            p.unit as 'Unit',
            p.stock as 'Stock',
            s.supplier_name
        FROM products p
        LEFT JOIN categories c ON p.category_id = c.category_id
        LEFT JOIN suppliers s ON p.supplier_id = s.supplier_id";

                if (selectedCategory != "All")
                {
                    if (selectedCategory == "Others")
                        query += " WHERE c.category_name IS NULL";
                    else
                        query += " WHERE c.category_name = @categoryName";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (selectedCategory != "All" && selectedCategory != "Others")
                        cmd.Parameters.AddWithValue("@categoryName", selectedCategory);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        productsGridView.DataSource = dt;
                    }
                }
            }

            ConfigureProductGridView();
            HideUnwantedColumns();
            AddActionButtons();
        }


        private void ConfigureProductGridView()
        {
            productsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            productsGridView.RowHeadersVisible = false;
            productsGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (productsGridView.Columns.Contains("Product"))
            {
                // Adjust Product column
                var productCol = productsGridView.Columns["Product"];
                productCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                productCol.MinimumWidth = 150;
                productCol.FillWeight = 350;
                productCol.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Optional: Limit width on resize
                productsGridView.Resize += (s, e) =>
                {
                    if (productCol.Width > 300)
                        productCol.Width = 300;
                };
            }

            string[] autoColumns = { "unit_price", "retail_price", "stock", "unit" };
            foreach (var col in autoColumns)
            {
                if (productsGridView.Columns.Contains(col))
                    productsGridView.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void HideUnwantedColumns()
        {
            productsGridView.Columns["product_id"].Width = 0;
            productsGridView.Columns["product_id"].Visible = false; 

            if (productsGridView.Columns.Contains("category_id"))
                productsGridView.Columns["category_id"].Visible = false;

            if (productsGridView.Columns.Contains("supplier_id"))
                productsGridView.Columns["supplier_id"].Visible = false;

            if (productsGridView.Columns.Contains("category_name"))
                productsGridView.Columns["category_name"].Visible = false;

            if (productsGridView.Columns.Contains("supplier_name"))
                productsGridView.Columns["supplier_name"].Visible = false;
        }


        private void AddActionButtons()
        {
            if (!productsGridView.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Width = 60,
                    FlatStyle = FlatStyle.Standard
                };
                productsGridView.Columns.Add(editBtn);
            }

            if (!productsGridView.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 60,
                    FlatStyle = FlatStyle.Standard
                };
                productsGridView.Columns.Add(deleteBtn);
            }

            // Set default style to prevent button from stretching
            foreach (DataGridViewRow row in productsGridView.Rows)
            {
                row.Height = 20; 
            }

            productsGridView.RowTemplate.Height = 20;

            DataGridViewCellStyle buttonStyle = new DataGridViewCellStyle
            {
                Padding = new Padding(0, 10, 0, 10),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            productsGridView.Columns["Edit"].DefaultCellStyle = buttonStyle;
            productsGridView.Columns["Delete"].DefaultCellStyle = buttonStyle;

            productsGridView.CellClick -= ProductsGridView_CellClick; // remove if already attached
            productsGridView.CellClick += ProductsGridView_CellClick; // attach fresh

        }


        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (!productsGridView.Columns.Contains("product_id"))
                return;

            var cellValue = productsGridView.Rows[e.RowIndex].Cells["product_id"]?.Value;
            if (cellValue == null || cellValue == DBNull.Value)
                return;


            var dgv = (DataGridView)sender;

            // Ensure the DataGridView has rows and columns before accessing them
            if (dgv.Rows.Count == 0 || dgv.Columns.Count == 0) return;

            // Extra safety: don't allow clicks on shared/new rows
            if (dgv.Rows[e.RowIndex].IsNewRow || dgv.Rows[e.RowIndex].Cells["product_id"].Value == DBNull.Value)
                return;

            var row = dgv.Rows[e.RowIndex];
            var columnName = dgv.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                homeForm.OpenChildForm(new AddProduct(homeForm, productId));
            }
            else if (columnName == "Delete")
            {
                int productId = Convert.ToInt32(row.Cells["product_id"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (MySqlConnection conn = DBConnection.GetConnection())
                    {
                        string deleteQuery = "DELETE FROM products WHERE product_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

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
