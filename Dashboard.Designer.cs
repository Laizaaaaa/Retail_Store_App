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
            todaysGrossSale = new Label();
            label1 = new Label();
            totalRevenuePanel = new Panel();
            totalRevenue = new Label();
            label8 = new Label();
            prodouctsSoldTodayPanel = new Panel();
            productsSoldToday = new Label();
            label4 = new Label();
            totalProductsSoldPanel = new Panel();
            totalProductsSold = new Label();
            label6 = new Label();
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
            todaysGrossSalePanel.Controls.Add(todaysGrossSale);
            todaysGrossSalePanel.Controls.Add(label1);
            todaysGrossSalePanel.ForeColor = Color.CornflowerBlue;
            todaysGrossSalePanel.Location = new Point(181, 97);
            todaysGrossSalePanel.Name = "todaysGrossSalePanel";
            todaysGrossSalePanel.Size = new Size(200, 100);
            todaysGrossSalePanel.TabIndex = 0;
            // 
            // todaysGrossSale
            // 
            todaysGrossSale.AutoSize = true;
            todaysGrossSale.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            todaysGrossSale.Location = new Point(60, 43);
            todaysGrossSale.Name = "todaysGrossSale";
            todaysGrossSale.Size = new Size(18, 20);
            todaysGrossSale.TabIndex = 1;
            todaysGrossSale.Text = "$";
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
            // totalRevenuePanel
            // 
            totalRevenuePanel.BackColor = SystemColors.ControlLightLight;
            totalRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
            totalRevenuePanel.Controls.Add(totalRevenue);
            totalRevenuePanel.Controls.Add(label8);
            totalRevenuePanel.ForeColor = Color.CornflowerBlue;
            totalRevenuePanel.Location = new Point(181, 223);
            totalRevenuePanel.Name = "totalRevenuePanel";
            totalRevenuePanel.Size = new Size(200, 100);
            totalRevenuePanel.TabIndex = 3;
            // 
            // totalRevenue
            // 
            totalRevenue.AutoSize = true;
            totalRevenue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            totalRevenue.Location = new Point(60, 43);
            totalRevenue.Name = "totalRevenue";
            totalRevenue.Size = new Size(18, 20);
            totalRevenue.TabIndex = 1;
            totalRevenue.Text = "$";
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
            // prodouctsSoldTodayPanel
            // 
            prodouctsSoldTodayPanel.BackColor = SystemColors.ControlLightLight;
            prodouctsSoldTodayPanel.BorderStyle = BorderStyle.FixedSingle;
            prodouctsSoldTodayPanel.Controls.Add(productsSoldToday);
            prodouctsSoldTodayPanel.Controls.Add(label4);
            prodouctsSoldTodayPanel.ForeColor = Color.CornflowerBlue;
            prodouctsSoldTodayPanel.Location = new Point(398, 97);
            prodouctsSoldTodayPanel.Name = "prodouctsSoldTodayPanel";
            prodouctsSoldTodayPanel.Size = new Size(200, 100);
            prodouctsSoldTodayPanel.TabIndex = 2;
            // 
            // productsSoldToday
            // 
            productsSoldToday.AutoSize = true;
            productsSoldToday.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            productsSoldToday.Location = new Point(60, 43);
            productsSoldToday.Name = "productsSoldToday";
            productsSoldToday.Size = new Size(18, 20);
            productsSoldToday.TabIndex = 1;
            productsSoldToday.Text = "$";
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
            // totalProductsSoldPanel
            // 
            totalProductsSoldPanel.BackColor = SystemColors.ControlLightLight;
            totalProductsSoldPanel.BorderStyle = BorderStyle.FixedSingle;
            totalProductsSoldPanel.Controls.Add(totalProductsSold);
            totalProductsSoldPanel.Controls.Add(label6);
            totalProductsSoldPanel.ForeColor = Color.CornflowerBlue;
            totalProductsSoldPanel.Location = new Point(398, 223);
            totalProductsSoldPanel.Name = "totalProductsSoldPanel";
            totalProductsSoldPanel.Size = new Size(200, 100);
            totalProductsSoldPanel.TabIndex = 4;
            // 
            // totalProductsSold
            // 
            totalProductsSold.AutoSize = true;
            totalProductsSold.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            totalProductsSold.Location = new Point(60, 43);
            totalProductsSold.Name = "totalProductsSold";
            totalProductsSold.Size = new Size(18, 20);
            totalProductsSold.TabIndex = 1;
            totalProductsSold.Text = "$";
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
            Load += Dashboard_Load;
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
        private Label todaysGrossSale;
        private Label label1;
        private Panel totalRevenuePanel;
        private Label totalRevenue;
        private Label label8;
        private Panel prodouctsSoldTodayPanel;
        private Label productsSoldToday;
        private Label label4;
        private Panel totalProductsSoldPanel;
        private Label totalProductsSold;
        private Label label6;
        private Panel dashboardPanel;
    }
}
