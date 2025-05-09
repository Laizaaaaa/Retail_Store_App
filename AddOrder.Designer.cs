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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            addProductForm = new Panel();
            unitPriceAmount = new Label();
            unitPriceLabel = new Label();
            subtotalAmount = new Label();
            subtotalLabel = new Label();
            supplierLabel = new Label();
            addItemsLabel = new Label();
            saleItemsPanel = new Panel();
            cancelBtn = new Button();
            label8 = new Label();
            sendOrderBtn = new Button();
            label7 = new Label();
            orderItemsGridView = new DataGridView();
            addItemBtn = new Button();
            qtyLabel = new Label();
            qtyTxtbox = new TextBox();
            productLabel = new Label();
            productTxtbox = new TextBox();
            newOrderLabel = new Label();
            panel1 = new Panel();
            addProductForm.SuspendLayout();
            saleItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(unitPriceAmount);
            addProductForm.Controls.Add(unitPriceLabel);
            addProductForm.Controls.Add(subtotalAmount);
            addProductForm.Controls.Add(subtotalLabel);
            addProductForm.Controls.Add(supplierLabel);
            addProductForm.Controls.Add(addItemsLabel);
            addProductForm.Controls.Add(saleItemsPanel);
            addProductForm.Controls.Add(addItemBtn);
            addProductForm.Controls.Add(qtyLabel);
            addProductForm.Controls.Add(qtyTxtbox);
            addProductForm.Controls.Add(productLabel);
            addProductForm.Controls.Add(productTxtbox);
            addProductForm.Controls.Add(newOrderLabel);
            addProductForm.Location = new Point(34, 98);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(752, 444);
            addProductForm.TabIndex = 3;
            addProductForm.Paint += addProductForm_Paint;
            // 
            // unitPriceAmount
            // 
            unitPriceAmount.AutoSize = true;
            unitPriceAmount.ForeColor = Color.WhiteSmoke;
            unitPriceAmount.Location = new Point(218, 281);
            unitPriceAmount.Name = "unitPriceAmount";
            unitPriceAmount.Size = new Size(34, 15);
            unitPriceAmount.TabIndex = 25;
            unitPriceAmount.Text = "$0.00";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.ForeColor = SystemColors.Window;
            unitPriceLabel.Location = new Point(27, 279);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(58, 15);
            unitPriceLabel.TabIndex = 24;
            unitPriceLabel.Text = "Unit Price";
            // 
            // subtotalAmount
            // 
            subtotalAmount.AutoSize = true;
            subtotalAmount.ForeColor = Color.WhiteSmoke;
            subtotalAmount.Location = new Point(220, 306);
            subtotalAmount.Name = "subtotalAmount";
            subtotalAmount.Size = new Size(34, 15);
            subtotalAmount.TabIndex = 23;
            subtotalAmount.Text = "$0.00";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.ForeColor = Color.WhiteSmoke;
            subtotalLabel.Location = new Point(26, 304);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(54, 15);
            subtotalLabel.TabIndex = 22;
            subtotalLabel.Text = "Subtotal:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierLabel.ForeColor = Color.WhiteSmoke;
            supplierLabel.Location = new Point(29, 99);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(65, 17);
            supplierLabel.TabIndex = 20;
            supplierLabel.Text = "Supplier: ";
            // 
            // addItemsLabel
            // 
            addItemsLabel.AutoSize = true;
            addItemsLabel.BackColor = Color.Transparent;
            addItemsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            addItemsLabel.ForeColor = Color.WhiteSmoke;
            addItemsLabel.Location = new Point(117, 57);
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
            saleItemsPanel.Controls.Add(sendOrderBtn);
            saleItemsPanel.Controls.Add(label7);
            saleItemsPanel.Controls.Add(orderItemsGridView);
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
            cancelBtn.Location = new Point(227, 384);
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
            // sendOrderBtn
            // 
            sendOrderBtn.BackColor = Color.Teal;
            sendOrderBtn.FlatAppearance.BorderSize = 0;
            sendOrderBtn.FlatStyle = FlatStyle.Flat;
            sendOrderBtn.ForeColor = Color.WhiteSmoke;
            sendOrderBtn.Location = new Point(328, 384);
            sendOrderBtn.Name = "sendOrderBtn";
            sendOrderBtn.Padding = new Padding(2);
            sendOrderBtn.Size = new Size(107, 31);
            sendOrderBtn.TabIndex = 20;
            sendOrderBtn.Text = "Send Order";
            sendOrderBtn.UseVisualStyleBackColor = false;
            sendOrderBtn.Click += sendOrderBtn_Click;
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
            // orderItemsGridView
            // 
            orderItemsGridView.AllowUserToAddRows = false;
            orderItemsGridView.AllowUserToDeleteRows = false;
            orderItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemsGridView.BackgroundColor = SystemColors.ControlLightLight;
            orderItemsGridView.BorderStyle = BorderStyle.None;
            orderItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            orderItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            orderItemsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            orderItemsGridView.EnableHeadersVisualStyles = false;
            orderItemsGridView.Location = new Point(22, 55);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            orderItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderItemsGridView.RowHeadersVisible = false;
            orderItemsGridView.ShowCellToolTips = false;
            orderItemsGridView.Size = new Size(413, 309);
            orderItemsGridView.TabIndex = 24;
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Teal;
            addItemBtn.FlatAppearance.BorderSize = 0;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.ForeColor = Color.WhiteSmoke;
            addItemBtn.Location = new Point(161, 349);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Padding = new Padding(2);
            addItemBtn.Size = new Size(95, 31);
            addItemBtn.TabIndex = 15;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = Color.WhiteSmoke;
            qtyLabel.Location = new Point(27, 198);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(53, 15);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Quantity";
            // 
            // qtyTxtbox
            // 
            qtyTxtbox.Location = new Point(27, 219);
            qtyTxtbox.Name = "qtyTxtbox";
            qtyTxtbox.Size = new Size(227, 23);
            qtyTxtbox.TabIndex = 5;
            qtyTxtbox.TextChanged += qtyTxtbox_TextChanged;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.ForeColor = Color.WhiteSmoke;
            productLabel.Location = new Point(27, 137);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 4;
            productLabel.Text = "Product";
            // 
            // productTxtbox
            // 
            productTxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productTxtbox.Location = new Point(27, 161);
            productTxtbox.Name = "productTxtbox";
            productTxtbox.Size = new Size(229, 23);
            productTxtbox.TabIndex = 3;
            productTxtbox.Leave += productTxtbox_Leave;
            // 
            // newOrderLabel
            // 
            newOrderLabel.AutoSize = true;
            newOrderLabel.BackColor = Color.Transparent;
            newOrderLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            newOrderLabel.ForeColor = Color.WhiteSmoke;
            newOrderLabel.Location = new Point(93, 23);
            newOrderLabel.Name = "newOrderLabel";
            newOrderLabel.Size = new Size(105, 25);
            newOrderLabel.TabIndex = 0;
            newOrderLabel.Text = "New Order";
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
            Load += AddOrder_Load;
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            saleItemsPanel.ResumeLayout(false);
            saleItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label supplierLabel;
        private Label addItemsLabel;
        private Panel saleItemsPanel;
        private Button cancelBtn;
        private Label label8;
        private Button sendOrderBtn;
        private Label label7;
        private DataGridView orderItemsGridView;
        private Button addItemBtn;
        private Label qtyLabel;
        private TextBox qtyTxtbox;
        private Label productLabel;
        private TextBox productTxtbox;
        private Label newOrderLabel;
        private Panel panel1;
        private Label unitPriceAmount;
        private Label unitPriceLabel;
        private Label subtotalAmount;
        private Label subtotalLabel;
    }
}