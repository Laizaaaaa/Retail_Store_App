namespace EDP
{
    partial class YearlySales
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
            yearlySalesGridView = new DataGridView();
            yearlySalesPanel = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearlySalesGridView).BeginInit();
            yearlySalesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // yearlySalesGridView
            // 
            yearlySalesGridView.AllowUserToAddRows = false;
            yearlySalesGridView.AllowUserToDeleteRows = false;
            yearlySalesGridView.AllowUserToResizeColumns = false;
            yearlySalesGridView.AllowUserToResizeRows = false;
            yearlySalesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            yearlySalesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            yearlySalesGridView.BackgroundColor = Color.WhiteSmoke;
            yearlySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yearlySalesGridView.Location = new Point(28, 84);
            yearlySalesGridView.Name = "yearlySalesGridView";
            yearlySalesGridView.ReadOnly = true;
            yearlySalesGridView.RowHeadersVisible = false;
            yearlySalesGridView.Size = new Size(670, 53);
            yearlySalesGridView.TabIndex = 0;
            // 
            // yearlySalesPanel
            // 
            yearlySalesPanel.Controls.Add(label2);
            yearlySalesPanel.Dock = DockStyle.Fill;
            yearlySalesPanel.Location = new Point(0, 0);
            yearlySalesPanel.Name = "yearlySalesPanel";
            yearlySalesPanel.Size = new Size(730, 510);
            yearlySalesPanel.TabIndex = 2;
            yearlySalesPanel.Paint += yearlySalesPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 43);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Yearly Sales";
            // 
            // YearlySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(yearlySalesGridView);
            Controls.Add(yearlySalesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YearlySales";
            Text = "YearlySales";
            Load += YearlySales_Load;
            ((System.ComponentModel.ISupportInitialize)yearlySalesGridView).EndInit();
            yearlySalesPanel.ResumeLayout(false);
            yearlySalesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView yearlySalesGridView;
        private Panel yearlySalesPanel;
        private Label label2;
    }
}