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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)salesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).BeginInit();
            SuspendLayout();
            // 
            // salesGridView
            // 
            salesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGridView.Location = new Point(46, 72);
            salesGridView.Name = "salesGridView";
            salesGridView.Size = new Size(334, 314);
            salesGridView.TabIndex = 0;
            // 
            // saleItemsGridView
            // 
            saleItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleItemsGridView.Location = new Point(425, 72);
            saleItemsGridView.Name = "saleItemsGridView";
            saleItemsGridView.Size = new Size(334, 314);
            saleItemsGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Sales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Sale Items";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saleItemsGridView);
            Controls.Add(salesGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ((System.ComponentModel.ISupportInitialize)salesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleItemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView salesGridView;
        private DataGridView saleItemsGridView;
        private Label label1;
        private Label label2;
    }
}