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
            label1 = new Label();
            label3 = new Label();
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
            salesGridView.BackgroundColor = Color.WhiteSmoke;
            salesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGridView.Location = new Point(21, 84);
            salesGridView.Name = "salesGridView";
            salesGridView.RowHeadersVisible = false;
            salesGridView.Size = new Size(340, 380);
            salesGridView.TabIndex = 0;
            // 
            // saleItemsGridView
            // 
            saleItemsGridView.AllowUserToAddRows = false;
            saleItemsGridView.AllowUserToDeleteRows = false;
            saleItemsGridView.AllowUserToResizeColumns = false;
            saleItemsGridView.AllowUserToResizeRows = false;
            saleItemsGridView.BackgroundColor = Color.WhiteSmoke;
            saleItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemsGridView.Location = new Point(367, 84);
            saleItemsGridView.Name = "saleItemsGridView";
            saleItemsGridView.RowHeadersVisible = false;
            saleItemsGridView.Size = new Size(340, 380);
            saleItemsGridView.TabIndex = 1;
            // 
            // salesPanel
            // 
            salesPanel.Controls.Add(label3);
            salesPanel.Controls.Add(label1);
            salesPanel.Dock = DockStyle.Fill;
            salesPanel.Location = new Point(0, 0);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(730, 510);
            salesPanel.TabIndex = 4;
            salesPanel.Paint += salesPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 44);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 6;
            label1.Text = "Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(511, 44);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Sale Items";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(saleItemsGridView);
            Controls.Add(salesGridView);
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
        private Label label1;
        private Label label3;
    }
}