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
            panel1 = new Panel();
            dashboardPanel = new Panel();
            totalProductsSoldPanel = new Panel();
            label5 = new Label();
            label6 = new Label();
            prodouctsSoldTodayPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            totalRevenuePanel = new Panel();
            label7 = new Label();
            label8 = new Label();
            todaysGrossSalePanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            salesButtonPanel = new Panel();
            orderButtonPanel = new Panel();
            ordersBtn = new Button();
            inventoryPanel = new Panel();
            productsGridView = new DataGridView();
            panel4 = new Panel();
            salesBtn = new Button();
            inventoryButtonPanel = new Panel();
            inventoryBtn = new Button();
            dashboardButtonPanel = new Panel();
            dashboardBtn = new Button();
            storeName = new Label();
            panel1.SuspendLayout();
            dashboardPanel.SuspendLayout();
            totalProductsSoldPanel.SuspendLayout();
            prodouctsSoldTodayPanel.SuspendLayout();
            totalRevenuePanel.SuspendLayout();
            todaysGrossSalePanel.SuspendLayout();
            salesButtonPanel.SuspendLayout();
            orderButtonPanel.SuspendLayout();
            inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            panel4.SuspendLayout();
            inventoryButtonPanel.SuspendLayout();
            dashboardButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dashboardPanel);
            panel1.Controls.Add(salesButtonPanel);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.ControlLightLight;
            dashboardPanel.Controls.Add(totalProductsSoldPanel);
            dashboardPanel.Controls.Add(prodouctsSoldTodayPanel);
            dashboardPanel.Controls.Add(totalRevenuePanel);
            dashboardPanel.Controls.Add(todaysGrossSalePanel);
            dashboardPanel.Location = new Point(155, 2);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(645, 447);
            dashboardPanel.TabIndex = 1;
            dashboardPanel.Paint += dashboardPanel_Paint;
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
            label4.Click += label4_Click;
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
            // salesButtonPanel
            // 
            salesButtonPanel.BackColor = Color.Transparent;
            salesButtonPanel.Controls.Add(orderButtonPanel);
            salesButtonPanel.Controls.Add(inventoryPanel);
            salesButtonPanel.Controls.Add(panel4);
            salesButtonPanel.Controls.Add(inventoryButtonPanel);
            salesButtonPanel.Controls.Add(dashboardButtonPanel);
            salesButtonPanel.Controls.Add(storeName);
            salesButtonPanel.Location = new Point(0, 0);
            salesButtonPanel.Name = "salesButtonPanel";
            salesButtonPanel.Size = new Size(155, 450);
            salesButtonPanel.TabIndex = 0;
            salesButtonPanel.Paint += panel2_Paint;
            // 
            // orderButtonPanel
            // 
            orderButtonPanel.Controls.Add(ordersBtn);
            orderButtonPanel.Location = new Point(0, 269);
            orderButtonPanel.Name = "orderButtonPanel";
            orderButtonPanel.Size = new Size(155, 52);
            orderButtonPanel.TabIndex = 2;
            // 
            // ordersBtn
            // 
            ordersBtn.FlatAppearance.BorderSize = 0;
            ordersBtn.FlatStyle = FlatStyle.Flat;
            ordersBtn.ForeColor = SystemColors.ButtonHighlight;
            ordersBtn.Location = new Point(3, 3);
            ordersBtn.Name = "ordersBtn";
            ordersBtn.Size = new Size(149, 46);
            ordersBtn.TabIndex = 0;
            ordersBtn.Text = "Orders";
            ordersBtn.UseVisualStyleBackColor = false;
            ordersBtn.Click += showOrdersPanel;
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(productsGridView);
            inventoryPanel.Location = new Point(155, 0);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(645, 450);
            inventoryPanel.TabIndex = 5;
            inventoryPanel.Paint += inventoryPanel_Paint;
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(17, 10);
            productsGridView.Name = "productsGridView";
            productsGridView.Size = new Size(615, 426);
            productsGridView.TabIndex = 0;
            productsGridView.VisibleChanged += showProductsTable;
            // 
            // panel4
            // 
            panel4.Controls.Add(salesBtn);
            panel4.Location = new Point(0, 211);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 52);
            panel4.TabIndex = 2;
            // 
            // salesBtn
            // 
            salesBtn.FlatAppearance.BorderSize = 0;
            salesBtn.FlatStyle = FlatStyle.Flat;
            salesBtn.ForeColor = SystemColors.ButtonHighlight;
            salesBtn.Location = new Point(3, 3);
            salesBtn.Name = "salesBtn";
            salesBtn.Size = new Size(149, 46);
            salesBtn.TabIndex = 0;
            salesBtn.Text = "Sales";
            salesBtn.UseVisualStyleBackColor = false;
            salesBtn.Click += showSalesPanel;
            // 
            // inventoryButtonPanel
            // 
            inventoryButtonPanel.Controls.Add(inventoryBtn);
            inventoryButtonPanel.Location = new Point(0, 153);
            inventoryButtonPanel.Name = "inventoryButtonPanel";
            inventoryButtonPanel.Size = new Size(155, 52);
            inventoryButtonPanel.TabIndex = 2;
            // 
            // inventoryBtn
            // 
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.ForeColor = SystemColors.ButtonHighlight;
            inventoryBtn.Location = new Point(3, 3);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(149, 46);
            inventoryBtn.TabIndex = 0;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = false;
            inventoryBtn.Click += showInventoryPanel;
            // 
            // dashboardButtonPanel
            // 
            dashboardButtonPanel.BackgroundImageLayout = ImageLayout.None;
            dashboardButtonPanel.Controls.Add(dashboardBtn);
            dashboardButtonPanel.Location = new Point(0, 95);
            dashboardButtonPanel.Name = "dashboardButtonPanel";
            dashboardButtonPanel.Size = new Size(155, 52);
            dashboardButtonPanel.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.ForeColor = SystemColors.ButtonHighlight;
            dashboardBtn.Location = new Point(3, 3);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(149, 46);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += showDashboardPanel;
            // 
            // storeName
            // 
            storeName.BackColor = Color.Transparent;
            storeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ControlLightLight;
            storeName.Location = new Point(1, 9);
            storeName.Name = "storeName";
            storeName.Size = new Size(152, 67);
            storeName.TabIndex = 2;
            storeName.Text = "JFKL Sari-Sari Store";
            storeName.TextAlign = ContentAlignment.MiddleCenter;
            storeName.Click += storeName_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            dashboardPanel.ResumeLayout(false);
            totalProductsSoldPanel.ResumeLayout(false);
            totalProductsSoldPanel.PerformLayout();
            prodouctsSoldTodayPanel.ResumeLayout(false);
            prodouctsSoldTodayPanel.PerformLayout();
            totalRevenuePanel.ResumeLayout(false);
            totalRevenuePanel.PerformLayout();
            todaysGrossSalePanel.ResumeLayout(false);
            todaysGrossSalePanel.PerformLayout();
            salesButtonPanel.ResumeLayout(false);
            orderButtonPanel.ResumeLayout(false);
            inventoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            panel4.ResumeLayout(false);
            inventoryButtonPanel.ResumeLayout(false);
            dashboardButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel salesButtonPanel;
        private Label storeName;
        private Panel orderButtonPanel;
        private Button ordersBtn;
        private Panel panel4;
        private Button salesBtn;
        private Panel inventoryButtonPanel;
        private Button inventoryBtn;
        private Panel dashboardButtonPanel;
        private Button dashboardBtn;
        private Panel dashboardPanel;
        private Panel todaysGrossSalePanel;
        private Label label2;
        private Label label1;
        private Panel prodouctsSoldTodayPanel;
        private Label label3;
        private Label label4;
        private Panel totalProductsSoldPanel;
        private Label label5;
        private Label label6;
        private Panel totalRevenuePanel;
        private Label label7;
        private Label label8;
        private Panel inventoryPanel;
        private DataGridView productsGridView;
        private PictureBox pictureBox1;
    }
}
