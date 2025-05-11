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
            label3 = new Label();
            label2 = new Label();
            discountedProductsGridView = new DataGridView();
            bestSellingProductsGridView = new DataGridView();
            todaysGrossSalePanel.SuspendLayout();
            totalRevenuePanel.SuspendLayout();
            prodouctsSoldTodayPanel.SuspendLayout();
            totalProductsSoldPanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)discountedProductsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bestSellingProductsGridView).BeginInit();
            SuspendLayout();
            // 
            // todaysGrossSalePanel
            // 
            todaysGrossSalePanel.BackColor = Color.SlateBlue;
            todaysGrossSalePanel.BorderStyle = BorderStyle.FixedSingle;
            todaysGrossSalePanel.Controls.Add(todaysGrossSale);
            todaysGrossSalePanel.Controls.Add(label1);
            todaysGrossSalePanel.ForeColor = Color.CornflowerBlue;
            todaysGrossSalePanel.Location = new Point(70, 61);
            todaysGrossSalePanel.Name = "todaysGrossSalePanel";
            todaysGrossSalePanel.Size = new Size(246, 113);
            todaysGrossSalePanel.TabIndex = 0;
            // 
            // todaysGrossSale
            // 
            todaysGrossSale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            todaysGrossSale.AutoSize = true;
            todaysGrossSale.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            todaysGrossSale.ForeColor = Color.WhiteSmoke;
            todaysGrossSale.Location = new Point(26, 56);
            todaysGrossSale.Name = "todaysGrossSale";
            todaysGrossSale.Size = new Size(95, 37);
            todaysGrossSale.TabIndex = 1;
            todaysGrossSale.Text = "$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Today's Gross Sale";
            // 
            // totalRevenuePanel
            // 
            totalRevenuePanel.BackColor = Color.SteelBlue;
            totalRevenuePanel.BorderStyle = BorderStyle.FixedSingle;
            totalRevenuePanel.Controls.Add(totalRevenue);
            totalRevenuePanel.Controls.Add(label8);
            totalRevenuePanel.ForeColor = Color.CornflowerBlue;
            totalRevenuePanel.Location = new Point(624, 61);
            totalRevenuePanel.Name = "totalRevenuePanel";
            totalRevenuePanel.Size = new Size(246, 113);
            totalRevenuePanel.TabIndex = 3;
            totalRevenuePanel.Paint += totalRevenuePanel_Paint;
            // 
            // totalRevenue
            // 
            totalRevenue.AutoSize = true;
            totalRevenue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            totalRevenue.ForeColor = Color.WhiteSmoke;
            totalRevenue.Location = new Point(50, 56);
            totalRevenue.Name = "totalRevenue";
            totalRevenue.Size = new Size(95, 37);
            totalRevenue.TabIndex = 1;
            totalRevenue.Text = "$ 0.00";
            totalRevenue.Click += totalRevenue_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(50, 18);
            label8.Name = "label8";
            label8.Size = new Size(153, 30);
            label8.TabIndex = 0;
            label8.Text = "Total Revenue";
            // 
            // prodouctsSoldTodayPanel
            // 
            prodouctsSoldTodayPanel.BackColor = Color.DarkCyan;
            prodouctsSoldTodayPanel.BorderStyle = BorderStyle.FixedSingle;
            prodouctsSoldTodayPanel.Controls.Add(productsSoldToday);
            prodouctsSoldTodayPanel.Controls.Add(label4);
            prodouctsSoldTodayPanel.ForeColor = Color.CornflowerBlue;
            prodouctsSoldTodayPanel.Location = new Point(350, 61);
            prodouctsSoldTodayPanel.Name = "prodouctsSoldTodayPanel";
            prodouctsSoldTodayPanel.Size = new Size(246, 113);
            prodouctsSoldTodayPanel.TabIndex = 2;
            // 
            // productsSoldToday
            // 
            productsSoldToday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productsSoldToday.AutoSize = true;
            productsSoldToday.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            productsSoldToday.ForeColor = Color.WhiteSmoke;
            productsSoldToday.Location = new Point(17, 56);
            productsSoldToday.Name = "productsSoldToday";
            productsSoldToday.Size = new Size(33, 37);
            productsSoldToday.TabIndex = 1;
            productsSoldToday.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(17, 18);
            label4.Name = "label4";
            label4.Size = new Size(214, 30);
            label4.TabIndex = 0;
            label4.Text = "Products Sold Today";
            // 
            // totalProductsSoldPanel
            // 
            totalProductsSoldPanel.BackColor = Color.LightSlateGray;
            totalProductsSoldPanel.BorderStyle = BorderStyle.FixedSingle;
            totalProductsSoldPanel.Controls.Add(totalProductsSold);
            totalProductsSoldPanel.Controls.Add(label6);
            totalProductsSoldPanel.ForeColor = Color.CornflowerBlue;
            totalProductsSoldPanel.Location = new Point(898, 61);
            totalProductsSoldPanel.Name = "totalProductsSoldPanel";
            totalProductsSoldPanel.Size = new Size(237, 113);
            totalProductsSoldPanel.TabIndex = 4;
            // 
            // totalProductsSold
            // 
            totalProductsSold.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            totalProductsSold.AutoSize = true;
            totalProductsSold.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            totalProductsSold.ForeColor = Color.WhiteSmoke;
            totalProductsSold.Location = new Point(21, 56);
            totalProductsSold.Name = "totalProductsSold";
            totalProductsSold.Size = new Size(33, 37);
            totalProductsSold.TabIndex = 1;
            totalProductsSold.Text = "0";
            totalProductsSold.Click += totalProductsSold_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(21, 18);
            label6.Name = "label6";
            label6.Size = new Size(204, 30);
            label6.TabIndex = 0;
            label6.Text = "Total Products Sold";
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.FromArgb(0, 64, 64);
            dashboardPanel.Controls.Add(label3);
            dashboardPanel.Controls.Add(label2);
            dashboardPanel.Controls.Add(discountedProductsGridView);
            dashboardPanel.Controls.Add(bestSellingProductsGridView);
            dashboardPanel.Controls.Add(totalProductsSoldPanel);
            dashboardPanel.Controls.Add(prodouctsSoldTodayPanel);
            dashboardPanel.Controls.Add(totalRevenuePanel);
            dashboardPanel.Controls.Add(todaysGrossSalePanel);
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1200, 750);
            dashboardPanel.TabIndex = 1;
            dashboardPanel.Paint += dashboardPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(624, 216);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 8;
            label3.Text = "Discounted Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 216);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 7;
            label2.Text = "Best Selling Products";
            label2.Click += label2_Click;
            // 
            // discountedProductsGridView
            // 
            discountedProductsGridView.AllowUserToAddRows = false;
            discountedProductsGridView.AllowUserToDeleteRows = false;
            discountedProductsGridView.AllowUserToResizeColumns = false;
            discountedProductsGridView.AllowUserToResizeRows = false;
            discountedProductsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            discountedProductsGridView.BackgroundColor = Color.WhiteSmoke;
            discountedProductsGridView.BorderStyle = BorderStyle.None;
            discountedProductsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            discountedProductsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            discountedProductsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            discountedProductsGridView.EnableHeadersVisualStyles = false;
            discountedProductsGridView.Location = new Point(624, 244);
            discountedProductsGridView.Name = "discountedProductsGridView";
            discountedProductsGridView.RowHeadersVisible = false;
            discountedProductsGridView.ScrollBars = ScrollBars.Vertical;
            discountedProductsGridView.ShowCellToolTips = false;
            discountedProductsGridView.ShowEditingIcon = false;
            discountedProductsGridView.Size = new Size(511, 446);
            discountedProductsGridView.TabIndex = 6;
            discountedProductsGridView.CellContentClick += discountedProductsGridView_CellContentClick;
            // 
            // bestSellingProductsGridView
            // 
            bestSellingProductsGridView.AllowUserToAddRows = false;
            bestSellingProductsGridView.AllowUserToDeleteRows = false;
            bestSellingProductsGridView.AllowUserToResizeColumns = false;
            bestSellingProductsGridView.AllowUserToResizeRows = false;
            bestSellingProductsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bestSellingProductsGridView.BackgroundColor = Color.WhiteSmoke;
            bestSellingProductsGridView.BorderStyle = BorderStyle.None;
            bestSellingProductsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            bestSellingProductsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            bestSellingProductsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bestSellingProductsGridView.EnableHeadersVisualStyles = false;
            bestSellingProductsGridView.Location = new Point(70, 244);
            bestSellingProductsGridView.Name = "bestSellingProductsGridView";
            bestSellingProductsGridView.RowHeadersVisible = false;
            bestSellingProductsGridView.ScrollBars = ScrollBars.Vertical;
            bestSellingProductsGridView.ShowCellToolTips = false;
            bestSellingProductsGridView.ShowEditingIcon = false;
            bestSellingProductsGridView.Size = new Size(519, 446);
            bestSellingProductsGridView.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
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
            dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)discountedProductsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bestSellingProductsGridView).EndInit();
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
        private DataGridView bestSellingProductsGridView;
        private Label label3;
        private Label label2;
        private DataGridView discountedProductsGridView;
    }
}
