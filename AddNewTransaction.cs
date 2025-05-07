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
    public partial class AddNewTransaction : Form
    {
        private Home homeForm;
        private AutoCompleteStringCollection productNames = new AutoCompleteStringCollection();
        private Dictionary<string, int> productIdMap = new Dictionary<string, int>();
        private Dictionary<string, decimal> productPriceMap = new Dictionary<string, decimal>();
        private int currentSaleId;

        public AddNewTransaction(Home home, int saleId)
        {
            InitializeComponent();
            this.homeForm = home;
            this.currentSaleId = saleId;
        }


        private void AddNewTransaction_Load(object sender, EventArgs e)
        {
            LoadProductSuggestions();
            productTxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productTxtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            productTxtbox.AutoCompleteCustomSource = productNames;
        }

        private void LoadProductSuggestions()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT product_id, product_name, retail_price FROM Products";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("product_name");
                        int id = reader.GetInt32("product_id");
                        decimal price = reader.GetDecimal("retail_price");

                        productNames.Add(name);
                        productIdMap[name] = id;
                        productPriceMap[name] = price;
                    }
                }
            }

            // Bind autocomplete to the textbox (if not yet bound)
            productTxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productTxtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            productTxtbox.AutoCompleteCustomSource = productNames;
        }


        private void productTxtbox_Leave(object sender, EventArgs e)
        {
            string selectedProduct = productTxtbox.Text;
            if (productPriceMap.ContainsKey(selectedProduct))
            {
                retailPriceeLabel.Text = productPriceMap[selectedProduct].ToString("F2");
                CalculateSubtotal();
            }
        }

        private void quantityTxtbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private void CalculateSubtotal()
        {
            if (decimal.TryParse(retailPriceeLabel.Text, out decimal price) &&
                int.TryParse(qtyTxtbox.Text, out int qty))
            {
                subtotalLabel.Text = (price * qty).ToString("F2");
            }
            else
            {
                subtotalLabel.Text = "0.00";
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string selectedProduct = productTxtbox.Text.Trim();
            if (!productIdMap.ContainsKey(selectedProduct)) return;

            int productId = productIdMap[selectedProduct];
            if (!int.TryParse(qtyTxtbox.Text.Trim(), out int quantity) || quantity <= 0) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string insertQuery = @"INSERT INTO sales_items (sale_id, product_id, quantity) 
                                   VALUES (@saleId, @productId, @quantity)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@saleId", currentSaleId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }

                    LoadSaleItems(); // refresh items list/gridview if any
                }

                // Clear input fields
                productTxtbox.Text = "";
                qtyTxtbox.Text = "";
                retailPriceeLabel.Text = "0.00";
                subtotalLabel.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadSaleItems()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
            SELECT 
                si.sale_item_id, 
                p.product_name, 
                si.quantity, 
                si.retail_price, 
                si.subtotal, 
                si.status
            FROM sales_items si
            JOIN Products p ON si.product_id = p.product_id
            WHERE si.sale_id = @saleId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@saleId", currentSaleId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    saleItemsGridView.DataSource = dt;
                }


                // Remove existing button columns to avoid duplication
                foreach (DataGridViewColumn col in saleItemsGridView.Columns)
                {
                    if (col is DataGridViewButtonColumn && col.HeaderText == "Delete")
                    {
                        saleItemsGridView.Columns.Remove(col);
                        break;
                    }
                }

                // Add new Delete button column
                DataGridViewButtonColumn deleteBtnCol = new DataGridViewButtonColumn();
                deleteBtnCol.HeaderText = "Delete";
                deleteBtnCol.Text = "Delete";
                deleteBtnCol.Name = "deleteButton";
                deleteBtnCol.UseColumnTextForButtonValue = true;
                saleItemsGridView.Columns.Add(deleteBtnCol);
            }
        }

        private void saleItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if click is on Delete button column
            if (e.RowIndex >= 0 && saleItemsGridView.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                int saleItemId = Convert.ToInt32(saleItemsGridView.Rows[e.RowIndex].Cells["sale_item_id"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                try
                {
                    using (var conn = DBConnection.GetConnection())
                    {
                        string deleteQuery = "DELETE FROM sales_items WHERE sale_item_id = @id";
                        using (var cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", saleItemId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadSaleItems(); // refresh grid
                    MessageBox.Show("Item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void completeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // 🟡 Step 1: Check if there are any accepted sale items
                    string checkItems = "SELECT COUNT(*) FROM sales_items WHERE sale_id = @saleId AND status = 'accepted'";
                    using (var checkCmd = new MySqlCommand(checkItems, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@saleId", currentSaleId);
                        int itemCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (itemCount == 0)
                        {
                            MessageBox.Show("Cannot complete sale with no items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // ✅ Step 2: Proceed to complete sale
                    using (var cmd = new MySqlCommand("complete_sale", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_sale_id", currentSaleId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    homeForm.OpenChildForm(new Sales(homeForm)); // go back to main view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to complete sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to cancel this transaction?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand("cancel_sale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_sale_id", currentSaleId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sale cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                homeForm.OpenChildForm(new Sales(homeForm)); // return to sales list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to cancel sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
