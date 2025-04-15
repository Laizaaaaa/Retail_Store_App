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
            label1 = new Label();
            monthlySalesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)monthlySalesGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Monthly Sales";
            // 
            // monthlySalesGridView
            // 
            monthlySalesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthlySalesGridView.Location = new Point(79, 44);
            monthlySalesGridView.Name = "monthlySalesGridView";
            monthlySalesGridView.Size = new Size(674, 372);
            monthlySalesGridView.TabIndex = 1;
            // 
            // MonthlySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthlySalesGridView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonthlySales";
            Text = "MonthlySales";
            Load += MonthlySales_Load;
            ((System.ComponentModel.ISupportInitialize)monthlySalesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView monthlySalesGridView;
    }
}