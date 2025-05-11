namespace EDP
{
    partial class Categories
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
            label1 = new Label();
            categoriesGridView = new DataGridView();
            categoriesPanel = new Panel();
            addProductForm = new Panel();
            addCategoryBtn = new Button();
            categoryNameLabel = new Label();
            categoryNameTxtbox = new TextBox();
            categoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).BeginInit();
            categoriesPanel.SuspendLayout();
            addProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 55);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // categoriesGridView
            // 
            categoriesGridView.AllowUserToAddRows = false;
            categoriesGridView.AllowUserToDeleteRows = false;
            categoriesGridView.AllowUserToResizeColumns = false;
            categoriesGridView.AllowUserToResizeRows = false;
            categoriesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            categoriesGridView.BackgroundColor = Color.WhiteSmoke;
            categoriesGridView.BorderStyle = BorderStyle.None;
            categoriesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            categoriesGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            categoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            categoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesGridView.EnableHeadersVisualStyles = false;
            categoriesGridView.Location = new Point(96, 108);
            categoriesGridView.MultiSelect = false;
            categoriesGridView.Name = "categoriesGridView";
            categoriesGridView.ReadOnly = true;
            categoriesGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            categoriesGridView.RowHeadersVisible = false;
            categoriesGridView.ScrollBars = ScrollBars.Vertical;
            categoriesGridView.ShowCellToolTips = false;
            categoriesGridView.ShowEditingIcon = false;
            categoriesGridView.Size = new Size(989, 319);
            categoriesGridView.TabIndex = 1;
            // 
            // categoriesPanel
            // 
            categoriesPanel.BackColor = Color.FromArgb(0, 64, 64);
            categoriesPanel.Controls.Add(addProductForm);
            categoriesPanel.Controls.Add(label1);
            categoriesPanel.Controls.Add(categoriesGridView);
            categoriesPanel.Dock = DockStyle.Fill;
            categoriesPanel.Location = new Point(0, 0);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(1200, 750);
            categoriesPanel.TabIndex = 2;
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(addCategoryBtn);
            addProductForm.Controls.Add(categoryNameLabel);
            addProductForm.Controls.Add(categoryNameTxtbox);
            addProductForm.Controls.Add(categoryLabel);
            addProductForm.Location = new Point(96, 482);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(989, 183);
            addProductForm.TabIndex = 2;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.Teal;
            addCategoryBtn.FlatAppearance.BorderSize = 0;
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.ForeColor = Color.WhiteSmoke;
            addCategoryBtn.Location = new Point(695, 103);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Padding = new Padding(2);
            addCategoryBtn.Size = new Size(120, 31);
            addCategoryBtn.TabIndex = 15;
            addCategoryBtn.Text = "Add Category";
            addCategoryBtn.UseVisualStyleBackColor = false;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.ForeColor = Color.WhiteSmoke;
            categoryNameLabel.Location = new Point(187, 86);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(90, 15);
            categoryNameLabel.TabIndex = 2;
            categoryNameLabel.Text = "Category Name";
            // 
            // categoryNameTxtbox
            // 
            categoryNameTxtbox.Location = new Point(187, 108);
            categoryNameTxtbox.Name = "categoryNameTxtbox";
            categoryNameTxtbox.Size = new Size(467, 23);
            categoryNameTxtbox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            categoryLabel.ForeColor = Color.WhiteSmoke;
            categoryLabel.Location = new Point(445, 35);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(175, 25);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Add New Category";
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(categoriesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).EndInit();
            categoriesPanel.ResumeLayout(false);
            categoriesPanel.PerformLayout();
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView categoriesGridView;
        private Panel categoriesPanel;
        private Panel addProductForm;
        private Button addCategoryBtn;
        private Label categoryNameLabel;
        private TextBox categoryNameTxtbox;
        private Label categoryLabel;
    }
}