using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void emailInputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailInputField_Enter(object sender, EventArgs e)
        {
            if (emailInputField.ForeColor == Color.Gray)
            {
                emailInputField.Text = "";
                emailInputField.ForeColor = Color.Black;
            }
        }


        private void emailInputField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailInputField.Text))
            {
                emailInputField.ForeColor = Color.Gray;

                this.ActiveControl = null;
            }
        }


        private void passwordInputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInputField_Enter(object sender, EventArgs e)
        {
            if (passwordInputField.ForeColor == Color.Gray)
            {
                passwordInputField.Text = "";
                passwordInputField.ForeColor = Color.Black;
                passwordInputField.UseSystemPasswordChar = true;
            }
        }


        private void passwordInputField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordInputField.Text))
            {
                passwordInputField.ForeColor = Color.Gray;
            }

            this.ActiveControl = null;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginFormPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loginPicPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                    Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical)) // Can be Horizontal, ForwardDiagonal, etc.
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void passwordInputField_Enter(object sender, MouseEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.FormClosed += (s, args) => this.Close();

            home.Show();
            this.Hide();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizeButton.Visible = false;
            exitFullScreenButton.Visible = true;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitFullScreenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizeButton.Visible = true;
            exitFullScreenButton.Visible = false;
        }
    }
}
