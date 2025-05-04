namespace EDP
{
    partial class EditStaffForm
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
            confirmPasswordLabel = new Label();
            confirmPasswordTxtbox = new TextBox();
            passwordLabel = new Label();
            passwordTxtbox = new TextBox();
            emailLabel = new Label();
            emailTxtbox = new TextBox();
            cancelBtn = new Button();
            updateBtn = new Button();
            contactNumberLabel = new Label();
            contactNumberTxtbox = new TextBox();
            staffNameLabel = new Label();
            nameTxtbox = new TextBox();
            editStaffLabel = new Label();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(roleLabel);
            addProductForm.Controls.Add(roleTxtbox);
            addProductForm.Controls.Add(confirmPasswordLabel);
            addProductForm.Controls.Add(confirmPasswordTxtbox);
            addProductForm.Controls.Add(passwordLabel);
            addProductForm.Controls.Add(passwordTxtbox);
            addProductForm.Controls.Add(emailLabel);
            addProductForm.Controls.Add(emailTxtbox);
            addProductForm.Controls.Add(cancelBtn);
            addProductForm.Controls.Add(updateBtn);
            addProductForm.Controls.Add(contactNumberLabel);
            addProductForm.Controls.Add(contactNumberTxtbox);
            addProductForm.Controls.Add(staffNameLabel);
            addProductForm.Controls.Add(nameTxtbox);
            addProductForm.Controls.Add(editStaffLabel);
            addProductForm.Location = new Point(183, 32);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(454, 576);
            addProductForm.TabIndex = 3;
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
            roleTxtbox.Size = new Size(358, 23);
            roleTxtbox.TabIndex = 23;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.ForeColor = Color.WhiteSmoke;
            confirmPasswordLabel.Location = new Point(50, 417);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(104, 15);
            confirmPasswordLabel.TabIndex = 22;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordTxtbox
            // 
            confirmPasswordTxtbox.Location = new Point(50, 439);
            confirmPasswordTxtbox.Name = "confirmPasswordTxtbox";
            confirmPasswordTxtbox.Size = new Size(358, 23);
            confirmPasswordTxtbox.TabIndex = 21;
            confirmPasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.WhiteSmoke;
            passwordLabel.Location = new Point(50, 353);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password";
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Location = new Point(50, 375);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.Size = new Size(358, 23);
            passwordTxtbox.TabIndex = 19;
            passwordTxtbox.UseSystemPasswordChar = true;
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
            emailTxtbox.Size = new Size(358, 23);
            emailTxtbox.TabIndex = 17;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(211, 513);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Teal;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.ForeColor = Color.WhiteSmoke;
            updateBtn.Location = new Point(313, 513);
            updateBtn.Name = "updateBtn";
            updateBtn.Padding = new Padding(2);
            updateBtn.Size = new Size(95, 31);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
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
            nameTxtbox.Size = new Size(358, 23);
            nameTxtbox.TabIndex = 1;
            // 
            // editStaffLabel
            // 
            editStaffLabel.AutoSize = true;
            editStaffLabel.BackColor = Color.Transparent;
            editStaffLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            editStaffLabel.ForeColor = Color.WhiteSmoke;
            editStaffLabel.Location = new Point(140, 31);
            editStaffLabel.Name = "editStaffLabel";
            editStaffLabel.Size = new Size(198, 25);
            editStaffLabel.TabIndex = 0;
            editStaffLabel.Text = "Edit Staff Information";
            // 
            // EditStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(addProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditStaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditStaffForm";
            Load += EditStaffForm_Load;
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label roleLabel;
        private TextBox roleTxtbox;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTxtbox;
        private Label passwordLabel;
        private TextBox passwordTxtbox;
        private Label emailLabel;
        private TextBox emailTxtbox;
        private Button cancelBtn;
        private Button updateBtn;
        private Label contactNumberLabel;
        private TextBox contactNumberTxtbox;
        private Label staffNameLabel;
        private TextBox nameTxtbox;
        private Label editStaffLabel;
    }
}