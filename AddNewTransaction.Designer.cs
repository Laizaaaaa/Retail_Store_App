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
            addProductForm = new Panel();
            addItemsLabel = new Label();
            saleItemsPanel = new Panel();
            label8 = new Label();
            completeTransaction = new Button();
            label7 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            totalAmount = new Label();
            addItemBtn = new Button();
            subtotalLabel = new Label();
            qtyLabel = new Label();
            qtyTxtbox = new TextBox();
            productLabel = new Label();
            productTxtbox = new TextBox();
            newTransactionLabel = new Label();
            cancelBtn = new Button();
            addProductForm.SuspendLayout();
            saleItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(addItemsLabel);
            addProductForm.Controls.Add(saleItemsPanel);
            addProductForm.Controls.Add(totalAmount);
            addProductForm.Controls.Add(addItemBtn);
            addProductForm.Controls.Add(subtotalLabel);
            addProductForm.Controls.Add(qtyLabel);
            addProductForm.Controls.Add(qtyTxtbox);
            addProductForm.Controls.Add(productLabel);
            addProductForm.Controls.Add(productTxtbox);
            addProductForm.Controls.Add(newTransactionLabel);
            addProductForm.Location = new Point(37, 71);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(718, 444);
            addProductForm.TabIndex = 2;
            // 
            // addItemsLabel
            // 
            addItemsLabel.AutoSize = true;
            addItemsLabel.BackColor = Color.Transparent;
            addItemsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addItemsLabel.ForeColor = Color.WhiteSmoke;
            addItemsLabel.Location = new Point(165, 80);
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
            saleItemsPanel.Controls.Add(label5);
            saleItemsPanel.Controls.Add(dataGridView1);
            saleItemsPanel.Controls.Add(label6);
            saleItemsPanel.Controls.Add(label4);
            saleItemsPanel.Controls.Add(label3);
            saleItemsPanel.Controls.Add(label2);
            saleItemsPanel.Controls.Add(label1);
            saleItemsPanel.Dock = DockStyle.Right;
            saleItemsPanel.Location = new Point(407, 0);
            saleItemsPanel.Name = "saleItemsPanel";
            saleItemsPanel.Size = new Size(311, 444);
            saleItemsPanel.TabIndex = 18;
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
            completeTransaction.Location = new Point(123, 384);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(258, 348);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 21;
            label5.Text = "$0.00";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(270, 253);
            dataGridView1.TabIndex = 24;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(171, 55);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 23;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(240, 55);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 22;
            label3.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(107, 55);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 21;
            label2.Text = "Qty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 20;
            label1.Text = "Product";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.ForeColor = Color.WhiteSmoke;
            totalAmount.Location = new Point(293, 288);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(34, 15);
            totalAmount.TabIndex = 17;
            totalAmount.Text = "$0.00";
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Teal;
            addItemBtn.FlatAppearance.BorderSize = 0;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.ForeColor = Color.WhiteSmoke;
            addItemBtn.Location = new Point(232, 336);
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
            subtotalLabel.Location = new Point(273, 271);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(54, 15);
            subtotalLabel.TabIndex = 8;
            subtotalLabel.Text = "Subtotal:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = Color.WhiteSmoke;
            qtyLabel.Location = new Point(69, 203);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(53, 15);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Quantity";
            // 
            // qtyTxtbox
            // 
            qtyTxtbox.Location = new Point(69, 224);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(258, 23);
            qtyTxtbox.TabIndex = 5;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.ForeColor = Color.WhiteSmoke;
            productLabel.Location = new Point(69, 140);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 4;
            productLabel.Text = "Product";
            // 
            // productTxtbox
            // 
            productTxtbox.Location = new Point(69, 162);
            productTxtbox.Name = "productTxtbox";
            productTxtbox.Size = new Size(260, 23);
            productTxtbox.TabIndex = 3;
            // 
            // newTransactionLabel
            // 
            newTransactionLabel.AutoSize = true;
            newTransactionLabel.BackColor = Color.Transparent;
            newTransactionLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            newTransactionLabel.ForeColor = Color.WhiteSmoke;
            newTransactionLabel.Location = new Point(132, 55);
            newTransactionLabel.Name = "newTransactionLabel";
            newTransactionLabel.Size = new Size(153, 25);
            newTransactionLabel.TabIndex = 0;
            newTransactionLabel.Text = "New Transaction";
            newTransactionLabel.Click += newTransactionLabel_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkSlateGray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.WhiteSmoke;
            cancelBtn.Location = new Point(22, 384);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Padding = new Padding(2);
            cancelBtn.Size = new Size(95, 31);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
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
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            saleItemsPanel.ResumeLayout(false);
            saleItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label totalAmount;
        private Button addItemBtn;
        private Label subtotalLabel;
        private Label qtyLabel;
        private TextBox qtyTxtbox;
        private Label productLabel;
        private TextBox productTxtbox;
        private Label newTransactionLabel;
        private Panel saleItemsPanel;
        private Label addItemsLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label4;
        private Button completeTransaction;
        private Button cancelBtn;
    }
}