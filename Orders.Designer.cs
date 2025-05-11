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
            addProductForm = new Panel();
            supplierComboBox = new ComboBox();
            newOrderBtn = new Button();
            supplierNameLabel = new Label();
            orderLabel = new Label();
            label1 = new Label();
            label3 = new Label();
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
            ordersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersGridView.BackgroundColor = Color.WhiteSmoke;
            ordersGridView.BorderStyle = BorderStyle.None;
            ordersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ordersGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.EnableHeadersVisualStyles = false;
            ordersGridView.Location = new Point(57, 212);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersGridView.RowHeadersVisible = false;
            ordersGridView.ScrollBars = ScrollBars.Vertical;
            ordersGridView.ShowCellToolTips = false;
            ordersGridView.ShowEditingIcon = false;
            ordersGridView.Size = new Size(530, 482);
            ordersGridView.TabIndex = 1;
            // 
            // orderItemsGridView
            // 
            orderItemsGridView.AllowUserToAddRows = false;
            orderItemsGridView.AllowUserToDeleteRows = false;
            orderItemsGridView.AllowUserToResizeColumns = false;
            orderItemsGridView.AllowUserToResizeRows = false;
            orderItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemsGridView.BackgroundColor = Color.WhiteSmoke;
            orderItemsGridView.BorderStyle = BorderStyle.None;
            orderItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            orderItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.EnableHeadersVisualStyles = false;
            orderItemsGridView.Location = new Point(609, 212);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderItemsGridView.RowHeadersVisible = false;
            orderItemsGridView.ScrollBars = ScrollBars.Vertical;
            orderItemsGridView.ShowCellToolTips = false;
            orderItemsGridView.ShowEditingIcon = false;
            orderItemsGridView.Size = new Size(530, 482);
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
            ordersPanel.Size = new Size(1200, 750);
            ordersPanel.TabIndex = 4;
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(supplierComboBox);
            addProductForm.Controls.Add(newOrderBtn);
            addProductForm.Controls.Add(supplierNameLabel);
            addProductForm.Controls.Add(orderLabel);
            addProductForm.Location = new Point(57, 27);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(1082, 128);
            addProductForm.TabIndex = 8;
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(311, 82);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(364, 23);
            supplierComboBox.TabIndex = 7;
            // 
            // newOrderBtn
            // 
            newOrderBtn.BackColor = Color.Teal;
            newOrderBtn.FlatAppearance.BorderSize = 0;
            newOrderBtn.FlatStyle = FlatStyle.Flat;
            newOrderBtn.ForeColor = Color.WhiteSmoke;
            newOrderBtn.Location = new Point(692, 82);
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
            supplierNameLabel.Location = new Point(311, 60);
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
            orderLabel.Location = new Point(457, 21);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(145, 25);
            orderLabel.TabIndex = 0;
            orderLabel.Text = "Add New Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(609, 177);
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
            label3.Location = new Point(57, 177);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "Orders";
            // 
            // Orders
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 750);
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