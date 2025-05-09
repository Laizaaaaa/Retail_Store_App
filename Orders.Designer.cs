namespace EDP
{
    partial class Orders
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
            ordersGridView = new DataGridView();
            orderItemsGridView = new DataGridView();
            ordersPanel = new Panel();
            label1 = new Label();
            label3 = new Label();
            addProductForm = new Panel();
            newOrderBtn = new Button();
            supplierNameLabel = new Label();
            orderLabel = new Label();
            supplierComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            ordersPanel.SuspendLayout();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.AllowUserToAddRows = false;
            ordersGridView.AllowUserToDeleteRows = false;
            ordersGridView.AllowUserToResizeColumns = false;
            ordersGridView.AllowUserToResizeRows = false;
            ordersGridView.BackgroundColor = Color.WhiteSmoke;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(33, 210);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersVisible = false;
            ordersGridView.Size = new Size(364, 400);
            ordersGridView.TabIndex = 1;
            // 
            // orderItemsGridView
            // 
            orderItemsGridView.AllowUserToAddRows = false;
            orderItemsGridView.AllowUserToDeleteRows = false;
            orderItemsGridView.AllowUserToResizeColumns = false;
            orderItemsGridView.AllowUserToResizeRows = false;
            orderItemsGridView.BackgroundColor = Color.WhiteSmoke;
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.Location = new Point(421, 210);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersVisible = false;
            orderItemsGridView.Size = new Size(364, 400);
            orderItemsGridView.TabIndex = 2;
            // 
            // ordersPanel
            // 
            ordersPanel.BackColor = Color.FromArgb(0, 64, 64);
            ordersPanel.Controls.Add(addProductForm);
            ordersPanel.Controls.Add(label1);
            ordersPanel.Controls.Add(label3);
            ordersPanel.Controls.Add(orderItemsGridView);
            ordersPanel.Controls.Add(ordersGridView);
            ordersPanel.Dock = DockStyle.Fill;
            ordersPanel.Location = new Point(0, 0);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(820, 640);
            ordersPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 175);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 5;
            label1.Text = "Order Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 175);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "Orders";
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(supplierComboBox);
            addProductForm.Controls.Add(newOrderBtn);
            addProductForm.Controls.Add(supplierNameLabel);
            addProductForm.Controls.Add(orderLabel);
            addProductForm.Location = new Point(33, 27);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(752, 128);
            addProductForm.TabIndex = 8;
            // 
            // newOrderBtn
            // 
            newOrderBtn.BackColor = Color.Teal;
            newOrderBtn.FlatAppearance.BorderSize = 0;
            newOrderBtn.FlatStyle = FlatStyle.Flat;
            newOrderBtn.ForeColor = Color.WhiteSmoke;
            newOrderBtn.Location = new Point(528, 78);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(94, 23);
            newOrderBtn.TabIndex = 6;
            newOrderBtn.Text = "New Order";
            newOrderBtn.UseVisualStyleBackColor = false;
            newOrderBtn.Click += newOrderBtn_Click;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.ForeColor = Color.WhiteSmoke;
            supplierNameLabel.Location = new Point(147, 56);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(85, 15);
            supplierNameLabel.TabIndex = 2;
            supplierNameLabel.Text = "Supplier Name";
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.BackColor = Color.Transparent;
            orderLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            orderLabel.ForeColor = Color.WhiteSmoke;
            orderLabel.Location = new Point(293, 17);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(145, 25);
            orderLabel.TabIndex = 0;
            orderLabel.Text = "Add New Order";
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(147, 78);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(364, 23);
            supplierComboBox.TabIndex = 7;
            // 
            // Orders
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(820, 640);
            Controls.Add(ordersPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            ordersPanel.ResumeLayout(false);
            ordersPanel.PerformLayout();
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ordersGridView;
        private DataGridView orderItemsGridView;
        private Panel ordersPanel;
        private Label label1;
        private Label label3;
        private Panel addProductForm;
        private ComboBox supplierComboBox;
        private Button newOrderBtn;
        private Label supplierNameLabel;
        private Label orderLabel;
    }
}