using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EDP
{
    public partial class EnterCodeForm : Form
    {
        private ForgotPasswordForm forgotPasswordForm;
        private string correctCode;
        private string emailAddress;

        public EnterCodeForm(ForgotPasswordForm parentForm, string code, string email)
        {
            InitializeComponent();
            forgotPasswordForm = parentForm;
            correctCode = code;
            emailAddress = email;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            forgotPasswordForm.Show();
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string enteredCode = codeTxtbox.Text.Trim();

            if (enteredCode == correctCode)
            {
                MessageBox.Show("Verification successful!");

                // ✅ Open reset password form
                ResetPasswordForm resetForm = new ResetPasswordForm(emailAddress, this);
                resetForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.");
            }
        }

        public static class EmailHelper
        {
            public static void SendOtpEmail(string toEmail, string otp)
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

                MessageBox.Show("New OTP sent to your email.");
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

        private void resendCodeBtn_Click(object sender, EventArgs e)
        {
            string newCode = new Random().Next(100000, 999999).ToString();
            correctCode = newCode; // Update with new code
            EmailHelper.SendOtpEmail(emailAddress, newCode); // Send the new OTP
        }

    }
}
