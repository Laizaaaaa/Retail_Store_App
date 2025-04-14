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
            productsGridView = new DataGridView();
            label1 = new Label();
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
            inventoryPanel.Size = new Size(800, 450);
            inventoryPanel.TabIndex = 0;
            inventoryPanel.Paint += inventoryPanel_Paint;
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(114, 25);
            productsGridView.Name = "productsGridView";
            productsGridView.Size = new Size(558, 399);
            productsGridView.TabIndex = 0;
            productsGridView.VisibleChanged += showProductsTable;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 7);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inventoryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Form1";
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