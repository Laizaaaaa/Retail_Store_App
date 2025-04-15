namespace EDP
{
    partial class Inventory
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
            inventoryPanel = new Panel();
            label1 = new Label();
            productsGridView = new DataGridView();
            inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            SuspendLayout();
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(label1);
            inventoryPanel.Controls.Add(productsGridView);
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Location = new Point(0, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(730, 510);
            inventoryPanel.TabIndex = 0;
            inventoryPanel.Paint += inventoryPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(329, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.AllowUserToResizeColumns = false;
            productsGridView.AllowUserToResizeRows = false;
            productsGridView.BackgroundColor = Color.WhiteSmoke;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(28, 84);
            productsGridView.Name = "productsGridView";
            productsGridView.RowHeadersVisible = false;
            productsGridView.Size = new Size(670, 380);
            productsGridView.TabIndex = 0;
            productsGridView.VisibleChanged += showProductsTable;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(inventoryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Form1";
            Load += Inventory_Load;
            inventoryPanel.ResumeLayout(false);
            inventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel inventoryPanel;
        private DataGridView productsGridView;
        private Label label1;
    }
}