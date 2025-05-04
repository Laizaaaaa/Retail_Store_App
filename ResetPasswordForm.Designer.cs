namespace EDP
{
    partial class ResetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginFormPanel = new Panel();
            confirmPasswordTxtbox = new TextBox();
            backBtn = new Button();
            resetPasswordLabel = new Label();
            submitBtn = new Button();
            newPasswordTxtbox = new TextBox();
            label1 = new Label();
            controlPanel = new FlowLayoutPanel();
            closeButton = new PictureBox();
            minimizeButton = new PictureBox();
            pictureBox1 = new PictureBox();
            loginFormPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.Controls.Add(confirmPasswordTxtbox);
            loginFormPanel.Controls.Add(backBtn);
            loginFormPanel.Controls.Add(resetPasswordLabel);
            loginFormPanel.Controls.Add(submitBtn);
            loginFormPanel.Controls.Add(newPasswordTxtbox);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Dock = DockStyle.Right;
            loginFormPanel.Location = new Point(484, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(416, 506);
            loginFormPanel.TabIndex = 8;
            // 
            // confirmPasswordTxtbox
            // 
            confirmPasswordTxtbox.Font = new Font("Segoe UI", 11F);
            confirmPasswordTxtbox.ForeColor = Color.Black;
            confirmPasswordTxtbox.Location = new Point(82, 257);
            confirmPasswordTxtbox.Name = "confirmPasswordTxtbox";
            confirmPasswordTxtbox.PlaceholderText = "Confirm new password";
            confirmPasswordTxtbox.Size = new Size(249, 27);
            confirmPasswordTxtbox.TabIndex = 5;
            confirmPasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.DarkSlateGray;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 11F);
            backBtn.ForeColor = Color.WhiteSmoke;
            backBtn.Location = new Point(111, 312);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 31);
            backBtn.TabIndex = 4;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // resetPasswordLabel
            // 
            resetPasswordLabel.AutoSize = true;
            resetPasswordLabel.BackColor = Color.Transparent;
            resetPasswordLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetPasswordLabel.ForeColor = SystemColors.WindowFrame;
            resetPasswordLabel.Location = new Point(111, 101);
            resetPasswordLabel.Name = "resetPasswordLabel";
            resetPasswordLabel.Size = new Size(181, 32);
            resetPasswordLabel.TabIndex = 0;
            resetPasswordLabel.Text = "Reset Password";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Teal;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 11F);
            submitBtn.ForeColor = Color.WhiteSmoke;
            submitBtn.Location = new Point(211, 312);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 31);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // newPasswordTxtbox
            // 
            newPasswordTxtbox.Font = new Font("Segoe UI", 11F);
            newPasswordTxtbox.ForeColor = Color.Black;
            newPasswordTxtbox.Location = new Point(82, 215);
            newPasswordTxtbox.Name = "newPasswordTxtbox";
            newPasswordTxtbox.PlaceholderText = "Enter new password";
            newPasswordTxtbox.Size = new Size(249, 27);
            newPasswordTxtbox.TabIndex = 2;
            newPasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(32, 147);
            label1.Name = "label1";
            label1.Size = new Size(372, 48);
            label1.TabIndex = 1;
            label1.Text = "Please enter new password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.Transparent;
            controlPanel.Controls.Add(closeButton);
            controlPanel.Controls.Add(minimizeButton);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.FlowDirection = FlowDirection.RightToLeft;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(416, 28);
            controlPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.exit_icon;
            closeButton.Location = new Point(393, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(20, 20);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 2;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.Image = Properties.Resources.minimize_icon;
            minimizeButton.Location = new Point(366, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(21, 20);
            minimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeButton.TabIndex = 0;
            minimizeButton.TabStop = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.FromArgb(0, 64, 64);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo_transparent;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 506);
            ControlBox = false;
            Controls.Add(loginFormPanel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginFormPanel;
        private Button backBtn;
        private Label resetPasswordLabel;
        private Button submitBtn;
        private TextBox newPasswordTxtbox;
        private Label label1;
        private FlowLayoutPanel controlPanel;
        private PictureBox closeButton;
        private PictureBox minimizeButton;
        private PictureBox pictureBox1;
        private TextBox confirmPasswordTxtbox;
    }
}