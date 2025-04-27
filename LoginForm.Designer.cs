namespace EDP
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            loginFormPanel = new Panel();
            registerLink = new Button();
            ForgotPasswordBtn = new Button();
            controlPanel = new FlowLayoutPanel();
            closeButton = new PictureBox();
            minimizeButton = new PictureBox();
            label2 = new Label();
            nameLabel = new Label();
            loginBtn = new Button();
            loginLabel = new Label();
            passwordTxtbox = new TextBox();
            nameTxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            loginFormPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loginFormPanel);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 506);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.FromArgb(0, 64, 64);
            pictureBox1.Image = Properties.Resources.logo_transparent;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.Controls.Add(registerLink);
            loginFormPanel.Controls.Add(ForgotPasswordBtn);
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(nameLabel);
            loginFormPanel.Controls.Add(loginBtn);
            loginFormPanel.Controls.Add(loginLabel);
            loginFormPanel.Controls.Add(passwordTxtbox);
            loginFormPanel.Controls.Add(nameTxtbox);
            loginFormPanel.Location = new Point(481, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(416, 500);
            loginFormPanel.TabIndex = 0;
            // 
            // registerLink
            // 
            registerLink.BackColor = Color.Transparent;
            registerLink.FlatAppearance.BorderSize = 0;
            registerLink.FlatStyle = FlatStyle.Flat;
            registerLink.ForeColor = SystemColors.MenuHighlight;
            registerLink.Location = new Point(111, 415);
            registerLink.Name = "registerLink";
            registerLink.RightToLeft = RightToLeft.No;
            registerLink.Size = new Size(210, 23);
            registerLink.TabIndex = 7;
            registerLink.Text = "Don't have an account? Register here";
            registerLink.UseVisualStyleBackColor = false;
            registerLink.Click += registerBtn_Click;
            // 
            // ForgotPasswordBtn
            // 
            ForgotPasswordBtn.BackColor = Color.Transparent;
            ForgotPasswordBtn.FlatAppearance.BorderSize = 0;
            ForgotPasswordBtn.FlatStyle = FlatStyle.Flat;
            ForgotPasswordBtn.ForeColor = SystemColors.MenuHighlight;
            ForgotPasswordBtn.Location = new Point(278, 292);
            ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            ForgotPasswordBtn.RightToLeft = RightToLeft.No;
            ForgotPasswordBtn.Size = new Size(112, 23);
            ForgotPasswordBtn.TabIndex = 6;
            ForgotPasswordBtn.Text = "Forgot Password?";
            ForgotPasswordBtn.TextAlign = ContentAlignment.MiddleRight;
            ForgotPasswordBtn.UseVisualStyleBackColor = false;
            ForgotPasswordBtn.Click += ForgotPasswordBtn_Click;
            // 
            // controlPanel
            // 
            controlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            controlPanel.BackColor = Color.Transparent;
            controlPanel.Controls.Add(closeButton);
            controlPanel.Controls.Add(minimizeButton);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(52, 240);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.WindowFrame;
            nameLabel.Location = new Point(52, 164);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.BackColor = Color.Teal;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 11F);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(117, 378);
            loginBtn.Name = "loginBtn";
            loginBtn.Padding = new Padding(2);
            loginBtn.Size = new Size(204, 31);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = SystemColors.WindowFrame;
            loginLabel.Location = new Point(170, 100);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(81, 32);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Log in";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTxtbox.BackColor = SystemColors.Window;
            passwordTxtbox.Font = new Font("Segoe UI", 11F);
            passwordTxtbox.ForeColor = SystemColors.ScrollBar;
            passwordTxtbox.Location = new Point(52, 264);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.PlaceholderText = "Enter your password";
            passwordTxtbox.Size = new Size(331, 27);
            passwordTxtbox.TabIndex = 1;
            passwordTxtbox.UseSystemPasswordChar = true;
            passwordTxtbox.Click += passwordInputField_Enter;
            passwordTxtbox.MouseClick += passwordInputField_Enter;
            passwordTxtbox.Leave += passwordInputField_Leave;
            // 
            // nameTxtbox
            // 
            nameTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTxtbox.BackColor = SystemColors.Window;
            nameTxtbox.Font = new Font("Segoe UI", 11F);
            nameTxtbox.ForeColor = SystemColors.ScrollBar;
            nameTxtbox.Location = new Point(52, 188);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.PlaceholderText = "Enter your name";
            nameTxtbox.Size = new Size(331, 27);
            nameTxtbox.TabIndex = 0;
            nameTxtbox.Click += nameInputField_Enter;
            nameTxtbox.MouseClick += nameInputField_Enter;
            nameTxtbox.Leave += nameInputField_Leave;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(899, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel loginFormPanel;
        private TextBox passwordTxtbox;
        private TextBox nameTxtbox;
        private Label loginLabel;
        private Button loginBtn;
        private Label label2;
        private Label nameLabel;
        private FlowLayoutPanel controlPanel;
        private PictureBox minimizeButton;
        private PictureBox closeButton;
        private PictureBox pictureBox1;
        private Button ForgotPasswordBtn;
        private Button registerLink;
    }
}