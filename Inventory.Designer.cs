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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            inventoryPanel = new Panel();
            categoryFilterComboBox = new ComboBox();
            AddProductBtn = new Button();
            label1 = new Label();
            productsGridView = new DataGridView();
            inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            SuspendLayout();
            // 
            // inventoryPanel
            // 
            inventoryPanel.BackColor = Color.FromArgb(0, 64, 64);
            inventoryPanel.Controls.Add(categoryFilterComboBox);
            inventoryPanel.Controls.Add(AddProductBtn);
            inventoryPanel.Controls.Add(label1);
            inventoryPanel.Controls.Add(productsGridView);
            inventoryPanel.Dock = DockStyle.Fill;
            inventoryPanel.Location = new Point(0, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(1200, 750);
            inventoryPanel.TabIndex = 0;
            // 
            // categoryFilterComboBox
            // 
            categoryFilterComboBox.FormattingEnabled = true;
            categoryFilterComboBox.Location = new Point(37, 103);
            categoryFilterComboBox.Name = "categoryFilterComboBox";
            categoryFilterComboBox.Size = new Size(234, 23);
            categoryFilterComboBox.TabIndex = 3;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.Teal;
            AddProductBtn.FlatAppearance.BorderSize = 0;
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.ForeColor = Color.WhiteSmoke;
            AddProductBtn.Location = new Point(1018, 97);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Padding = new Padding(1);
            AddProductBtn.Size = new Size(138, 29);
            AddProductBtn.TabIndex = 2;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.AllowUserToResizeColumns = false;
            productsGridView.AllowUserToResizeRows = false;
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productsGridView.BackgroundColor = Color.WhiteSmoke;
            productsGridView.BorderStyle = BorderStyle.None;
            productsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            productsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.EnableHeadersVisualStyles = false;
            productsGridView.Location = new Point(37, 152);
            productsGridView.MultiSelect = false;
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            productsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            productsGridView.ScrollBars = ScrollBars.Vertical;
            productsGridView.ShowCellToolTips = false;
            productsGridView.ShowEditingIcon = false;
            productsGridView.Size = new Size(1119, 550);
            productsGridView.TabIndex = 0;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
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
        private Button AddProductBtn;
        private ComboBox categoryFilterComboBox;
    }
}