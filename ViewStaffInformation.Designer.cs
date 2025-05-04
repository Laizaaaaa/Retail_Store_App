namespace EDP
{
    partial class ViewStaffInformation
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
            addProductForm = new Panel();
            roleLabel = new Label();
            roleTxtbox = new TextBox();
            emailLabel = new Label();
            emailTxtbox = new TextBox();
            backBtn = new Button();
            contactNumberLabel = new Label();
            contactNumberTxtbox = new TextBox();
            staffNameLabel = new Label();
            nameTxtbox = new TextBox();
            viewStaffLabel = new Label();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(roleLabel);
            addProductForm.Controls.Add(roleTxtbox);
            addProductForm.Controls.Add(emailLabel);
            addProductForm.Controls.Add(emailTxtbox);
            addProductForm.Controls.Add(backBtn);
            addProductForm.Controls.Add(contactNumberLabel);
            addProductForm.Controls.Add(contactNumberTxtbox);
            addProductForm.Controls.Add(staffNameLabel);
            addProductForm.Controls.Add(nameTxtbox);
            addProductForm.Controls.Add(viewStaffLabel);
            addProductForm.Location = new Point(187, 59);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(454, 453);
            addProductForm.TabIndex = 4;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.WhiteSmoke;
            roleLabel.Location = new Point(50, 287);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(30, 15);
            roleLabel.TabIndex = 24;
            roleLabel.Text = "Role";
            // 
            // roleTxtbox
            // 
            roleTxtbox.Location = new Point(50, 309);
            roleTxtbox.Name = "roleTxtbox";
            roleTxtbox.ReadOnly = true;
            roleTxtbox.Size = new Size(358, 23);
            roleTxtbox.TabIndex = 23;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.WhiteSmoke;
            emailLabel.Location = new Point(50, 221);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email";
            // 
            // emailTxtbox
            // 
            emailTxtbox.Location = new Point(50, 243);
            emailTxtbox.Name = "emailTxtbox";
            emailTxtbox.ReadOnly = true;
            emailTxtbox.Size = new Size(358, 23);
            emailTxtbox.TabIndex = 17;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.DarkSlateGray;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.WhiteSmoke;
            backBtn.Location = new Point(313, 376);
            backBtn.Name = "backBtn";
            backBtn.Padding = new Padding(2);
            backBtn.Size = new Size(95, 31);
            backBtn.TabIndex = 16;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.ForeColor = Color.WhiteSmoke;
            contactNumberLabel.Location = new Point(50, 157);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(96, 15);
            contactNumberLabel.TabIndex = 4;
            contactNumberLabel.Text = "Contact Number";
            // 
            // contactNumberTxtbox
            // 
            contactNumberTxtbox.Location = new Point(50, 179);
            contactNumberTxtbox.Name = "contactNumberTxtbox";
            contactNumberTxtbox.ReadOnly = true;
            contactNumberTxtbox.Size = new Size(358, 23);
            contactNumberTxtbox.TabIndex = 3;
            // 
            // staffNameLabel
            // 
            staffNameLabel.AutoSize = true;
            staffNameLabel.ForeColor = Color.WhiteSmoke;
            staffNameLabel.Location = new Point(50, 94);
            staffNameLabel.Name = "staffNameLabel";
            staffNameLabel.Size = new Size(66, 15);
            staffNameLabel.TabIndex = 2;
            staffNameLabel.Text = "Staff Name";
            // 
            // nameTxtbox
            // 
            nameTxtbox.Location = new Point(50, 116);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.ReadOnly = true;
            nameTxtbox.Size = new Size(358, 23);
            nameTxtbox.TabIndex = 1;
            // 
            // viewStaffLabel
            // 
            viewStaffLabel.AutoSize = true;
            viewStaffLabel.BackColor = Color.Transparent;
            viewStaffLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            viewStaffLabel.ForeColor = Color.WhiteSmoke;
            viewStaffLabel.Location = new Point(140, 31);
            viewStaffLabel.Name = "viewStaffLabel";
            viewStaffLabel.Size = new Size(206, 25);
            viewStaffLabel.TabIndex = 0;
            viewStaffLabel.Text = "View Staff Information";
            // 
            // ViewStaffInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(addProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStaffInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Load += viewStaffInformation_Load;
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label roleLabel;
        private TextBox roleTxtbox;
        private Label emailLabel;
        private TextBox emailTxtbox;
        private Button backBtn;
        private Label contactNumberLabel;
        private TextBox contactNumberTxtbox;
        private Label staffNameLabel;
        private TextBox nameTxtbox;
        private Label viewStaffLabel;
    }
}