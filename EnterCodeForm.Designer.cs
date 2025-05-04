namespace EDP
{
    partial class EnterCodeForm
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
            resendCodeBtn = new Button();
            backBtn = new Button();
            forgotPasswordLabel = new Label();
            nextBtn = new Button();
            codeTxtbox = new TextBox();
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
            loginFormPanel.Controls.Add(resendCodeBtn);
            loginFormPanel.Controls.Add(backBtn);
            loginFormPanel.Controls.Add(forgotPasswordLabel);
            loginFormPanel.Controls.Add(nextBtn);
            loginFormPanel.Controls.Add(codeTxtbox);
            loginFormPanel.Controls.Add(label1);
            loginFormPanel.Controls.Add(controlPanel);
            loginFormPanel.Dock = DockStyle.Right;
            loginFormPanel.Location = new Point(483, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(417, 506);
            loginFormPanel.TabIndex = 6;
            // 
            // resendCodeBtn
            // 
            resendCodeBtn.FlatAppearance.BorderSize = 0;
            resendCodeBtn.FlatStyle = FlatStyle.Flat;
            resendCodeBtn.ForeColor = SystemColors.MenuHighlight;
            resendCodeBtn.Location = new Point(248, 262);
            resendCodeBtn.Name = "resendCodeBtn";
            resendCodeBtn.Size = new Size(85, 23);
            resendCodeBtn.TabIndex = 5;
            resendCodeBtn.Text = "Resend Code";
            resendCodeBtn.UseVisualStyleBackColor = true;
            resendCodeBtn.Click += resendCodeBtn_Click;
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
            // nextBtn
            // 
            nextBtn.BackColor = Color.Teal;
            nextBtn.FlatAppearance.BorderSize = 0;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Segoe UI", 11F);
            nextBtn.ForeColor = Color.WhiteSmoke;
            nextBtn.Location = new Point(211, 312);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(94, 31);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // codeTxtbox
            // 
            codeTxtbox.Font = new Font("Segoe UI", 11F);
            codeTxtbox.ForeColor = Color.Black;
            codeTxtbox.Location = new Point(83, 234);
            codeTxtbox.Name = "codeTxtbox";
            codeTxtbox.PlaceholderText = "Enter code";
            codeTxtbox.Size = new Size(249, 27);
            codeTxtbox.TabIndex = 2;
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
            label1.Text = "Please enter code sent to you.";
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
            controlPanel.Size = new Size(417, 28);
            controlPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.Image = Properties.Resources.exit_icon;
            closeButton.Location = new Point(394, 3);
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
            minimizeButton.Location = new Point(367, 3);
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
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // EnterCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 506);
            ControlBox = false;
            Controls.Add(loginFormPanel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterCodeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterCodeForm";
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
        private Label forgotPasswordLabel;
        private Button nextBtn;
        private TextBox codeTxtbox;
        private Label label1;
        private FlowLayoutPanel controlPanel;
        private PictureBox closeButton;
        private PictureBox minimizeButton;
        private PictureBox pictureBox1;
        private Button resendCodeBtn;
    }
}