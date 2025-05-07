namespace EDP
{
    partial class AddNewTransaction
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            addProductForm = new Panel();
            retailPriceAmount = new Label();
            retailPriceeLabel = new Label();
            addItemsLabel = new Label();
            saleItemsPanel = new Panel();
            cancelBtn = new Button();
            label8 = new Label();
            completeTransaction = new Button();
            label7 = new Label();
            totalAmount = new Label();
            saleItemsGridView = new DataGridView();
            label6 = new Label();
            subtotalAmount = new Label();
            addItemBtn = new Button();
            subtotalLabel = new Label();
            qtyLabel = new Label();
            qtyTxtbox = new TextBox();
            productLabel = new Label();
            productTxtbox = new TextBox();
            newTransactionLabel = new Label();
            addProductForm.SuspendLayout();
            saleItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).BeginInit();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(retailPriceAmount);
            addProductForm.Controls.Add(retailPriceeLabel);
            addProductForm.Controls.Add(addItemsLabel);
            addProductForm.Controls.Add(saleItemsPanel);
            addProductForm.Controls.Add(subtotalAmount);
            addProductForm.Controls.Add(addItemBtn);
            addProductForm.Controls.Add(subtotalLabel);
            addProductForm.Controls.Add(qtyLabel);
            addProductForm.Controls.Add(qtyTxtbox);
            addProductForm.Controls.Add(productLabel);
            addProductForm.Controls.Add(productTxtbox);
            addProductForm.Controls.Add(newTransactionLabel);
            addProductForm.Location = new Point(37, 71);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(752, 444);
            addProductForm.TabIndex = 2;
            addProductForm.Paint += addProductForm_Paint;
            // 
            // retailPriceAmount
            // 
            retailPriceAmount.AutoSize = true;
            retailPriceAmount.ForeColor = Color.WhiteSmoke;
            retailPriceAmount.Location = new Point(220, 281);
            retailPriceAmount.Name = "retailPriceAmount";
            retailPriceAmount.Size = new Size(34, 15);
            retailPriceAmount.TabIndex = 21;
            retailPriceAmount.Text = "$0.00";
            // 
            // retailPriceeLabel
            // 
            retailPriceeLabel.AutoSize = true;
            retailPriceeLabel.ForeColor = SystemColors.Window;
            retailPriceeLabel.Location = new Point(29, 279);
            retailPriceeLabel.Name = "retailPriceeLabel";
            retailPriceeLabel.Size = new Size(65, 15);
            retailPriceeLabel.TabIndex = 20;
            retailPriceeLabel.Text = "Retail Price";
            // 
            // addItemsLabel
            // 
            addItemsLabel.AutoSize = true;
            addItemsLabel.BackColor = Color.Transparent;
            addItemsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addItemsLabel.ForeColor = Color.WhiteSmoke;
            addItemsLabel.Location = new Point(103, 70);
            addItemsLabel.Name = "addItemsLabel";
            addItemsLabel.Size = new Size(62, 15);
            addItemsLabel.TabIndex = 19;
            addItemsLabel.Text = "Add Items";
            // 
            // saleItemsPanel
            // 
            saleItemsPanel.BackColor = Color.Snow;
            saleItemsPanel.Controls.Add(cancelBtn);
            saleItemsPanel.Controls.Add(label8);
            saleItemsPanel.Controls.Add(completeTransaction);
            saleItemsPanel.Controls.Add(label7);
            saleItemsPanel.Controls.Add(totalAmount);
            saleItemsPanel.Controls.Add(saleItemsGridView);
            saleItemsPanel.Controls.Add(label6);
            saleItemsPanel.Dock = DockStyle.Right;
            saleItemsPanel.Location = new Point(298, 0);
            saleItemsPanel.Name = "saleItemsPanel";
            saleItemsPanel.Size = new Size(454, 444);
            saleItemsPanel.TabIndex = 18;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(165, 384);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(218, 21);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 26;
            label8.Text = "1092837892";
            // 
            // completeTransaction
            // 
            completeTransaction.BackColor = Color.Teal;
            completeTransaction.FlatAppearance.BorderSize = 0;
            completeTransaction.FlatStyle = FlatStyle.Flat;
            completeTransaction.ForeColor = Color.WhiteSmoke;
            completeTransaction.Location = new Point(266, 384);
            completeTransaction.Name = "completeTransaction";
            completeTransaction.Padding = new Padding(2);
            completeTransaction.Size = new Size(169, 31);
            completeTransaction.TabIndex = 20;
            completeTransaction.Text = "Complete Transaction";
            completeTransaction.UseVisualStyleBackColor = false;
            completeTransaction.Click += completeTransaction_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(22, 21);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 25;
            label7.Text = "01/01/25";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.ForeColor = Color.Black;
            totalAmount.Location = new Point(401, 348);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(34, 15);
            totalAmount.TabIndex = 21;
            totalAmount.Text = "$0.00";
            // 
            // saleItemsGridView
            // 
            saleItemsGridView.AllowUserToAddRows = false;
            saleItemsGridView.AllowUserToDeleteRows = false;
            saleItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            saleItemsGridView.BackgroundColor = SystemColors.ControlLightLight;
            saleItemsGridView.BorderStyle = BorderStyle.None;
            saleItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            saleItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            saleItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            saleItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            saleItemsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            saleItemsGridView.EnableHeadersVisualStyles = false;
            saleItemsGridView.Location = new Point(22, 45);
            saleItemsGridView.Name = "saleItemsGridView";
            saleItemsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            saleItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            saleItemsGridView.RowHeadersVisible = false;
            saleItemsGridView.ShowCellToolTips = false;
            saleItemsGridView.Size = new Size(413, 288);
            saleItemsGridView.TabIndex = 24;
            saleItemsGridView.CellContentClick += saleItemsGridView_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(22, 348);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 20;
            label6.Text = "Total:";
            // 
            // subtotalAmount
            // 
            subtotalAmount.AutoSize = true;
            subtotalAmount.ForeColor = Color.WhiteSmoke;
            subtotalAmount.Location = new Point(222, 319);
            subtotalAmount.Name = "subtotalAmount";
            subtotalAmount.Size = new Size(34, 15);
            subtotalAmount.TabIndex = 17;
            subtotalAmount.Text = "$0.00";
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Teal;
            addItemBtn.FlatAppearance.BorderSize = 0;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.ForeColor = Color.WhiteSmoke;
            addItemBtn.Location = new Point(161, 369);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Padding = new Padding(2);
            addItemBtn.Size = new Size(95, 31);
            addItemBtn.TabIndex = 15;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.ForeColor = Color.WhiteSmoke;
            subtotalLabel.Location = new Point(28, 317);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(54, 15);
            subtotalLabel.TabIndex = 8;
            subtotalLabel.Text = "Subtotal:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = Color.WhiteSmoke;
            qtyLabel.Location = new Point(29, 202);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(53, 15);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Quantity";
            // 
            // qtyTxtbox
            // 
            qtyTxtbox.Location = new Point(29, 223);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(227, 23);
            qtyTxtbox.TabIndex = 5;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.ForeColor = Color.WhiteSmoke;
            productLabel.Location = new Point(29, 139);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 4;
            productLabel.Text = "Product";
            // 
            // productTxtbox
            // 
            productTxtbox.Location = new Point(29, 161);
            productTxtbox.Name = "productTxtbox";
            productTxtbox.Size = new Size(229, 23);
            productTxtbox.TabIndex = 3;
            // 
            // newTransactionLabel
            // 
            newTransactionLabel.AutoSize = true;
            newTransactionLabel.BackColor = Color.Transparent;
            newTransactionLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            newTransactionLabel.ForeColor = Color.WhiteSmoke;
            newTransactionLabel.Location = new Point(70, 45);
            newTransactionLabel.Name = "newTransactionLabel";
            newTransactionLabel.Size = new Size(153, 25);
            newTransactionLabel.TabIndex = 0;
            newTransactionLabel.Text = "New Transaction";
            // 
            // AddNewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(addProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewTransaction";
            StartPosition = FormStartPosition.Manual;
            Text = "AddNewTransaction";
            Load += AddNewTransaction_Load;
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            saleItemsPanel.ResumeLayout(false);
            saleItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label subtotalAmount;
        private Button addItemBtn;
        private Label subtotalLabel;
        private Label qtyLabel;
        private TextBox qtyTxtbox;
        private Label productLabel;
        private TextBox productTxtbox;
        private Label newTransactionLabel;
        private Panel saleItemsPanel;
        private Label addItemsLabel;
        private Label label8;
        private Label label7;
        private Label totalAmount;
        private DataGridView saleItemsGridView;
        private Label label6;
        private Button completeTransaction;
        private Button cancelBtn;
        private Label retailPriceAmount;
        private Label retailPriceeLabel;
    }
}