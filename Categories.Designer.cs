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
            label1 = new Label();
            categoriesGridView = new DataGridView();
            categoriesPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).BeginInit();
            categoriesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(343, 67);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // categoriesGridView
            // 
            categoriesGridView.AllowUserToAddRows = false;
            categoriesGridView.AllowUserToDeleteRows = false;
            categoriesGridView.AllowUserToResizeColumns = false;
            categoriesGridView.AllowUserToResizeRows = false;
            categoriesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            categoriesGridView.BackgroundColor = Color.WhiteSmoke;
            categoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesGridView.Location = new Point(96, 110);
            categoriesGridView.Name = "categoriesGridView";
            categoriesGridView.RowHeadersVisible = false;
            categoriesGridView.ScrollBars = ScrollBars.None;
            categoriesGridView.ShowEditingIcon = false;
            categoriesGridView.Size = new Size(554, 236);
            categoriesGridView.TabIndex = 1;
            // 
            // categoriesPanel
            // 
            categoriesPanel.Controls.Add(label1);
            categoriesPanel.Controls.Add(categoriesGridView);
            categoriesPanel.Dock = DockStyle.Fill;
            categoriesPanel.Location = new Point(0, 0);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(730, 510);
            categoriesPanel.TabIndex = 2;
            categoriesPanel.Paint += categoriesPanel_Paint;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(categoriesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).EndInit();
            categoriesPanel.ResumeLayout(false);
            categoriesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView categoriesGridView;
        private Panel categoriesPanel;
    }
}