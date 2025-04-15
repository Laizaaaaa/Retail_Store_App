namespace EDP
{
    partial class Suppliers
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
            suppliersGridView = new DataGridView();
            suppliersPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)suppliersGridView).BeginInit();
            suppliersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // suppliersGridView
            // 
            suppliersGridView.AllowUserToAddRows = false;
            suppliersGridView.AllowUserToDeleteRows = false;
            suppliersGridView.AllowUserToResizeColumns = false;
            suppliersGridView.AllowUserToResizeRows = false;
            suppliersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suppliersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            suppliersGridView.BackgroundColor = Color.WhiteSmoke;
            suppliersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersGridView.Location = new Point(28, 84);
            suppliersGridView.Name = "suppliersGridView";
            suppliersGridView.RowHeadersVisible = false;
            suppliersGridView.ScrollBars = ScrollBars.None;
            suppliersGridView.Size = new Size(670, 257);
            suppliersGridView.TabIndex = 1;
            // 
            // suppliersPanel
            // 
            suppliersPanel.BackColor = Color.Transparent;
            suppliersPanel.Controls.Add(label2);
            suppliersPanel.Controls.Add(label3);
            suppliersPanel.Dock = DockStyle.Fill;
            suppliersPanel.Location = new Point(0, 0);
            suppliersPanel.Name = "suppliersPanel";
            suppliersPanel.Size = new Size(730, 510);
            suppliersPanel.TabIndex = 2;
            suppliersPanel.Paint += suppliersPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(284, 245);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 9;
            label3.Text = "Discounted Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(329, 43);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Suppliers";
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(suppliersGridView);
            Controls.Add(suppliersPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)suppliersGridView).EndInit();
            suppliersPanel.ResumeLayout(false);
            suppliersPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView suppliersGridView;
        private Panel suppliersPanel;
        private Label label3;
        private Label label2;
    }
}