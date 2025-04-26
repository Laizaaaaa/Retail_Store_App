namespace EDP
{
    partial class DailySales
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
            dailySalesPanel = new Panel();
            dailySalesLabel = new Label();
            dailySalesGridView = new DataGridView();
            dailySalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dailySalesGridView).BeginInit();
            SuspendLayout();
            // 
            // dailySalesPanel
            // 
            dailySalesPanel.BackColor = Color.FromArgb(0, 64, 64);
            dailySalesPanel.Controls.Add(dailySalesLabel);
            dailySalesPanel.Controls.Add(dailySalesGridView);
            dailySalesPanel.Dock = DockStyle.Fill;
            dailySalesPanel.Location = new Point(0, 0);
            dailySalesPanel.Name = "dailySalesPanel";
            dailySalesPanel.Size = new Size(820, 640);
            dailySalesPanel.TabIndex = 0;
            dailySalesPanel.Paint += dailySalesPanel_Paint;
            // 
            // dailySalesLabel
            // 
            dailySalesLabel.AutoSize = true;
            dailySalesLabel.BackColor = Color.Transparent;
            dailySalesLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            dailySalesLabel.ForeColor = Color.White;
            dailySalesLabel.Location = new Point(75, 56);
            dailySalesLabel.Name = "dailySalesLabel";
            dailySalesLabel.Size = new Size(147, 37);
            dailySalesLabel.TabIndex = 8;
            dailySalesLabel.Text = "Daily Sales";
            // 
            // dailySalesGridView
            // 
            dailySalesGridView.AllowUserToAddRows = false;
            dailySalesGridView.AllowUserToDeleteRows = false;
            dailySalesGridView.AllowUserToResizeColumns = false;
            dailySalesGridView.AllowUserToResizeRows = false;
            dailySalesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dailySalesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dailySalesGridView.BackgroundColor = Color.WhiteSmoke;
            dailySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dailySalesGridView.Location = new Point(75, 104);
            dailySalesGridView.Name = "dailySalesGridView";
            dailySalesGridView.RowHeadersVisible = false;
            dailySalesGridView.Size = new Size(670, 478);
            dailySalesGridView.TabIndex = 0;
            // 
            // DailySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 640);
            Controls.Add(dailySalesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DailySales";
            Text = "DailySales";
            Load += DailySales_Load;
            dailySalesPanel.ResumeLayout(false);
            dailySalesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dailySalesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dailySalesPanel;
        private DataGridView dailySalesGridView;
        private Label dailySalesLabel;
    }
}