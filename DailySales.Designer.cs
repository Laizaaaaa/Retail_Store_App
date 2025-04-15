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
            label2 = new Label();
            dailySalesGridView = new DataGridView();
            dailySalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dailySalesGridView).BeginInit();
            SuspendLayout();
            // 
            // dailySalesPanel
            // 
            dailySalesPanel.BackColor = SystemColors.Control;
            dailySalesPanel.Controls.Add(label2);
            dailySalesPanel.Controls.Add(dailySalesGridView);
            dailySalesPanel.Dock = DockStyle.Fill;
            dailySalesPanel.Location = new Point(0, 0);
            dailySalesPanel.Name = "dailySalesPanel";
            dailySalesPanel.Size = new Size(730, 510);
            dailySalesPanel.TabIndex = 0;
            dailySalesPanel.Paint += dailySalesPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(329, 43);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "Daily Sales";
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
            dailySalesGridView.Location = new Point(28, 84);
            dailySalesGridView.Name = "dailySalesGridView";
            dailySalesGridView.RowHeadersVisible = false;
            dailySalesGridView.Size = new Size(670, 380);
            dailySalesGridView.TabIndex = 0;
            // 
            // DailySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
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
        private Label label2;
    }
}