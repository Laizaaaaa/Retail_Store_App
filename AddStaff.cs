using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace EDP
{
    public partial class AddStaff : Form
    {
        private Home homeForm;

        public AddStaff(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtbox.Text.Trim();
            string contactNumber = contactNumberTxtbox.Text.Trim();
            string email = emailTxtbox.Text.Trim();
            string password = passwordTxtbox.Text.Trim();
            string confirmPassword = confirmPasswordTxtbox.Text.Trim();
            string role = roleTxtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                role = "staff"; // default role
            }

            string hashedPassword = HashPassword(password);

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "INSERT INTO users (name, contact_number, email, password, role) VALUES (@name, @contact, @email, @password, @role)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contactNumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", role);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Staff added successfully.");
                            this.Close();

                            homeForm.OpenChildForm(new Staff(homeForm));
                        }
                        else
                        {
                            MessageBox.Show("Failed to add staff.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Staff(homeForm));
        }
    }
}
