using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class AddOrder : Form
    {
        private Home homeForm;
        private int supplierId;
        private string supplierName;
        private int orderId; 
        private int productId = 0;
        private decimal unitPrice = 0;

        public AddOrder(Home home, int supplierId, int orderId)
        {
            InitializeComponent();
            this.homeForm = home;
            this.supplierId = supplierId;
            this.orderId = orderId;
        }   

        private void AddOrder_Load(object sender, EventArgs e)
        {
            using (var conn = DBConnection.GetConnection())
            {
                // Get supplier name
                string supplierQuery = "SELECT supplier_name FROM suppliers WHERE supplier_id = @id";
                using (var cmd = new MySqlCommand(supplierQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        supplierName = result.ToString();
                        supplierLabel.Text = $"Supplier: {supplierName}";
                    }
                }
            }

            LoadProductSuggestions();
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT 
                            oi.order_item_id, 
                            p.product_name, 
                            oi.quantity, 
                            oi.unit_price, 
                            oi.subtotal 
                         FROM order_items oi
                         JOIN products p ON oi.product_id = p.product_id
                         WHERE oi.order_id = @orderId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        orderItemsGridView.DataSource = dt;
                    }
                }
            }

            // Optional: Adjust column headers
            if (orderItemsGridView.Columns.Count > 0)
            {
                orderItemsGridView.Columns["order_item_id"].Visible = false;
                orderItemsGridView.Columns["product_name"].HeaderText = "Product";
                orderItemsGridView.Columns["quantity"].HeaderText = "Qty";
                orderItemsGridView.Columns["unit_price"].HeaderText = "Unit Price";
                orderItemsGridView.Columns["subtotal"].HeaderText = "Subtotal";
            }
        }

        private void LoadProductSuggestions()
        {
            var autoSource = new AutoCompleteStringCollection();

            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT product_name FROM products WHERE supplier_id = @supplierId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autoSource.Add(reader.GetString("product_name"));
                        }
                    }
                }
            }

            productTxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productTxtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            productTxtbox.AutoCompleteCustomSource = autoSource;
        }

        private void productTxtbox_Leave(object sender, EventArgs e)
        {
            string productName = productTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(productName)) return;

            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT unit_price FROM products WHERE product_name = @name AND supplier_id = @supplierId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        unitPrice = Convert.ToDecimal(result);
                        unitPriceAmount.Text = $"₱{unitPrice:N2}";
                        UpdateSubtotal();
                    }
                    else
                    {
                        unitPrice = 0;
                        unitPriceAmount.Text = "₱0.00";
                        subtotalAmount.Text = "₱0.00";
                    }
                }
            }
        }


        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void UpdateSubtotal()
        {
            if (int.TryParse(qtyTxtbox.Text.Trim(), out int quantity) && quantity > 0)
            {
                decimal subtotal = unitPrice * quantity;
                subtotalAmount.Text = $"₱{subtotal:N2}";
            }
            else
            {
                subtotalAmount.Text = "₱0.00";
            }
        }




        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string productName = productTxtbox.Text.Trim();
            string qtyText = qtyTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(qtyText))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(qtyText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId;
            decimal unitPrice;

            using (var conn = DBConnection.GetConnection())
            {
                // Get product_id and unit_price
                string getProductQuery = "SELECT product_id, unit_price FROM products WHERE product_name = @productName AND supplier_id = @supplierId";
                using (var getProductCmd = new MySqlCommand(getProductQuery, conn))
                {
                    getProductCmd.Parameters.AddWithValue("@productName", productName);
                    getProductCmd.Parameters.AddWithValue("@supplierId", supplierId);
                    using (var reader = getProductCmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Product not found for this supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        productId = reader.GetInt32("product_id");
                        unitPrice = reader.GetDecimal("unit_price");
                    }
                }

                // Insert into order_items
                string insertQuery = @"INSERT INTO order_items (order_id, product_id, quantity, unit_price, subtotal)
                               VALUES (@orderId, @productId, @qty, @unitPrice, @subtotal)";
                using (var cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@subtotal", unitPrice * quantity);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        productTxtbox.Clear();
                        qtyTxtbox.Clear();
                        productTxtbox.Focus();
                        LoadOrderItems(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding item: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            using (var conn = DBConnection.GetConnection())
            {
                using (var cmd = new MySqlCommand("cancel_order", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_order_id", orderId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        homeForm.OpenChildForm(new Orders(homeForm));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error cancelling order: " + ex.Message);
                    }
                }
            }
        }

        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
            using (var conn = DBConnection.GetConnection())
            {
                using (var cmd = new MySqlCommand("send_order", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_order_id", orderId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order marked as sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        homeForm.OpenChildForm(new Orders(homeForm));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending order: " + ex.Message);
                    }
                }
            }
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been finalized.", "Order Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            homeForm.OpenChildForm(new Orders(homeForm));
        }

        private void addProductForm_Paint(object sender, PaintEventArgs e)
        {
            // Unused
        }
    }
}
