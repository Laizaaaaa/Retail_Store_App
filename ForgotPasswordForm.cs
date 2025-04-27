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
    public partial class ForgotPasswordForm : Form
    {
        private string generatedCode;
        private string userInput;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
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

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            userInput = nameOrContactTxtbox.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter your registered name or contact number.");
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT * FROM users WHERE name = @input OR contact_number = @input";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@input", userInput);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // User exists, generate verification code
                                generatedCode = GenerateVerificationCode();

                                // "Send" the code via SMS (for now, just show it via MessageBox or simulate)
                                MessageBox.Show($"(Simulated SMS) Your verification code is: {generatedCode}");

                                // Open form to enter the verification code
                                EnterCodeForm enterCodeForm = new EnterCodeForm(this); // Pass this ForgotPasswordForm
                                enterCodeForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No user found with that name or contact number.");
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

        // Function to generate 6-digit code
        private string GenerateVerificationCode()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString(); // 6-digit random number
        }
    }
}
