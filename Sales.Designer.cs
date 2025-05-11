namespace EDP
{
    partial class Sales
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
            salesGridView = new DataGridView();
            saleItemsGridView = new DataGridView();
            salesPanel = new Panel();
            newTransactionBtn = new Button();
            label3 = new Label();
            saleTransactionsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)salesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).BeginInit();
            salesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // salesGridView
            // 
            salesGridView.AllowUserToAddRows = false;
            salesGridView.AllowUserToDeleteRows = false;
            salesGridView.AllowUserToResizeColumns = false;
            salesGridView.AllowUserToResizeRows = false;
            salesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesGridView.BackgroundColor = Color.WhiteSmoke;
            salesGridView.BorderStyle = BorderStyle.None;
            salesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            salesGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            salesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGridView.EnableHeadersVisualStyles = false;
            salesGridView.Location = new Point(48, 104);
            salesGridView.Name = "salesGridView";
            salesGridView.RowHeadersVisible = false;
            salesGridView.Size = new Size(535, 575);
            salesGridView.TabIndex = 0;
            // 
            // saleItemsGridView
            // 
            saleItemsGridView.AllowUserToAddRows = false;
            saleItemsGridView.AllowUserToDeleteRows = false;
            saleItemsGridView.AllowUserToResizeColumns = false;
            saleItemsGridView.AllowUserToResizeRows = false;
            saleItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            saleItemsGridView.BackgroundColor = Color.WhiteSmoke;
            saleItemsGridView.BorderStyle = BorderStyle.None;
            saleItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            saleItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            saleItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemsGridView.EnableHeadersVisualStyles = false;
            saleItemsGridView.Location = new Point(613, 104);
            saleItemsGridView.Name = "saleItemsGridView";
            saleItemsGridView.ReadOnly = true;
            saleItemsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            saleItemsGridView.RowHeadersVisible = false;
            saleItemsGridView.ScrollBars = ScrollBars.Vertical;
            saleItemsGridView.ShowCellToolTips = false;
            saleItemsGridView.ShowEditingIcon = false;
            saleItemsGridView.Size = new Size(535, 575);
            saleItemsGridView.TabIndex = 1;
            // 
            // salesPanel
            // 
            salesPanel.BackColor = Color.FromArgb(0, 64, 64);
            salesPanel.Controls.Add(newTransactionBtn);
            salesPanel.Controls.Add(saleItemsGridView);
            salesPanel.Controls.Add(label3);
            salesPanel.Controls.Add(salesGridView);
            salesPanel.Controls.Add(saleTransactionsLabel);
            salesPanel.Dock = DockStyle.Fill;
            salesPanel.Location = new Point(0, 0);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(1200, 750);
            salesPanel.TabIndex = 4;
            // 
            // newTransactionBtn
            // 
            newTransactionBtn.BackColor = Color.Teal;
            newTransactionBtn.FlatAppearance.BorderSize = 0;
            newTransactionBtn.FlatStyle = FlatStyle.Flat;
            newTransactionBtn.ForeColor = Color.WhiteSmoke;
            newTransactionBtn.Location = new Point(455, 56);
            newTransactionBtn.Name = "newTransactionBtn";
            newTransactionBtn.Padding = new Padding(1);
            newTransactionBtn.Size = new Size(128, 32);
            newTransactionBtn.TabIndex = 8;
            newTransactionBtn.Text = "New Transaction";
            newTransactionBtn.UseVisualStyleBackColor = false;
            newTransactionBtn.Click += newTransactionBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(613, 56);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 7;
            label3.Text = "Sale Items";
            // 
            // saleTransactionsLabel
            // 
            saleTransactionsLabel.AutoSize = true;
            saleTransactionsLabel.BackColor = Color.Transparent;
            saleTransactionsLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            saleTransactionsLabel.ForeColor = Color.White;
            saleTransactionsLabel.Location = new Point(48, 56);
            saleTransactionsLabel.Name = "saleTransactionsLabel";
            saleTransactionsLabel.Size = new Size(200, 32);
            saleTransactionsLabel.TabIndex = 6;
            saleTransactionsLabel.Text = "Sale Transactions";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(salesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ((System.ComponentModel.ISupportInitialize)salesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).EndInit();
            salesPanel.ResumeLayout(false);
            salesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView salesGridView;
        private DataGridView saleItemsGridView;
        private Panel salesPanel;
        private Label saleTransactionsLabel;
        private Label label3;
        private Button newTransactionBtn;
    }
}