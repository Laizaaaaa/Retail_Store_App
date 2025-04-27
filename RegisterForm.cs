using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            login.FormClosed += (s, args) => this.Close();

            login.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hex string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // "x2" = hexadecimal
                }
                return builder.ToString();
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtbox.Text;
            string contactNumber = contactNumberTxtbox.Text;
            string password = passwordTxtbox.Text;
            string confirmPassword = confirmPasswordTxtbox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password == confirmPassword)
            {
                try
                {
                    using (var conn = DBConnection.GetConnection())
                    {
                        string query = "INSERT INTO users (name, contact_number, password) VALUES (@name, @contactNumber, @password)";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@contactNumber", contactNumber);

                            // Hash the password before saving
                            string hashedPassword = HashPassword(password);
                            cmd.Parameters.AddWithValue("@password", hashedPassword);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Registration successful!");
                                nameTxtbox.Clear();
                                contactNumberTxtbox.Clear();
                                passwordTxtbox.Clear();
                                confirmPasswordTxtbox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
            }

        }

    }
}
