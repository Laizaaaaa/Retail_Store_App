namespace EDP
{
    partial class MonthlySales
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
            monthlySalesGridView = new DataGridView();
            monthlySalesPanel = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)monthlySalesGridView).BeginInit();
            monthlySalesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // monthlySalesGridView
            // 
            monthlySalesGridView.AllowUserToAddRows = false;
            monthlySalesGridView.AllowUserToDeleteRows = false;
            monthlySalesGridView.AllowUserToResizeColumns = false;
            monthlySalesGridView.AllowUserToResizeRows = false;
            monthlySalesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            monthlySalesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            monthlySalesGridView.BackgroundColor = Color.WhiteSmoke;
            monthlySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthlySalesGridView.Location = new Point(71, 158);
            monthlySalesGridView.Name = "monthlySalesGridView";
            monthlySalesGridView.RowHeadersVisible = false;
            monthlySalesGridView.ScrollBars = ScrollBars.None;
            monthlySalesGridView.Size = new Size(670, 51);
            monthlySalesGridView.TabIndex = 1;
            // 
            // monthlySalesPanel
            // 
            monthlySalesPanel.BackColor = Color.FromArgb(0, 64, 64);
            monthlySalesPanel.Controls.Add(monthlySalesGridView);
            monthlySalesPanel.Controls.Add(label2);
            monthlySalesPanel.Dock = DockStyle.Fill;
            monthlySalesPanel.Location = new Point(0, 0);
            monthlySalesPanel.Name = "monthlySalesPanel";
            monthlySalesPanel.Size = new Size(820, 540);
            monthlySalesPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 102);
            label2.Name = "label2";
            label2.Size = new Size(190, 37);
            label2.TabIndex = 9;
            label2.Text = "Monthly Sales";
            // 
            // MonthlySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 540);
            Controls.Add(monthlySalesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonthlySales";
            Text = "MonthlySales";
            Load += MonthlySales_Load;
            ((System.ComponentModel.ISupportInitialize)monthlySalesGridView).EndInit();
            monthlySalesPanel.ResumeLayout(false);
            monthlySalesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView monthlySalesGridView;
        private Panel monthlySalesPanel;
        private Label label2;
    }
}