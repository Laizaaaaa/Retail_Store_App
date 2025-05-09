using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class AddSupplier : Form
    {
        private Home homeForm;
        private int editingSupplierId = -1;

        public AddSupplier(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        public AddSupplier(Home home, int supplierId, string supplierName, string contactNumber)
        {
            InitializeComponent();
            this.homeForm = home;
            editingSupplierId = supplierId;

            supplierNameTxtbox.Text = supplierName;
            contactNumberTxtbox.Text = contactNumber;
            supplierLabel.Text = "Edit Supplier Information";
            addSupplierBtn.Text = "Update Supplier";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Suppliers(homeForm));
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameTxtbox.Text.Trim();
            string contactNumber = contactNumberTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show("Please enter a supplier name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DBConnection.GetConnection())
            {
                if (editingSupplierId == -1)
                {
                    // Add
                    string insertQuery = "INSERT INTO suppliers (supplier_name, contact_number) VALUES (@name, @contact)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", supplierName);
                        cmd.Parameters.AddWithValue("@contact", contactNumber);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update
                    string updateQuery = "UPDATE suppliers SET supplier_name = @name, contact_number = @contact WHERE supplier_id = @id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", supplierName);
                        cmd.Parameters.AddWithValue("@contact", contactNumber);
                        cmd.Parameters.AddWithValue("@id", editingSupplierId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            homeForm.OpenChildForm(new Suppliers(homeForm));
        }
    }

}
