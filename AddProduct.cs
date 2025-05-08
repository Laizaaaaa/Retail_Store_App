using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class AddProduct : Form
    {
        private Home homeForm;
        private int? editingProductId = null;

        public AddProduct(Home home, int? productId = null)
        {
            InitializeComponent();
            this.homeForm = home;
            this.editingProductId = productId;

            LoadCategoryOptions();
            LoadSupplierOptions();
            LoadUnitOptions();

            if (productId.HasValue)
            {
                LoadProductData(productId.Value);
                formTitleLabel.Text = "Edit Product Information";
                addProductBtn.Text = "Update Product";
            }
            else
            {
                formTitleLabel.Text = "Add Product";
                addProductBtn.Text = "Add Product";
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

                decimal markupAmount = unitPrice * markupPercent / 100;
                decimal retailPrice = (markupAmount % 1 >= 0.5m)
                    ? Math.Ceiling(unitPrice + markupAmount)
                    : Math.Floor(unitPrice + markupAmount);

                string categoryName = categoryComboBox.Text.Trim();
                string supplierName = supplierComboBox.Text.Trim();
                string unit = unitComboBox.Text.Trim();
                int stock = int.Parse(stockTxtbox.Text.Trim());

                object categoryId = DBNull.Value;
                object supplierId = DBNull.Value;

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    if (!string.IsNullOrEmpty(categoryName))
                    {
                        using (var cmd = new MySqlCommand("SELECT category_id FROM categories WHERE category_name = @name", conn))
                        {
                            cmd.Parameters.AddWithValue("@name", categoryName);
                            var result = cmd.ExecuteScalar();
                            if (result != null) categoryId = result;
                        }
                    }

                    if (!string.IsNullOrEmpty(supplierName))
                    {
                        using (var cmd = new MySqlCommand("SELECT supplier_id FROM suppliers WHERE supplier_name = @name", conn))
                        {
                            cmd.Parameters.AddWithValue("@name", supplierName);
                            var result = cmd.ExecuteScalar();
                            if (result != null) supplierId = result;
                        }
                    }

                    string query;
                    if (editingProductId.HasValue)
                    {
                        query = @"UPDATE products SET 
                                  product_name = @productName,
                                  net_weight = @netWeight,
                                  unit_price = @unitPrice,
                                  retail_price = @retailPrice,
                                  category_id = @categoryId,
                                  stock = @stock,
                                  supplier_id = @supplierId,
                                  unit = @unit
                                  WHERE product_id = @productId";
                    }
                    else
                    {
                        query = @"INSERT INTO products 
                                  (product_name, net_weight, unit_price, retail_price, category_id, stock, supplier_id, unit) 
                                  VALUES 
                                  (@productName, @netWeight, @unitPrice, @retailPrice, @categoryId, @stock, @supplierId, @unit)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productName", productName);
                        cmd.Parameters.AddWithValue("@netWeight", netWeight);
                        cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@retailPrice", retailPrice);
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@supplierId", supplierId);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        if (editingProductId.HasValue)
                            cmd.Parameters.AddWithValue("@productId", editingProductId.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(editingProductId.HasValue ? "Product updated successfully!" : "Product added successfully!");
                    }
                }

                homeForm.OpenChildForm(new Inventory(homeForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadProductData(int productId)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM products WHERE product_id = @productId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            productNameTxtbox.Text = reader["product_name"].ToString();
                            netWeightTxtbox.Text = reader["net_weight"].ToString();
                            unitPriceTxtbox.Text = reader["unit_price"].ToString();
                            stockTxtbox.Text = reader["stock"].ToString();
                            unitComboBox.Text = reader["unit"].ToString();

                            if (reader["category_id"] != DBNull.Value)
                                categoryComboBox.Text = GetCategoryNameById(Convert.ToInt32(reader["category_id"]));

                            if (reader["supplier_id"] != DBNull.Value)
                                supplierComboBox.Text = GetSupplierNameById(Convert.ToInt32(reader["supplier_id"]));
                        }
                    }
                }
            }
        }

        private string GetCategoryNameById(int categoryId)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new MySqlCommand("SELECT category_name FROM categories WHERE category_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", categoryId);
                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "";
            }
        }

        private string GetSupplierNameById(int supplierId)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new MySqlCommand("SELECT supplier_name FROM suppliers WHERE supplier_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", supplierId);
                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "";
            }
        }

        private void LoadCategoryOptions()
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add("");

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT category_name FROM categories WHERE category_name IS NOT NULL";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        categoryComboBox.Items.Add(reader.GetString("category_name"));
            }
        }

        private void LoadSupplierOptions()
        {
            supplierComboBox.Items.Clear();
            supplierComboBox.Items.Add("");

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT supplier_name FROM suppliers WHERE supplier_name IS NOT NULL";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        supplierComboBox.Items.Add(reader.GetString("supplier_name"));
            }
        }

        private void LoadUnitOptions()
        {
            unitComboBox.Items.Clear();
            unitComboBox.Items.AddRange(new string[] { "Piece", "Pack" });
            unitComboBox.SelectedIndex = 0;
        }

        private void addProductForm_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush semiTransparentBrush = new SolidBrush(Color.FromArgb(120, Color.Black)))
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);
            }
        }
    }
}
