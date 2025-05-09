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
            AddSupplierBtn = new Button();
            label2 = new Label();
            label3 = new Label();
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
            suppliersGridView.Location = new Point(33, 138);
            suppliersGridView.Name = "suppliersGridView";
            suppliersGridView.RowHeadersVisible = false;
            suppliersGridView.ScrollBars = ScrollBars.Vertical;
            suppliersGridView.Size = new Size(744, 257);
            suppliersGridView.TabIndex = 1;
            // 
            // suppliersPanel
            // 
            suppliersPanel.BackColor = Color.FromArgb(0, 64, 64);
            suppliersPanel.Controls.Add(AddSupplierBtn);
            suppliersPanel.Controls.Add(suppliersGridView);
            suppliersPanel.Controls.Add(label2);
            suppliersPanel.Controls.Add(label3);
            suppliersPanel.Dock = DockStyle.Fill;
            suppliersPanel.Location = new Point(0, 0);
            suppliersPanel.Name = "suppliersPanel";
            suppliersPanel.Size = new Size(820, 640);
            suppliersPanel.TabIndex = 2;
            // 
            // AddSupplierBtn
            // 
            AddSupplierBtn.BackColor = Color.Teal;
            AddSupplierBtn.FlatAppearance.BorderSize = 0;
            AddSupplierBtn.FlatStyle = FlatStyle.Flat;
            AddSupplierBtn.ForeColor = Color.WhiteSmoke;
            AddSupplierBtn.Location = new Point(667, 96);
            AddSupplierBtn.Name = "AddSupplierBtn";
            AddSupplierBtn.Padding = new Padding(1);
            AddSupplierBtn.Size = new Size(110, 30);
            AddSupplierBtn.TabIndex = 11;
            AddSupplierBtn.Text = "Add Supplier";
            AddSupplierBtn.UseVisualStyleBackColor = false;
            AddSupplierBtn.Click += AddSupplierBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 89);
            label2.Name = "label2";
            label2.Size = new Size(130, 37);
            label2.TabIndex = 3;
            label2.Text = "Suppliers";
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
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 640);
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
        private Button AddSupplierBtn;
    }
}