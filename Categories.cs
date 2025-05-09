using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Categories : Form
    {
        private int editingCategoryId = -1;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            categoriesGridView.CellClick += categoriesGridView_CellClick;
            LoadCategoriesData();
            categoriesGridView.ClearSelection();
        }


        private void LoadCategoriesData()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT category_id, category_name as 'Category' FROM categories";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    categoriesGridView.DataSource = dt;
                }
            }

            AddGridActionButtons();
            ConfigureGridView();
        }

        private void AddGridActionButtons()
        {
            // Prevent duplicate buttons
            if (!categoriesGridView.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                categoriesGridView.Columns.Add(editButton);
            }

            if (!categoriesGridView.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                categoriesGridView.Columns.Add(deleteButton);
            }
        }

        private void ConfigureGridView()
        {
            categoriesGridView.ClearSelection();
            categoriesGridView.RowTemplate.Height = 30;
            categoriesGridView.EnableHeadersVisualStyles = false;


            if (categoriesGridView.Columns.Contains("category_id"))
                categoriesGridView.Columns["category_id"].Visible = false;

            // Fixed widths for buttons
            if (categoriesGridView.Columns.Contains("Edit"))
                categoriesGridView.Columns["Edit"].Width = 80;

            if (categoriesGridView.Columns.Contains("Delete"))
                categoriesGridView.Columns["Delete"].Width = 80;

            // Let the "Category" column fill the remaining space
            if (categoriesGridView.Columns.Contains("Category"))
            {
                categoriesGridView.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                categoriesGridView.Columns["Category"].MinimumWidth = 200;
            }
        }


        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNameTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DBConnection.GetConnection())
            {
                // Check for duplicates
                string checkQuery = "SELECT COUNT(*) FROM categories WHERE category_name = @name AND category_id != @id";
                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@name", categoryName);
                    checkCmd.Parameters.AddWithValue("@id", editingCategoryId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("This category already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (editingCategoryId == -1)
                {
                    // Insert
                    string insertQuery = "INSERT INTO categories (category_name) VALUES (@name)";
                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@name", categoryName);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update
                    string updateQuery = "UPDATE categories SET category_name = @name WHERE category_id = @id";
                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@name", categoryName);
                        updateCmd.Parameters.AddWithValue("@id", editingCategoryId);
                        updateCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Category updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Reset
            categoryNameTxtbox.Clear();
            editingCategoryId = -1;
            categoryLabel.Text = "Add Category";
            addCategoryBtn.Text = "Add Category";
            LoadCategoriesData();
            categoriesGridView.ClearSelection();
        }

        private void categoriesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == categoriesGridView.Columns["Edit"].Index || e.ColumnIndex == categoriesGridView.Columns["Delete"].Index))
            {
                int categoryId = Convert.ToInt32(categoriesGridView.Rows[e.RowIndex].Cells["category_id"].Value);
                string categoryName = categoriesGridView.Rows[e.RowIndex].Cells["Category"].Value.ToString();

                if (categoriesGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    // Enter edit mode
                    editingCategoryId = categoryId;
                    categoryNameTxtbox.Text = categoryName;
                    categoryLabel.Text = "Edit Category";
                    addCategoryBtn.Text = "Update Category";
                }
                else if (categoriesGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (var conn = DBConnection.GetConnection())
                        {
                            string deleteQuery = "DELETE FROM categories WHERE category_id = @id";
                            using (var deleteCmd = new MySqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", categoryId);
                                deleteCmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Category deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoriesData();
                    }
                }
            }

            categoriesGridView.ClearSelection();
        }
    }
}
