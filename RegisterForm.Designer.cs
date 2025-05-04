namespace EDP
{
    partial class RegisterForm
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
            controlPanel = new FlowLayoutPanel();
            closeButton = new PictureBox();
            minimizeButton = new PictureBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTxtbox = new TextBox();
            contactNumberTxtbox = new TextBox();
            contactNumberLabel = new Label();
            loginLink = new Button();
            registerLabel = new Label();
            nameTxtbox = new TextBox();
            passwordLabel = new Label();
            passwordTxtbox = new TextBox();
            nameLabel = new Label();
            registerBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            loginFormPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Controls.Add(confirmPasswordLabel);
            loginFormPanel.Controls.Add(confirmPasswordTxtbox);
            loginFormPanel.Controls.Add(contactNumberTxtbox);
            loginFormPanel.Controls.Add(contactNumberLabel);
            loginFormPanel.Controls.Add(loginLink);
            loginFormPanel.Controls.Add(registerLabel);
            loginFormPanel.Controls.Add(nameTxtbox);
            loginFormPanel.Controls.Add(passwordLabel);
            loginFormPanel.Controls.Add(passwordTxtbox);
            loginFormPanel.Controls.Add(nameLabel);
            loginFormPanel.Controls.Add(registerBtn);
            loginFormPanel.Dock = DockStyle.Right;
            loginFormPanel.Location = new Point(484, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(416, 506);
            loginFormPanel.TabIndex = 0;
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
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLabel.ForeColor = SystemColors.WindowFrame;
            confirmPasswordLabel.Location = new Point(50, 300);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(142, 21);
            confirmPasswordLabel.TabIndex = 19;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordTxtbox
            // 
            confirmPasswordTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmPasswordTxtbox.BackColor = Color.White;
            confirmPasswordTxtbox.Font = new Font("Segoe UI", 11F);
            confirmPasswordTxtbox.ForeColor = Color.DimGray;
            confirmPasswordTxtbox.Location = new Point(50, 324);
            confirmPasswordTxtbox.Name = "confirmPasswordTxtbox";
            confirmPasswordTxtbox.PlaceholderText = "Re-enter your password";
            confirmPasswordTxtbox.Size = new Size(326, 27);
            confirmPasswordTxtbox.TabIndex = 18;
            confirmPasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // contactNumberTxtbox
            // 
            contactNumberTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contactNumberTxtbox.BackColor = Color.White;
            contactNumberTxtbox.Font = new Font("Segoe UI", 11F);
            contactNumberTxtbox.ForeColor = Color.DimGray;
            contactNumberTxtbox.Location = new Point(49, 195);
            contactNumberTxtbox.Name = "contactNumberTxtbox";
            contactNumberTxtbox.PlaceholderText = "Enter your contact number";
            contactNumberTxtbox.Size = new Size(326, 27);
            contactNumberTxtbox.TabIndex = 16;
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumberLabel.ForeColor = SystemColors.WindowFrame;
            contactNumberLabel.Location = new Point(49, 171);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(131, 21);
            contactNumberLabel.TabIndex = 17;
            contactNumberLabel.Text = "Contact Number";
            // 
            // loginLink
            // 
            loginLink.BackColor = Color.Transparent;
            loginLink.FlatAppearance.BorderSize = 0;
            loginLink.FlatStyle = FlatStyle.Flat;
            loginLink.ForeColor = SystemColors.MenuHighlight;
            loginLink.Location = new Point(119, 427);
            loginLink.Name = "loginLink";
            loginLink.RightToLeft = RightToLeft.No;
            loginLink.Size = new Size(210, 23);
            loginLink.TabIndex = 15;
            loginLink.Text = "Already have an account? Login here";
            loginLink.UseVisualStyleBackColor = false;
            loginLink.Click += loginLink_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = Color.Transparent;
            registerLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = SystemColors.WindowFrame;
            registerLabel.Location = new Point(155, 54);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(102, 32);
            registerLabel.TabIndex = 10;
            registerLabel.Text = "Register";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTxtbox
            // 
            nameTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTxtbox.BackColor = Color.White;
            nameTxtbox.Font = new Font("Segoe UI", 11F);
            nameTxtbox.ForeColor = Color.DimGray;
            nameTxtbox.Location = new Point(50, 133);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.PlaceholderText = "Enter your name";
            nameTxtbox.Size = new Size(326, 27);
            nameTxtbox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.WindowFrame;
            passwordLabel.Location = new Point(49, 236);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(79, 21);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTxtbox.BackColor = Color.White;
            passwordTxtbox.Font = new Font("Segoe UI", 11F);
            passwordTxtbox.ForeColor = Color.DimGray;
            passwordTxtbox.Location = new Point(49, 260);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.PlaceholderText = "Enter your password";
            passwordTxtbox.Size = new Size(326, 27);
            passwordTxtbox.TabIndex = 9;
            passwordTxtbox.UseSystemPasswordChar = true;
            passwordTxtbox.TextChanged += passwordTxtbox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.WindowFrame;
            nameLabel.Location = new Point(50, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name";
            // 
            // registerBtn
            // 
            registerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            registerBtn.BackColor = Color.Teal;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 11F);
            registerBtn.ForeColor = SystemColors.ButtonHighlight;
            registerBtn.Location = new Point(125, 390);
            registerBtn.Name = "registerBtn";
            registerBtn.Padding = new Padding(2);
            registerBtn.Size = new Size(168, 31);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loginFormPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 506);
            panel1.TabIndex = 1;
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 506);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginFormPanel;
        private FlowLayoutPanel controlPanel;
        private PictureBox closeButton;
        private PictureBox minimizeButton;
        private Panel panel1;
        private Button loginLink;
        private Label registerLabel;
        private TextBox nameTxtbox;
        private Label passwordLabel;
        private TextBox passwordTxtbox;
        private Label nameLabel;
        private Button registerBtn;
        private TextBox contactNumberTxtbox;
        private Label contactNumberLabel;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTxtbox;
        private PictureBox pictureBox1;
    }
}