namespace EDP
{
    partial class AddSupplier
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
            addProductForm = new Panel();
            cancelBtn = new Button();
            addSupplierBtn = new Button();
            contactNumberLabel = new Label();
            contactNumberTxtbox = new TextBox();
            supplierNameLabel = new Label();
            supplierNameTxtbox = new TextBox();
            addSupplierLabel = new Label();
            panel1.SuspendLayout();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(addProductForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 640);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(cancelBtn);
            addProductForm.Controls.Add(addSupplierBtn);
            addProductForm.Controls.Add(contactNumberLabel);
            addProductForm.Controls.Add(contactNumberTxtbox);
            addProductForm.Controls.Add(supplierNameLabel);
            addProductForm.Controls.Add(supplierNameTxtbox);
            addProductForm.Controls.Add(addSupplierLabel);
            addProductForm.Location = new Point(183, 89);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(454, 348);
            addProductForm.TabIndex = 1;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(211, 266);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addSupplierBtn
            // 
            addSupplierBtn.BackColor = Color.Teal;
            addSupplierBtn.FlatAppearance.BorderSize = 0;
            addSupplierBtn.FlatStyle = FlatStyle.Flat;
            addSupplierBtn.ForeColor = Color.WhiteSmoke;
            addSupplierBtn.Location = new Point(313, 266);
            addSupplierBtn.Name = "addSupplierBtn";
            addSupplierBtn.Padding = new Padding(2);
            addSupplierBtn.Size = new Size(95, 31);
            addSupplierBtn.TabIndex = 15;
            addSupplierBtn.Text = "Add Supplier";
            addSupplierBtn.UseVisualStyleBackColor = false;
            addSupplierBtn.Click += addSupplierBtn_Click;
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.ForeColor = Color.WhiteSmoke;
            contactNumberLabel.Location = new Point(50, 177);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(96, 15);
            contactNumberLabel.TabIndex = 4;
            contactNumberLabel.Text = "Contact Number";
            // 
            // contactNumberTxtbox
            // 
            contactNumberTxtbox.Location = new Point(50, 199);
            contactNumberTxtbox.Name = "contactNumberTxtbox";
            contactNumberTxtbox.Size = new Size(358, 23);
            contactNumberTxtbox.TabIndex = 3;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.ForeColor = Color.WhiteSmoke;
            supplierNameLabel.Location = new Point(50, 114);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(85, 15);
            supplierNameLabel.TabIndex = 2;
            supplierNameLabel.Text = "Supplier Name";
            // 
            // supplierNameTxtbox
            // 
            supplierNameTxtbox.Location = new Point(50, 136);
            supplierNameTxtbox.Name = "supplierNameTxtbox";
            supplierNameTxtbox.Size = new Size(358, 23);
            supplierNameTxtbox.TabIndex = 1;
            // 
            // addSupplierLabel
            // 
            addSupplierLabel.AutoSize = true;
            addSupplierLabel.BackColor = Color.Transparent;
            addSupplierLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            addSupplierLabel.ForeColor = Color.WhiteSmoke;
            addSupplierLabel.Location = new Point(152, 54);
            addSupplierLabel.Name = "addSupplierLabel";
            addSupplierLabel.Size = new Size(166, 25);
            addSupplierLabel.TabIndex = 0;
            addSupplierLabel.Text = "Add New Supplier";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplier";
            panel1.ResumeLayout(false);
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel addProductForm;
        private Button cancelBtn;
        private Button addSupplierBtn;
        private Label contactNumberLabel;
        private TextBox contactNumberTxtbox;
        private Label supplierNameLabel;
        private TextBox supplierNameTxtbox;
        private Label addSupplierLabel;
    }
}