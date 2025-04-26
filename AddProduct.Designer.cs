namespace EDP
{
    partial class AddProduct
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
            cancelBtn = new Button();
            addProductBtn = new Button();
            supplierLabel = new Label();
            textBox3 = new TextBox();
            stockLabel = new Label();
            textBox1 = new TextBox();
            netWeightLabel = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            retailPriceTxtbox = new TextBox();
            unitPriceLabel = new Label();
            unitPriceTxtbox = new TextBox();
            categoryLabel = new Label();
            categoryTxtbox = new TextBox();
            ProductNameLabel = new Label();
            productNameTxtbox = new TextBox();
            addProductLabel = new Label();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(cancelBtn);
            addProductForm.Controls.Add(addProductBtn);
            addProductForm.Controls.Add(supplierLabel);
            addProductForm.Controls.Add(textBox3);
            addProductForm.Controls.Add(stockLabel);
            addProductForm.Controls.Add(textBox1);
            addProductForm.Controls.Add(netWeightLabel);
            addProductForm.Controls.Add(textBox2);
            addProductForm.Controls.Add(label2);
            addProductForm.Controls.Add(retailPriceTxtbox);
            addProductForm.Controls.Add(unitPriceLabel);
            addProductForm.Controls.Add(unitPriceTxtbox);
            addProductForm.Controls.Add(categoryLabel);
            addProductForm.Controls.Add(categoryTxtbox);
            addProductForm.Controls.Add(ProductNameLabel);
            addProductForm.Controls.Add(productNameTxtbox);
            addProductForm.Controls.Add(addProductLabel);
            addProductForm.Location = new Point(183, 49);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(454, 520);
            addProductForm.TabIndex = 0;
            addProductForm.Paint += addProductForm_Paint;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(211, 437);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.Teal;
            addProductBtn.FlatAppearance.BorderSize = 0;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.ForeColor = Color.WhiteSmoke;
            addProductBtn.Location = new Point(313, 437);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Padding = new Padding(2);
            addProductBtn.Size = new Size(95, 31);
            addProductBtn.TabIndex = 15;
            addProductBtn.Text = "Add Product";
            addProductBtn.UseVisualStyleBackColor = false;
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.ForeColor = Color.WhiteSmoke;
            supplierLabel.Location = new Point(50, 350);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(50, 15);
            supplierLabel.TabIndex = 14;
            supplierLabel.Text = "Supplier";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 372);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 23);
            textBox3.TabIndex = 13;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.ForeColor = Color.WhiteSmoke;
            stockLabel.Location = new Point(241, 292);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(36, 15);
            stockLabel.TabIndex = 12;
            stockLabel.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 11;
            // 
            // netWeightLabel
            // 
            netWeightLabel.AutoSize = true;
            netWeightLabel.ForeColor = Color.WhiteSmoke;
            netWeightLabel.Location = new Point(50, 292);
            netWeightLabel.Name = "netWeightLabel";
            netWeightLabel.Size = new Size(67, 15);
            netWeightLabel.TabIndex = 10;
            netWeightLabel.Text = "Net Weight";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 314);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(241, 234);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Retail Price";
            // 
            // retailPriceTxtbox
            // 
            retailPriceTxtbox.Location = new Point(241, 256);
            retailPriceTxtbox.Name = "retailPriceTxtbox";
            retailPriceTxtbox.Size = new Size(167, 23);
            retailPriceTxtbox.TabIndex = 7;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.ForeColor = Color.WhiteSmoke;
            unitPriceLabel.Location = new Point(50, 234);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(58, 15);
            unitPriceLabel.TabIndex = 6;
            unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceTxtbox
            // 
            unitPriceTxtbox.Location = new Point(50, 256);
            unitPriceTxtbox.Name = "unitPriceTxtbox";
            unitPriceTxtbox.Size = new Size(167, 23);
            unitPriceTxtbox.TabIndex = 5;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.ForeColor = Color.WhiteSmoke;
            categoryLabel.Location = new Point(50, 182);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(55, 15);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // categoryTxtbox
            // 
            categoryTxtbox.Location = new Point(50, 204);
            categoryTxtbox.Name = "categoryTxtbox";
            categoryTxtbox.Size = new Size(358, 23);
            categoryTxtbox.TabIndex = 3;
            categoryTxtbox.TextChanged += categoryTxtbox_TextChanged;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.ForeColor = Color.WhiteSmoke;
            ProductNameLabel.Location = new Point(50, 130);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(84, 15);
            ProductNameLabel.TabIndex = 2;
            ProductNameLabel.Text = "Product Name";
            // 
            // productNameTxtbox
            // 
            productNameTxtbox.Location = new Point(50, 152);
            productNameTxtbox.Name = "productNameTxtbox";
            productNameTxtbox.Size = new Size(358, 23);
            productNameTxtbox.TabIndex = 1;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.BackColor = Color.Transparent;
            addProductLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            addProductLabel.ForeColor = Color.WhiteSmoke;
            addProductLabel.Location = new Point(152, 70);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(163, 25);
            addProductLabel.TabIndex = 0;
            addProductLabel.Text = "Add New Product";
            // 
            // AddProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(addProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label addProductLabel;
        private Label ProductNameLabel;
        private TextBox productNameTxtbox;
        private Label label2;
        private TextBox retailPriceTxtbox;
        private Label unitPriceLabel;
        private TextBox unitPriceTxtbox;
        private Label categoryLabel;
        private TextBox categoryTxtbox;
        private Label supplierLabel;
        private TextBox textBox3;
        private Label stockLabel;
        private TextBox textBox1;
        private Label netWeightLabel;
        private TextBox textBox2;
        private Button addProductBtn;
        private Button cancelBtn;
    }
}