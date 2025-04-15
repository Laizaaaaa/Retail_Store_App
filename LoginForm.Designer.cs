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
            controlPanel = new FlowLayoutPanel();
            minimizeButton = new PictureBox();
            maximizeButton = new PictureBox();
            exitFullScreenButton = new PictureBox();
            closeButton = new PictureBox();
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
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitFullScreenButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            loginPicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(controlPanel);
            panel1.Controls.Add(loginFormPanel);
            panel1.Controls.Add(loginPicPanel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 510);
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
            loginFormPanel.Location = new Point(372, 50);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(279, 395);
            loginFormPanel.TabIndex = 0;
            loginFormPanel.Paint += loginFormPanel_Paint;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(minimizeButton);
            controlPanel.Controls.Add(maximizeButton);
            controlPanel.Controls.Add(exitFullScreenButton);
            controlPanel.Controls.Add(closeButton);
            controlPanel.Location = new Point(624, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(106, 28);
            controlPanel.TabIndex = 4;
            // 
            // minimizeButton
            // 
            minimizeButton.Image = Properties.Resources.minimize_icon;
            minimizeButton.Location = new Point(3, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(21, 20);
            minimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeButton.TabIndex = 0;
            minimizeButton.TabStop = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // maximizeButton
            // 
            maximizeButton.Image = Properties.Resources.maximize_icon;
            maximizeButton.Location = new Point(30, 3);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(20, 20);
            maximizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            maximizeButton.TabIndex = 1;
            maximizeButton.TabStop = false;
            maximizeButton.Click += maximizeButton_Click;
            // 
            // exitFullScreenButton
            // 
            exitFullScreenButton.Image = Properties.Resources.exit_full_screen_icon;
            exitFullScreenButton.Location = new Point(56, 3);
            exitFullScreenButton.Name = "exitFullScreenButton";
            exitFullScreenButton.Size = new Size(20, 20);
            exitFullScreenButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitFullScreenButton.TabIndex = 3;
            exitFullScreenButton.TabStop = false;
            exitFullScreenButton.Visible = false;
            exitFullScreenButton.Click += exitFullScreenButton_Click;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.exit_icon;
            closeButton.Location = new Point(82, 3);
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
            loginPicPanel.Location = new Point(88, 50);
            loginPicPanel.Name = "loginPicPanel";
            loginPicPanel.Size = new Size(288, 395);
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
            pictureBox1.Size = new Size(285, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(730, 510);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Shown;
            panel1.ResumeLayout(false);
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitFullScreenButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            loginPicPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private FlowLayoutPanel controlPanel;
        private PictureBox minimizeButton;
        private PictureBox maximizeButton;
        private PictureBox exitFullScreenButton;
        private PictureBox closeButton;
    }
}