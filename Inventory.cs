using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Inventory : Form
    {
        private Home homeForm;
        private bool actionButtonsAdded = false;

        public Inventory(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCategoryFilter();
            ConfigureProductGridView();  // set grid style only once
            LoadProducts();
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
                        p.product_name AS 'Product',
                        p.net_weight AS 'Net Weight',
                        p.unit_price AS 'Unit Price',
                        p.retail_price AS 'Retail Price',
                        p.unit AS 'Unit',
                        p.stock AS 'Stock'
                    FROM products p
                    LEFT JOIN categories c ON p.category_id = c.category_id";

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

            HideUnwantedColumns();

            if (!actionButtonsAdded)
            {
                AddActionButtons();
                actionButtonsAdded = true;
            }
        }

        private void ConfigureProductGridView()
        {
            productsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsGridView.RowHeadersVisible = false;
            productsGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            productsGridView.Columns.Clear(); // Ensures fresh start on reload
        }

        private void HideUnwantedColumns()
        {
            if (productsGridView.Columns.Contains("product_id"))
            {
                productsGridView.Columns["product_id"].Visible = false;
            }
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
                    Width = 80, // Wider button
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
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
                    Width = 80, // Wider button
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                };
                productsGridView.Columns.Add(deleteBtn);
            }

            // Optional: set row height to ensure full visibility
            productsGridView.RowTemplate.Height = 35;

            // Align buttons
            DataGridViewCellStyle buttonStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(2)
            };

            productsGridView.Columns["Edit"].DefaultCellStyle = buttonStyle;
            productsGridView.Columns["Delete"].DefaultCellStyle = buttonStyle;

            productsGridView.CellClick -= ProductsGridView_CellClick;
            productsGridView.CellClick += ProductsGridView_CellClick;
        }


        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (!productsGridView.Columns.Contains("product_id"))
                return;

            var row = productsGridView.Rows[e.RowIndex];
            var columnName = productsGridView.Columns[e.ColumnIndex].Name;

            if (row.Cells["product_id"].Value == DBNull.Value)
                return;

            int productId = Convert.ToInt32(row.Cells["product_id"].Value);

            if (columnName == "Edit")
            {
                homeForm.OpenChildForm(new AddProduct(homeForm, productId));
            }
            else if (columnName == "Delete")
            {
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
