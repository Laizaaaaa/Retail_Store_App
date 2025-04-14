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
            loginFormPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            loginBtn = new Button();
            loginLabel = new Label();
            passwordInputField = new TextBox();
            emailInputField = new TextBox();
            loginPicPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            loginFormPanel.SuspendLayout();
            loginPicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(loginFormPanel);
            panel1.Controls.Add(loginPicPanel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = SystemColors.ControlLightLight;
            loginFormPanel.Controls.Add(label2);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(loginBtn);
            loginFormPanel.Controls.Add(loginLabel);
            loginFormPanel.Controls.Add(passwordInputField);
            loginFormPanel.Controls.Add(emailInputField);
            loginFormPanel.Location = new Point(395, 34);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(304, 389);
            loginFormPanel.TabIndex = 0;
            loginFormPanel.Paint += loginFormPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(55, 186);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(55, 121);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.CornflowerBlue;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(112, 255);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 29);
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
            loginLabel.Location = new Point(112, 57);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(81, 32);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Log in";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordInputField
            // 
            passwordInputField.BackColor = Color.White;
            passwordInputField.Font = new Font("Segoe UI", 9F);
            passwordInputField.ForeColor = Color.DimGray;
            passwordInputField.Location = new Point(55, 204);
            passwordInputField.Name = "passwordInputField";
            passwordInputField.PlaceholderText = "Enter your password";
            passwordInputField.Size = new Size(194, 23);
            passwordInputField.TabIndex = 1;
            passwordInputField.UseSystemPasswordChar = true;
            passwordInputField.Click += passwordInputField_Enter;
            passwordInputField.MouseClick += passwordInputField_Enter;
            passwordInputField.TextChanged += passwordInputField_TextChanged;
            passwordInputField.Leave += passwordInputField_Leave;
            // 
            // emailInputField
            // 
            emailInputField.BackColor = Color.White;
            emailInputField.Font = new Font("Segoe UI", 9F);
            emailInputField.ForeColor = Color.DimGray;
            emailInputField.Location = new Point(55, 139);
            emailInputField.Name = "emailInputField";
            emailInputField.PlaceholderText = "Enter your email";
            emailInputField.Size = new Size(194, 23);
            emailInputField.TabIndex = 0;
            emailInputField.Click += emailInputField_Enter;
            emailInputField.MouseClick += emailInputField_Enter;
            emailInputField.TextChanged += emailInputField_TextChanged;
            emailInputField.Leave += emailInputField_Leave;
            // 
            // loginPicPanel
            // 
            loginPicPanel.BackColor = Color.Transparent;
            loginPicPanel.Controls.Add(pictureBox1);
            loginPicPanel.Location = new Point(86, 34);
            loginPicPanel.Name = "loginPicPanel";
            loginPicPanel.Size = new Size(313, 389);
            loginPicPanel.TabIndex = 1;
            loginPicPanel.Paint += loginPicPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_transparent;
            pictureBox1.Location = new Point(3, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Shown;
            panel1.ResumeLayout(false);
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            loginPicPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel loginFormPanel;
        private PictureBox pictureBox1;
        private TextBox passwordInputField;
        private TextBox emailInputField;
        private Label loginLabel;
        private Button loginBtn;
        private Panel loginPicPanel;
        private Label label2;
        private Label label1;
    }
}