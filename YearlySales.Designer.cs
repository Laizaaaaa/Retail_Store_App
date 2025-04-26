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
            yearlySalesLabel = new Label();
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
            yearlySalesGridView.Location = new Point(72, 186);
            yearlySalesGridView.Name = "yearlySalesGridView";
            yearlySalesGridView.ReadOnly = true;
            yearlySalesGridView.RowHeadersVisible = false;
            yearlySalesGridView.Size = new Size(670, 53);
            yearlySalesGridView.TabIndex = 0;
            // 
            // yearlySalesPanel
            // 
            yearlySalesPanel.Controls.Add(yearlySalesGridView);
            yearlySalesPanel.Controls.Add(yearlySalesLabel);
            yearlySalesPanel.Dock = DockStyle.Fill;
            yearlySalesPanel.Location = new Point(0, 0);
            yearlySalesPanel.Name = "yearlySalesPanel";
            yearlySalesPanel.Size = new Size(820, 640);
            yearlySalesPanel.TabIndex = 2;
            // 
            // yearlySalesLabel
            // 
            yearlySalesLabel.AutoSize = true;
            yearlySalesLabel.BackColor = Color.Transparent;
            yearlySalesLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            yearlySalesLabel.ForeColor = Color.White;
            yearlySalesLabel.Location = new Point(72, 131);
            yearlySalesLabel.Name = "yearlySalesLabel";
            yearlySalesLabel.Size = new Size(159, 37);
            yearlySalesLabel.TabIndex = 7;
            yearlySalesLabel.Text = "Yearly Sales";
            // 
            // YearlySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            Controls.Add(yearlySalesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YearlySales";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label yearlySalesLabel;
    }
}