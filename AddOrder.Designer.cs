namespace EDP
{
    partial class AddOrder
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
            totalAmount = new Label();
            cancelBtn = new Button();
            addOrderBtn = new Button();
            totalLabel = new Label();
            qtyLabel = new Label();
            qtyTxtbox = new TextBox();
            productLabel = new Label();
            productTxtbox = new TextBox();
            supplierNameLabel = new Label();
            supplierNameTxtbox = new TextBox();
            addOrderLabel = new Label();
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
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(totalAmount);
            addProductForm.Controls.Add(cancelBtn);
            addProductForm.Controls.Add(addOrderBtn);
            addProductForm.Controls.Add(totalLabel);
            addProductForm.Controls.Add(qtyLabel);
            addProductForm.Controls.Add(qtyTxtbox);
            addProductForm.Controls.Add(productLabel);
            addProductForm.Controls.Add(productTxtbox);
            addProductForm.Controls.Add(supplierNameLabel);
            addProductForm.Controls.Add(supplierNameTxtbox);
            addProductForm.Controls.Add(addOrderLabel);
            addProductForm.Location = new Point(180, 40);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(457, 444);
            addProductForm.TabIndex = 1;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.ForeColor = Color.WhiteSmoke;
            totalAmount.Location = new Point(312, 317);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(34, 15);
            totalAmount.TabIndex = 17;
            totalAmount.Text = "$0.00";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(149, 367);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addOrderBtn
            // 
            addOrderBtn.BackColor = Color.Teal;
            addOrderBtn.FlatAppearance.BorderSize = 0;
            addOrderBtn.FlatStyle = FlatStyle.Flat;
            addOrderBtn.ForeColor = Color.WhiteSmoke;
            addOrderBtn.Location = new Point(251, 367);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Padding = new Padding(2);
            addOrderBtn.Size = new Size(95, 31);
            addOrderBtn.TabIndex = 15;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.UseVisualStyleBackColor = false;
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.ForeColor = Color.WhiteSmoke;
            totalLabel.Location = new Point(310, 298);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(36, 15);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = Color.WhiteSmoke;
            qtyLabel.Location = new Point(97, 224);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(53, 15);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Quantity";
            // 
            // qtyTxtbox
            // 
            qtyTxtbox.Location = new Point(97, 245);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(258, 23);
            qtyTxtbox.TabIndex = 5;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.ForeColor = Color.WhiteSmoke;
            productLabel.Location = new Point(95, 164);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 4;
            productLabel.Text = "Product";
            // 
            // productTxtbox
            // 
            productTxtbox.Location = new Point(95, 186);
            productTxtbox.Name = "productTxtbox";
            productTxtbox.Size = new Size(260, 23);
            productTxtbox.TabIndex = 3;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.ForeColor = Color.WhiteSmoke;
            supplierNameLabel.Location = new Point(95, 107);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(85, 15);
            supplierNameLabel.TabIndex = 2;
            supplierNameLabel.Text = "Supplier Name";
            // 
            // supplierNameTxtbox
            // 
            supplierNameTxtbox.Location = new Point(95, 129);
            supplierNameTxtbox.Name = "supplierNameTxtbox";
            supplierNameTxtbox.Size = new Size(260, 23);
            supplierNameTxtbox.TabIndex = 1;
            // 
            // addOrderLabel
            // 
            addOrderLabel.AutoSize = true;
            addOrderLabel.BackColor = Color.Transparent;
            addOrderLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            addOrderLabel.ForeColor = Color.WhiteSmoke;
            addOrderLabel.Location = new Point(149, 51);
            addOrderLabel.Name = "addOrderLabel";
            addOrderLabel.Size = new Size(145, 25);
            addOrderLabel.TabIndex = 0;
            addOrderLabel.Text = "Add New Order";
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOrder";
            panel1.ResumeLayout(false);
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel addProductForm;
        private Button cancelBtn;
        private Button addOrderBtn;
        private Label totalLabel;
        private Label qtyLabel;
        private TextBox qtyTxtbox;
        private Label productLabel;
        private TextBox productTxtbox;
        private Label supplierNameLabel;
        private TextBox supplierNameTxtbox;
        private Label addOrderLabel;
        private Label totalAmount;
    }
}