using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class EditStaffForm : Form
    {
        private int staffId;
        private Home homeForm;

        public EditStaffForm(Home home, int id)
        {
            InitializeComponent();
            this.homeForm = home;
            this.staffId = id;
        }

        private void EditStaffForm_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT name, contact_number, email, role FROM users WHERE user_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", staffId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nameTxtbox.Text = reader.GetString("name");
                                contactNumberTxtbox.Text = reader.GetString("contact_number");
                                emailTxtbox.Text = reader.GetString("email");
                                roleTxtbox.Text = reader.GetString("role");
                            }
                            else
                            {
                                MessageBox.Show("Staff not found.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtbox.Text.Trim();
            string contact = contactNumberTxtbox.Text.Trim();
            string email = emailTxtbox.Text.Trim();
            string role = roleTxtbox.Text.Trim();
            string password = passwordTxtbox.Text.Trim();
            string confirmPassword = confirmPasswordTxtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password do not match.");
                    return;
                }
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query;
                    MySqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(password))
                    {
                        // Update without password
                        query = "UPDATE users SET name = @name, contact_number = @contact, email = @email, role = @role WHERE user_id = @id";
                        cmd = new MySqlCommand(query, conn);
                    }
                    else
                    {
                        // Update with hashed password
                        string hashedPassword = HashPassword(password);
                        query = "UPDATE users SET name = @name, contact_number = @contact, email = @email, role = @role, password = @password WHERE user_id = @id";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                    }

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", staffId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Staff updated successfully.");
                        this.Close();
                        homeForm.OpenChildForm(new Staff(homeForm));
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }



        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Staff(homeForm));
        }
    }
}
