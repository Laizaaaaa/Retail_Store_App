using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class AddProduct : Form
    {
        private Home homeForm;

        public AddProduct(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
            LoadCategoryOptions();
            LoadSupplierOptions();
            LoadUnitOptions();
        }

        private void addProductForm_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush semiTransparentBrush = new SolidBrush(Color.FromArgb(120, Color.Black)))
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Inventory(homeForm));
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = productNameTxtbox.Text.Trim();
                string netWeight = netWeightTxtbox.Text.Trim();
                decimal unitPrice = decimal.Parse(unitPriceTxtbox.Text.Trim());
                decimal markupPercent = decimal.Parse(markupPercentTxtbox.Text.Trim());
                decimal retailPrice = Math.Ceiling(unitPrice + (unitPrice * markupPercent / 100));
                string categoryName = categoryComboBox.Text.Trim();
                string supplierName = supplierComboBox.Text.Trim();
                string unit = unitComboBox.Text.Trim();
                object categoryId = DBNull.Value;
                object supplierId = DBNull.Value;
                int stock = int.Parse(stockTxtbox.Text.Trim());

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    // Get category_id
                    if (!string.IsNullOrEmpty(categoryName))
                    {
                        using (var cmd = new MySqlCommand("SELECT category_id FROM categories WHERE category_name = @name", conn))
                        {
                            cmd.Parameters.AddWithValue("@name", categoryName);
                            var result = cmd.ExecuteScalar();
                            if (result != null) categoryId = result;
                        }
                    }

                    // Get supplier_id
                    if (!string.IsNullOrEmpty(supplierName))
                    {
                        using (var cmd = new MySqlCommand("SELECT supplier_id FROM suppliers WHERE supplier_name = @name", conn))
                        {
                            cmd.Parameters.AddWithValue("@name", supplierName);
                            var result = cmd.ExecuteScalar();
                            if (result != null) supplierId = result;
                        }
                    }

                    // Now insert using the correct foreign key fields
                    string query = @"INSERT INTO products 
                    (product_name, net_weight, unit_price, retail_price, category_id, stock, supplier_id, unit) 
                    VALUES 
                    (@productName, @netWeight, @unitPrice, @retailPrice, @categoryId, @stock, @supplierId, @unit)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productName", productName);
                        cmd.Parameters.AddWithValue("@netWeight", netWeight);
                        cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@retailPrice", retailPrice);
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!");
                    }
                }

                homeForm.OpenChildForm(new Inventory(homeForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadCategoryOptions()
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add(""); // blank option

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
            SELECT DISTINCT c.category_name 
            FROM products p
            JOIN categories c ON p.category_id = c.category_id
            WHERE c.category_name IS NOT NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryComboBox.Items.Add(reader.GetString("category_name"));
                    }
                }
            }
        }


        private void LoadSupplierOptions()
        {
            supplierComboBox.Items.Clear();
            supplierComboBox.Items.Add(""); // blank option

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
            SELECT DISTINCT s.supplier_name 
            FROM products p
            JOIN suppliers s ON p.supplier_id = s.supplier_id
            WHERE s.supplier_name IS NOT NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        supplierComboBox.Items.Add(reader.GetString("supplier_name"));
                    }
                }
            }
        }
        private void LoadUnitOptions()
        {
            unitComboBox.Items.Clear();
            unitComboBox.Items.AddRange(new string[] { "Piece", "Pack" });
            unitComboBox.SelectedIndex = 0; // default selection
        }
    }
}
