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
            supplierComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            cancelBtn = new Button();
            addProductBtn = new Button();
            supplierLabel = new Label();
            stockLabel = new Label();
            stockTxtbox = new TextBox();
            netWeightLabel = new Label();
            netWeightTxtbox = new TextBox();
            label2 = new Label();
            markupPercentTxtbox = new TextBox();
            unitPriceLabel = new Label();
            unitPriceTxtbox = new TextBox();
            categoryLabel = new Label();
            ProductNameLabel = new Label();
            productNameTxtbox = new TextBox();
            addProductLabel = new Label();
            label1 = new Label();
            unitComboBox = new ComboBox();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(unitComboBox);
            addProductForm.Controls.Add(label1);
            addProductForm.Controls.Add(supplierComboBox);
            addProductForm.Controls.Add(categoryComboBox);
            addProductForm.Controls.Add(cancelBtn);
            addProductForm.Controls.Add(addProductBtn);
            addProductForm.Controls.Add(supplierLabel);
            addProductForm.Controls.Add(stockLabel);
            addProductForm.Controls.Add(stockTxtbox);
            addProductForm.Controls.Add(netWeightLabel);
            addProductForm.Controls.Add(netWeightTxtbox);
            addProductForm.Controls.Add(label2);
            addProductForm.Controls.Add(markupPercentTxtbox);
            addProductForm.Controls.Add(unitPriceLabel);
            addProductForm.Controls.Add(unitPriceTxtbox);
            addProductForm.Controls.Add(categoryLabel);
            addProductForm.Controls.Add(ProductNameLabel);
            addProductForm.Controls.Add(productNameTxtbox);
            addProductForm.Controls.Add(addProductLabel);
            addProductForm.Location = new Point(183, 49);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(454, 520);
            addProductForm.TabIndex = 0;
            addProductForm.Paint += addProductForm_Paint;
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(50, 370);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(358, 23);
            supplierComboBox.TabIndex = 18;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(50, 204);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(358, 23);
            categoryComboBox.TabIndex = 17;
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
            addProductBtn.Click += addProductBtn_Click;
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
            // stockTxtbox
            // 
            stockTxtbox.Location = new Point(241, 314);
            stockTxtbox.Name = "stockTxtbox";
            stockTxtbox.Size = new Size(167, 23);
            stockTxtbox.TabIndex = 11;
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
            // netWeightTxtbox
            // 
            netWeightTxtbox.Location = new Point(50, 314);
            netWeightTxtbox.Name = "netWeightTxtbox";
            netWeightTxtbox.Size = new Size(167, 23);
            netWeightTxtbox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(297, 234);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Markup Percent";
            // 
            // markupPercentTxtbox
            // 
            markupPercentTxtbox.Location = new Point(297, 256);
            markupPercentTxtbox.Name = "markupPercentTxtbox";
            markupPercentTxtbox.PlaceholderText = "ex: 15 for 15%";
            markupPercentTxtbox.Size = new Size(111, 23);
            markupPercentTxtbox.TabIndex = 7;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.ForeColor = Color.WhiteSmoke;
            unitPriceLabel.Location = new Point(176, 234);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(58, 15);
            unitPriceLabel.TabIndex = 6;
            unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceTxtbox
            // 
            unitPriceTxtbox.Location = new Point(176, 256);
            unitPriceTxtbox.Name = "unitPriceTxtbox";
            unitPriceTxtbox.Size = new Size(111, 23);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(50, 234);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 20;
            label1.Text = "Unit";
            // 
            // unitComboBox
            // 
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(50, 256);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(119, 23);
            unitComboBox.TabIndex = 21;
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
        private TextBox markupPercentTxtbox;
        private Label unitPriceLabel;
        private TextBox unitPriceTxtbox;
        private Label categoryLabel;
        private Label supplierLabel;
        private Label stockLabel;
        private TextBox stockTxtbox;
        private Label netWeightLabel;
        private TextBox netWeightTxtbox;
        private Button addProductBtn;
        private Button cancelBtn;
        private ComboBox supplierComboBox;
        private ComboBox categoryComboBox;
        private ComboBox unitComboBox;
        private Label label1;
    }
}