namespace EDP
{
    partial class WeeklySales
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
            weeklySalesGridView = new DataGridView();
            weeklySalesPanel = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)weeklySalesGridView).BeginInit();
            weeklySalesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // weeklySalesGridView
            // 
            weeklySalesGridView.AllowUserToAddRows = false;
            weeklySalesGridView.AllowUserToDeleteRows = false;
            weeklySalesGridView.AllowUserToResizeColumns = false;
            weeklySalesGridView.AllowUserToResizeRows = false;
            weeklySalesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            weeklySalesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            weeklySalesGridView.BackgroundColor = Color.WhiteSmoke;
            weeklySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weeklySalesGridView.Location = new Point(28, 84);
            weeklySalesGridView.Name = "weeklySalesGridView";
            weeklySalesGridView.RowHeadersVisible = false;
            weeklySalesGridView.Size = new Size(670, 52);
            weeklySalesGridView.TabIndex = 1;
            // 
            // weeklySalesPanel
            // 
            weeklySalesPanel.BackColor = SystemColors.ControlLightLight;
            weeklySalesPanel.Controls.Add(label2);
            weeklySalesPanel.Dock = DockStyle.Fill;
            weeklySalesPanel.Location = new Point(0, 0);
            weeklySalesPanel.Name = "weeklySalesPanel";
            weeklySalesPanel.Size = new Size(730, 510);
            weeklySalesPanel.TabIndex = 2;
            weeklySalesPanel.Paint += weeklySalesPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(317, 43);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Weekly Sales";
            // 
            // WeeklySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 510);
            Controls.Add(weeklySalesGridView);
            Controls.Add(weeklySalesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WeeklySales";
            Text = "WeeklySales";
            Load += WeeklySales_Load;
            ((System.ComponentModel.ISupportInitialize)weeklySalesGridView).EndInit();
            weeklySalesPanel.ResumeLayout(false);
            weeklySalesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView weeklySalesGridView;
        private Panel weeklySalesPanel;
        private Label label2;
    }
}