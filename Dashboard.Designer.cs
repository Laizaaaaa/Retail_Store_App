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
            salesButtonPanel = new Panel();
            orderButtonPanel = new Panel();
            ordersButton = new Button();
            panel4 = new Panel();
            salesButton = new Button();
            inventoryButtonPanel = new Panel();
            inventoryButton = new Button();
            dashboardButtonPanel = new Panel();
            dashboardButton = new Button();
            storeName = new Label();
            dashboardPanel = new Panel();
            todaysGrossSalePanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            prodouctsSoldTodayPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            totalProductsSoldPanel = new Panel();
            label5 = new Label();
            label6 = new Label();
            totalRevenuePanel = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            salesButtonPanel.SuspendLayout();
            orderButtonPanel.SuspendLayout();
            panel4.SuspendLayout();
            inventoryButtonPanel.SuspendLayout();
            dashboardButtonPanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            todaysGrossSalePanel.SuspendLayout();
            prodouctsSoldTodayPanel.SuspendLayout();
            totalProductsSoldPanel.SuspendLayout();
            totalRevenuePanel.SuspendLayout();
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
            // salesButtonPanel
            // 
            salesButtonPanel.BackColor = Color.FromArgb(35, 40, 45);
            salesButtonPanel.Controls.Add(orderButtonPanel);
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
            orderButtonPanel.Controls.Add(ordersButton);
            orderButtonPanel.Location = new Point(0, 269);
            orderButtonPanel.Name = "orderButtonPanel";
            orderButtonPanel.Size = new Size(155, 52);
            orderButtonPanel.TabIndex = 2;
            // 
            // ordersButton
            // 
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.ForeColor = SystemColors.ButtonHighlight;
            ordersButton.Location = new Point(3, 3);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(149, 46);
            ordersButton.TabIndex = 0;
            ordersButton.Text = "Orders";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.Click += showOrdersPanel;
            // 
            // panel4
            // 
            panel4.Controls.Add(salesButton);
            panel4.Location = new Point(0, 211);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 52);
            panel4.TabIndex = 2;
            // 
            // salesButton
            // 
            salesButton.FlatAppearance.BorderSize = 0;
            salesButton.FlatStyle = FlatStyle.Flat;
            salesButton.ForeColor = SystemColors.ButtonHighlight;
            salesButton.Location = new Point(3, 3);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(149, 46);
            salesButton.TabIndex = 0;
            salesButton.Text = "Sales";
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += showSalesPanel;
            // 
            // inventoryButtonPanel
            // 
            inventoryButtonPanel.Controls.Add(inventoryButton);
            inventoryButtonPanel.Location = new Point(0, 153);
            inventoryButtonPanel.Name = "inventoryButtonPanel";
            inventoryButtonPanel.Size = new Size(155, 52);
            inventoryButtonPanel.TabIndex = 2;
            // 
            // inventoryButton
            // 
            inventoryButton.FlatAppearance.BorderSize = 0;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.ForeColor = SystemColors.ButtonHighlight;
            inventoryButton.Location = new Point(3, 3);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(149, 46);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += showInventoryPanel;
            // 
            // dashboardButtonPanel
            // 
            dashboardButtonPanel.BackgroundImageLayout = ImageLayout.None;
            dashboardButtonPanel.Controls.Add(dashboardButton);
            dashboardButtonPanel.Location = new Point(0, 95);
            dashboardButtonPanel.Name = "dashboardButtonPanel";
            dashboardButtonPanel.Size = new Size(155, 52);
            dashboardButtonPanel.TabIndex = 1;
            // 
            // dashboardButton
            // 
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.ForeColor = SystemColors.ButtonHighlight;
            dashboardButton.Location = new Point(3, 3);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(149, 46);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += showDashboardPanel;
            // 
            // storeName
            // 
            storeName.BackColor = Color.FromArgb(40, 40, 40);
            storeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ActiveCaption;
            storeName.Location = new Point(0, 9);
            storeName.Name = "storeName";
            storeName.Size = new Size(155, 67);
            storeName.TabIndex = 2;
            storeName.Text = "JFKL Sari-Sari Store";
            storeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.ControlLight;
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
            // todaysGrossSalePanel
            // 
            todaysGrossSalePanel.BackColor = SystemColors.ButtonShadow;
            todaysGrossSalePanel.Controls.Add(label2);
            todaysGrossSalePanel.Controls.Add(label1);
            todaysGrossSalePanel.Location = new Point(119, 93);
            todaysGrossSalePanel.Name = "todaysGrossSalePanel";
            todaysGrossSalePanel.Size = new Size(200, 100);
            todaysGrossSalePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 10);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Today's Gross Sale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 43);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "$";
            // 
            // prodouctsSoldTodayPanel
            // 
            prodouctsSoldTodayPanel.BackColor = SystemColors.ButtonShadow;
            prodouctsSoldTodayPanel.Controls.Add(label3);
            prodouctsSoldTodayPanel.Controls.Add(label4);
            prodouctsSoldTodayPanel.Location = new Point(336, 93);
            prodouctsSoldTodayPanel.Name = "prodouctsSoldTodayPanel";
            prodouctsSoldTodayPanel.Size = new Size(200, 100);
            prodouctsSoldTodayPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 43);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 1;
            label3.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 10);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 0;
            label4.Text = "Products Sold Today";
            label4.Click += label4_Click;
            // 
            // totalProductsSoldPanel
            // 
            totalProductsSoldPanel.BackColor = SystemColors.ButtonShadow;
            totalProductsSoldPanel.Controls.Add(label5);
            totalProductsSoldPanel.Controls.Add(label6);
            totalProductsSoldPanel.Location = new Point(336, 219);
            totalProductsSoldPanel.Name = "totalProductsSoldPanel";
            totalProductsSoldPanel.Size = new Size(200, 100);
            totalProductsSoldPanel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 43);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 1;
            label5.Text = "$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 10);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 0;
            label6.Text = "Total Products Sold";
            // 
            // totalRevenuePanel
            // 
            totalRevenuePanel.BackColor = SystemColors.ButtonShadow;
            totalRevenuePanel.Controls.Add(label7);
            totalRevenuePanel.Controls.Add(label8);
            totalRevenuePanel.Location = new Point(119, 219);
            totalRevenuePanel.Name = "totalRevenuePanel";
            totalRevenuePanel.Size = new Size(200, 100);
            totalRevenuePanel.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 43);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 1;
            label7.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 10);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 0;
            label8.Text = "Total Revenue";
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
            salesButtonPanel.ResumeLayout(false);
            orderButtonPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            inventoryButtonPanel.ResumeLayout(false);
            dashboardButtonPanel.ResumeLayout(false);
            dashboardPanel.ResumeLayout(false);
            todaysGrossSalePanel.ResumeLayout(false);
            todaysGrossSalePanel.PerformLayout();
            prodouctsSoldTodayPanel.ResumeLayout(false);
            prodouctsSoldTodayPanel.PerformLayout();
            totalProductsSoldPanel.ResumeLayout(false);
            totalProductsSoldPanel.PerformLayout();
            totalRevenuePanel.ResumeLayout(false);
            totalRevenuePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel salesButtonPanel;
        private Label storeName;
        private Panel orderButtonPanel;
        private Button ordersButton;
        private Panel panel4;
        private Button salesButton;
        private Panel inventoryButtonPanel;
        private Button inventoryButton;
        private Panel dashboardButtonPanel;
        private Button dashboardButton;
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
    }
}
