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

namespace EDP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Shown += LoginForm_Shown;
        }

        private void LoginForm_Shown(object? sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void emailContactTxtbox_Enter(object sender, EventArgs e)
        {
            if (emailContactTxtbox.ForeColor == Color.Gray)
            {
                emailContactTxtbox.Text = "";
                emailContactTxtbox.ForeColor = Color.Black;
            }
        }

        private void emailContactTxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailContactTxtbox.Text))
            {
                emailContactTxtbox.ForeColor = Color.Gray;
                this.ActiveControl = null;
            }
        }


        private void passwordInputField_Enter(object sender, EventArgs e)
        {
            if (passwordTxtbox.ForeColor == Color.Gray)
            {
                passwordTxtbox.Text = "";
                passwordTxtbox.ForeColor = Color.Black;
                passwordTxtbox.UseSystemPasswordChar = true;
            }
        }


        private void passwordInputField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxtbox.Text))
            {
                passwordTxtbox.ForeColor = Color.Gray;
            }

            this.ActiveControl = null;
        }

        private void passwordInputField_Enter(object sender, MouseEventArgs e)
        {

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string input = emailContactTxtbox.Text.Trim();
            string password = passwordTxtbox.Text;

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Hash the entered password to match what is stored
            string hashedPassword = HashPassword(password);

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = @"
            SELECT role FROM users 
            WHERE (email = @input OR contact_number = @input) 
            AND password = @password";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@input", input);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();

                                if (role.ToLower() == "admin")
                                {
                                    MessageBox.Show("Login successful!");

                                    Home home = new Home();
                                    home.FormClosed += (s, args) => this.Close();
                                    home.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Access denied. Only admins can log in.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email/contact number or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.FormClosed += (s, args) => this.Close();

            register.Show();
            this.Hide();
        }

        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            forgotPassword.FormClosed += (s, args) => this.Close();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
