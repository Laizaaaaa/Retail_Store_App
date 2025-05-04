using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            userInput = emailTxtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT email FROM users WHERE email = @input";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@input", userInput);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string email = reader.GetString("email");

                                generatedCode = GenerateVerificationCode();

                                // ✅ Correct method to send OTP via email
                                SendOtpEmail(email, generatedCode);

                                // ✅ Open code entry form
                                EnterCodeForm enterCodeForm = new EnterCodeForm(this, generatedCode, userInput);
                                enterCodeForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No user found with that email.");
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

        // ✅ Generate 6-digit OTP
        private string GenerateVerificationCode()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }

        // ✅ Send OTP via Gmail SMTP
        private void SendOtpEmail(string toEmail, string otp)
        {
            var fromAddress = new MailAddress("lmbb2022-2851-76296@bicol-u.edu.ph", "JFKL Sari-sari Store");
            var toAddress = new MailAddress(toEmail);
            const string fromPassword = "bdgc tibw llxs nste"; // Use Google App Password

            string subject = "OTP Verification Code";
            string body = $"Your OTP code is: {otp}\n\nThis code will expire in 5 minutes.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            MessageBox.Show("OTP has been sent to your email.");
        }

        private void loginFormPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional panel paint logic
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
