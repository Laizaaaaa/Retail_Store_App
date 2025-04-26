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
            ForgotPasswordBtn = new Button();
            controlPanel = new FlowLayoutPanel();
            minimizeButton = new PictureBox();
            closeButton = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            loginBtn = new Button();
            loginLabel = new Label();
            passwordInputField = new TextBox();
            emailInputField = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            loginFormPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
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
            panel1.Paint += panel1_Paint;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.Controls.Add(ForgotPasswordBtn);
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(loginBtn);
            loginFormPanel.Controls.Add(loginLabel);
            loginFormPanel.Controls.Add(passwordInputField);
            loginFormPanel.Controls.Add(emailInputField);
            loginFormPanel.Location = new Point(481, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(416, 500);
            loginFormPanel.TabIndex = 0;
            loginFormPanel.Paint += loginFormPanel_Paint;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(52, 164);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.BackColor = Color.Teal;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 11F);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(180, 378);
            loginBtn.Name = "loginBtn";
            loginBtn.Padding = new Padding(2);
            loginBtn.Size = new Size(71, 31);
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
            // passwordInputField
            // 
            passwordInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordInputField.BackColor = Color.White;
            passwordInputField.Font = new Font("Segoe UI", 11F);
            passwordInputField.ForeColor = Color.DimGray;
            passwordInputField.Location = new Point(52, 264);
            passwordInputField.Name = "passwordInputField";
            passwordInputField.PlaceholderText = "Enter your password";
            passwordInputField.Size = new Size(331, 27);
            passwordInputField.TabIndex = 1;
            passwordInputField.UseSystemPasswordChar = true;
            passwordInputField.Click += passwordInputField_Enter;
            passwordInputField.MouseClick += passwordInputField_Enter;
            passwordInputField.TextChanged += passwordInputField_TextChanged;
            passwordInputField.Leave += passwordInputField_Leave;
            // 
            // emailInputField
            // 
            emailInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailInputField.BackColor = Color.White;
            emailInputField.Font = new Font("Segoe UI", 11F);
            emailInputField.ForeColor = Color.DimGray;
            emailInputField.Location = new Point(52, 188);
            emailInputField.Name = "emailInputField";
            emailInputField.PlaceholderText = "Enter your email";
            emailInputField.Size = new Size(331, 27);
            emailInputField.TabIndex = 0;
            emailInputField.Click += emailInputField_Enter;
            emailInputField.MouseClick += emailInputField_Enter;
            emailInputField.TextChanged += emailInputField_TextChanged;
            emailInputField.Leave += emailInputField_Leave;
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
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel loginFormPanel;
        private TextBox passwordInputField;
        private TextBox emailInputField;
        private Label loginLabel;
        private Button loginBtn;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel controlPanel;
        private PictureBox minimizeButton;
        private PictureBox closeButton;
        private PictureBox pictureBox1;
        private Button ForgotPasswordBtn;
    }
}