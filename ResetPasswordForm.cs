using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class ResetPasswordForm : Form
    {
        private string email;
        private EnterCodeForm enterCodeForm;

        public ResetPasswordForm(string userEmail, EnterCodeForm previousForm)
        {
            InitializeComponent();
            email = userEmail;
            enterCodeForm = previousForm;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTxtbox.Text;
            string confirmPassword = confirmPasswordTxtbox.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill out all password fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = HashPassword(newPassword);

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "UPDATE users SET password = @password WHERE email = @userEmail";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@userEmail", email);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password successfully reset.");
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            enterCodeForm.Show();
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
