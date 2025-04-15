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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearlySalesGridView).BeginInit();
            SuspendLayout();
            // 
            // yearlySalesGridView
            // 
            yearlySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yearlySalesGridView.Location = new Point(139, 69);
            yearlySalesGridView.Name = "yearlySalesGridView";
            yearlySalesGridView.Size = new Size(467, 266);
            yearlySalesGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 35);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Yearly Sales";
            // 
            // YearlySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(yearlySalesGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YearlySales";
            Text = "YearlySales";
            Load += YearlySales_Load;
            ((System.ComponentModel.ISupportInitialize)yearlySalesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView yearlySalesGridView;
        private Label label1;
    }
}