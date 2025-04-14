using System.Windows.Forms;

namespace EDP
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todaysGrossSalePanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            totalRevenuePanel = new Panel();
            label8 = new Label();
            label7 = new Label();
            prodouctsSoldTodayPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            totalProductsSoldPanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            dashboardPanel = new Panel();
            todaysGrossSalePanel.SuspendLayout();
            totalRevenuePanel.SuspendLayout();
            prodouctsSoldTodayPanel.SuspendLayout();
            totalProductsSoldPanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // todaysGrossSalePanel
            // 
            todaysGrossSalePanel.BackColor = SystemColors.ControlLightLight;
            todaysGrossSalePanel.BorderStyle = BorderStyle.FixedSingle;
            todaysGrossSalePanel.Controls.Add(label2);
            todaysGrossSalePanel.Controls.Add(label1);
            todaysGrossSalePanel.ForeColor = Color.CornflowerBlue;
            todaysGrossSalePanel.Location = new Point(119, 93);
            todaysGrossSalePanel.Name = "todaysGrossSalePanel";
            todaysGrossSalePanel.Size = new Size(200, 100);
            todaysGrossSalePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(48, 10);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Today's Gross Sale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(60, 43);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "$";
            // 
            // totalRevenuePanel
            // 
            totalRevenuePanel.BackColor = SystemColors.ControlLightLight;
            totalRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
            totalRevenuePanel.Controls.Add(label7);
            totalRevenuePanel.Controls.Add(label8);
            totalRevenuePanel.ForeColor = Color.CornflowerBlue;
            totalRevenuePanel.Location = new Point(119, 219);
            totalRevenuePanel.Name = "totalRevenuePanel";
            totalRevenuePanel.Size = new Size(200, 100);
            totalRevenuePanel.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(60, 10);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 0;
            label8.Text = "Total Revenue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(60, 43);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 1;
            label7.Text = "$";
            // 
            // prodouctsSoldTodayPanel
            // 
            prodouctsSoldTodayPanel.BackColor = SystemColors.ControlLightLight;
            prodouctsSoldTodayPanel.BorderStyle = BorderStyle.FixedSingle;
            prodouctsSoldTodayPanel.Controls.Add(label3);
            prodouctsSoldTodayPanel.Controls.Add(label4);
            prodouctsSoldTodayPanel.ForeColor = Color.CornflowerBlue;
            prodouctsSoldTodayPanel.Location = new Point(336, 93);
            prodouctsSoldTodayPanel.Name = "prodouctsSoldTodayPanel";
            prodouctsSoldTodayPanel.Size = new Size(200, 100);
            prodouctsSoldTodayPanel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(48, 10);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 0;
            label4.Text = "Products Sold Today";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(60, 43);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 1;
            label3.Text = "$";
            // 
            // totalProductsSoldPanel
            // 
            totalProductsSoldPanel.BackColor = SystemColors.ControlLightLight;
            totalProductsSoldPanel.BorderStyle = BorderStyle.FixedSingle;
            totalProductsSoldPanel.Controls.Add(label5);
            totalProductsSoldPanel.Controls.Add(label6);
            totalProductsSoldPanel.ForeColor = Color.CornflowerBlue;
            totalProductsSoldPanel.Location = new Point(336, 219);
            totalProductsSoldPanel.Name = "totalProductsSoldPanel";
            totalProductsSoldPanel.Size = new Size(200, 100);
            totalProductsSoldPanel.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(48, 10);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 0;
            label6.Text = "Total Products Sold";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(60, 43);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 1;
            label5.Text = "$";
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.ControlLightLight;
            dashboardPanel.Controls.Add(totalProductsSoldPanel);
            dashboardPanel.Controls.Add(prodouctsSoldTodayPanel);
            dashboardPanel.Controls.Add(totalRevenuePanel);
            dashboardPanel.Controls.Add(todaysGrossSalePanel);
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(800, 450);
            dashboardPanel.TabIndex = 1;
            dashboardPanel.Paint += dashboardPanel_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dashboardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            todaysGrossSalePanel.ResumeLayout(false);
            todaysGrossSalePanel.PerformLayout();
            totalRevenuePanel.ResumeLayout(false);
            totalRevenuePanel.PerformLayout();
            prodouctsSoldTodayPanel.ResumeLayout(false);
            prodouctsSoldTodayPanel.PerformLayout();
            totalProductsSoldPanel.ResumeLayout(false);
            totalProductsSoldPanel.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel todaysGrossSalePanel;
        private Label label2;
        private Label label1;
        private Panel totalRevenuePanel;
        private Label label7;
        private Label label8;
        private Panel prodouctsSoldTodayPanel;
        private Label label3;
        private Label label4;
        private Panel totalProductsSoldPanel;
        private Label label5;
        private Label label6;
        private Panel dashboardPanel;
    }
}
