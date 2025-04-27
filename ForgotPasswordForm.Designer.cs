namespace EDP
{
    partial class ForgotPasswordForm
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
            backBtn = new Button();
            sendCodeBtn = new Button();
            contactNumberTxtbox = new TextBox();
            label1 = new Label();
            forgotPasswordLabel = new Label();
            loginFormPanel = new Panel();
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
            // sendCodeBtn
            // 
            sendCodeBtn.BackColor = Color.Teal;
            sendCodeBtn.FlatAppearance.BorderSize = 0;
            sendCodeBtn.FlatStyle = FlatStyle.Flat;
            sendCodeBtn.Font = new Font("Segoe UI", 11F);
            sendCodeBtn.ForeColor = Color.WhiteSmoke;
            sendCodeBtn.Location = new Point(211, 312);
            sendCodeBtn.Name = "sendCodeBtn";
            sendCodeBtn.Size = new Size(94, 31);
            sendCodeBtn.TabIndex = 3;
            sendCodeBtn.Text = "Send Code";
            sendCodeBtn.UseVisualStyleBackColor = false;
            sendCodeBtn.Click += sendCodeBtn_Click;
            // 
            // contactNumberTxtbox
            // 
            contactNumberTxtbox.Font = new Font("Segoe UI", 11F);
            contactNumberTxtbox.ForeColor = SystemColors.ScrollBar;
            contactNumberTxtbox.Location = new Point(83, 238);
            contactNumberTxtbox.Name = "contactNumberTxtbox";
            contactNumberTxtbox.PlaceholderText = "Enter your contact number";
            contactNumberTxtbox.Size = new Size(249, 27);
            contactNumberTxtbox.TabIndex = 2;
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
            label1.Text = "Please enter your contact number. A code will be sent to you to proceed with the changing of password.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.BackColor = Color.Transparent;
            forgotPasswordLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotPasswordLabel.ForeColor = SystemColors.WindowFrame;
            forgotPasswordLabel.Location = new Point(111, 101);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(194, 32);
            forgotPasswordLabel.TabIndex = 0;
            forgotPasswordLabel.Text = "Forgot Password";
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.Controls.Add(backBtn);
            loginFormPanel.Controls.Add(forgotPasswordLabel);
            loginFormPanel.Controls.Add(sendCodeBtn);
            loginFormPanel.Controls.Add(contactNumberTxtbox);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Dock = DockStyle.Right;
            loginFormPanel.Location = new Point(484, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(416, 506);
            loginFormPanel.TabIndex = 5;
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
            controlPanel.Size = new Size(413, 28);
            controlPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.exit_icon;
            closeButton.Location = new Point(390, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(20, 20);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 2;
            closeButton.TabStop = false;
            // 
            // minimizeButton
            // 
            minimizeButton.Image = Properties.Resources.minimize_icon;
            minimizeButton.Location = new Point(363, 3);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(21, 20);
            minimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeButton.TabIndex = 0;
            minimizeButton.TabStop = false;
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(900, 506);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(loginFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label forgotPasswordLabel;
        private Label label1;
        private Button backBtn;
        private Button sendCodeBtn;
        private TextBox contactNumberTxtbox;
        private Panel loginFormPanel;
        private FlowLayoutPanel controlPanel;
        private PictureBox closeButton;
        private PictureBox minimizeButton;
        private PictureBox pictureBox1;
    }
}