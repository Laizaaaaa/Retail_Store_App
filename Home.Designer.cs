namespace EDP
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            header = new Panel();
            store_name = new Label();
            pictureBox1 = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            flowLayoutPanel1 = new FlowLayoutPanel();
            supplierButton = new Button();
            supplierButtonPanel = new Panel();
            panel2 = new Panel();
            dashboardButton = new Button();
            panel3 = new Panel();
            inventoryButton = new Button();
            panel4 = new Panel();
            ordersButton = new Button();
            salesMenuContainer = new FlowLayoutPanel();
            monthlySalesButtonPanel = new Panel();
            monthlySalesButton = new Button();
            weeklySalesButtonPanel = new Panel();
            weeklySalesButton = new Button();
            dailySalesButtonPanel = new Panel();
            dailySalesButton = new Button();
            salesButtonPanel = new Panel();
            salesButton = new Button();
            salesMenuTransition = new System.Windows.Forms.Timer(components);
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            supplierButtonPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            monthlySalesButtonPanel.SuspendLayout();
            weeklySalesButtonPanel.SuspendLayout();
            dailySalesButtonPanel.SuspendLayout();
            salesButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(store_name);
            header.Controls.Add(pictureBox1);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(914, 61);
            header.TabIndex = 0;
            // 
            // store_name
            // 
            store_name.AutoSize = true;
            store_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            store_name.Location = new Point(61, 24);
            store_name.Name = "store_name";
            store_name.Size = new Size(136, 17);
            store_name.TabIndex = 2;
            store_name.Text = "JFKL SARI-SARI STORE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_bar_icon;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(188, 509);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // supplierButton
            // 
            supplierButton.FlatStyle = FlatStyle.Flat;
            supplierButton.Font = new Font("Segoe UI", 9F);
            supplierButton.ForeColor = Color.White;
            supplierButton.Image = Properties.Resources.supplier_icon;
            supplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            supplierButton.Location = new Point(-9, -10);
            supplierButton.Name = "supplierButton";
            supplierButton.Padding = new Padding(25, 0, 0, 0);
            supplierButton.Size = new Size(202, 68);
            supplierButton.TabIndex = 2;
            supplierButton.Text = "             Supplier";
            supplierButton.TextAlign = ContentAlignment.MiddleLeft;
            supplierButton.UseVisualStyleBackColor = true;
            supplierButton.Click += button1_Click;
            // 
            // supplierButtonPanel
            // 
            supplierButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            supplierButtonPanel.Controls.Add(supplierButton);
            supplierButtonPanel.Location = new Point(338, 339);
            supplierButtonPanel.Name = "supplierButtonPanel";
            supplierButtonPanel.Size = new Size(183, 44);
            supplierButtonPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(dashboardButton);
            panel2.Location = new Point(338, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 44);
            panel2.TabIndex = 4;
            // 
            // dashboardButton
            // 
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 9F);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = Properties.Resources.dashboard_icon;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(-9, -10);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(25, 0, 0, 0);
            dashboardButton.Size = new Size(202, 68);
            dashboardButton.TabIndex = 2;
            dashboardButton.Text = "             Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 24, 29);
            panel3.Controls.Add(inventoryButton);
            panel3.Location = new Point(338, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 44);
            panel3.TabIndex = 5;
            // 
            // inventoryButton
            // 
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 9F);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Image = Properties.Resources.inventory_icon1;
            inventoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryButton.Location = new Point(-9, -10);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Padding = new Padding(25, 0, 0, 0);
            inventoryButton.Size = new Size(202, 68);
            inventoryButton.TabIndex = 2;
            inventoryButton.Text = "             Inventory";
            inventoryButton.TextAlign = ContentAlignment.MiddleLeft;
            inventoryButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(23, 24, 29);
            panel4.Controls.Add(ordersButton);
            panel4.Location = new Point(338, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 44);
            panel4.TabIndex = 6;
            // 
            // ordersButton
            // 
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Font = new Font("Segoe UI", 9F);
            ordersButton.ForeColor = Color.White;
            ordersButton.Image = Properties.Resources.order_icon1;
            ordersButton.ImageAlign = ContentAlignment.MiddleLeft;
            ordersButton.Location = new Point(-9, -10);
            ordersButton.Name = "ordersButton";
            ordersButton.Padding = new Padding(25, 0, 0, 0);
            ordersButton.Size = new Size(202, 68);
            ordersButton.TabIndex = 2;
            ordersButton.Text = "             Orders";
            ordersButton.TextAlign = ContentAlignment.MiddleLeft;
            ordersButton.UseVisualStyleBackColor = true;
            // 
            // salesMenuContainer
            // 
            salesMenuContainer.BackColor = Color.FromArgb(23, 24, 29);
            salesMenuContainer.Location = new Point(606, 115);
            salesMenuContainer.Name = "salesMenuContainer";
            salesMenuContainer.Size = new Size(183, 302);
            salesMenuContainer.TabIndex = 0;
            salesMenuContainer.Paint += flowLayoutPanel2_Paint;
            // 
            // monthlySalesButtonPanel
            // 
            monthlySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            monthlySalesButtonPanel.Controls.Add(monthlySalesButton);
            monthlySalesButtonPanel.Location = new Point(0, 0);
            monthlySalesButtonPanel.Margin = new Padding(0);
            monthlySalesButtonPanel.Name = "monthlySalesButtonPanel";
            monthlySalesButtonPanel.Size = new Size(183, 44);
            monthlySalesButtonPanel.TabIndex = 5;
            // 
            // monthlySalesButton
            // 
            monthlySalesButton.FlatStyle = FlatStyle.Flat;
            monthlySalesButton.Font = new Font("Segoe UI", 9F);
            monthlySalesButton.ForeColor = Color.White;
            monthlySalesButton.Image = Properties.Resources.money_icon;
            monthlySalesButton.ImageAlign = ContentAlignment.MiddleLeft;
            monthlySalesButton.Location = new Point(-9, -10);
            monthlySalesButton.Name = "monthlySalesButton";
            monthlySalesButton.Padding = new Padding(25, 0, 0, 0);
            monthlySalesButton.Size = new Size(202, 68);
            monthlySalesButton.TabIndex = 2;
            monthlySalesButton.Text = "             Monthly Sales";
            monthlySalesButton.TextAlign = ContentAlignment.MiddleLeft;
            monthlySalesButton.UseVisualStyleBackColor = true;
            // 
            // weeklySalesButtonPanel
            // 
            weeklySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            weeklySalesButtonPanel.Controls.Add(weeklySalesButton);
            weeklySalesButtonPanel.Location = new Point(0, 85);
            weeklySalesButtonPanel.Margin = new Padding(0);
            weeklySalesButtonPanel.Name = "weeklySalesButtonPanel";
            weeklySalesButtonPanel.Size = new Size(183, 44);
            weeklySalesButtonPanel.TabIndex = 7;
            // 
            // weeklySalesButton
            // 
            weeklySalesButton.FlatStyle = FlatStyle.Flat;
            weeklySalesButton.Font = new Font("Segoe UI", 9F);
            weeklySalesButton.ForeColor = Color.White;
            weeklySalesButton.Image = Properties.Resources.money_icon;
            weeklySalesButton.ImageAlign = ContentAlignment.MiddleLeft;
            weeklySalesButton.Location = new Point(-9, -10);
            weeklySalesButton.Name = "weeklySalesButton";
            weeklySalesButton.Padding = new Padding(25, 0, 0, 0);
            weeklySalesButton.Size = new Size(202, 68);
            weeklySalesButton.TabIndex = 2;
            weeklySalesButton.Text = "            Weekly Sales";
            weeklySalesButton.TextAlign = ContentAlignment.MiddleLeft;
            weeklySalesButton.UseVisualStyleBackColor = true;
            // 
            // dailySalesButtonPanel
            // 
            dailySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            dailySalesButtonPanel.Controls.Add(dailySalesButton);
            dailySalesButtonPanel.Location = new Point(0, 129);
            dailySalesButtonPanel.Margin = new Padding(0);
            dailySalesButtonPanel.Name = "dailySalesButtonPanel";
            dailySalesButtonPanel.Size = new Size(183, 44);
            dailySalesButtonPanel.TabIndex = 6;
            // 
            // dailySalesButton
            // 
            dailySalesButton.FlatStyle = FlatStyle.Flat;
            dailySalesButton.Font = new Font("Segoe UI", 9F);
            dailySalesButton.ForeColor = Color.White;
            dailySalesButton.Image = Properties.Resources.money_icon;
            dailySalesButton.ImageAlign = ContentAlignment.MiddleLeft;
            dailySalesButton.Location = new Point(-9, -10);
            dailySalesButton.Name = "dailySalesButton";
            dailySalesButton.Padding = new Padding(25, 0, 0, 0);
            dailySalesButton.Size = new Size(202, 68);
            dailySalesButton.TabIndex = 2;
            dailySalesButton.Text = "             Daily Sales";
            dailySalesButton.TextAlign = ContentAlignment.MiddleLeft;
            dailySalesButton.UseVisualStyleBackColor = true;
            // 
            // salesButtonPanel
            // 
            salesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            salesButtonPanel.Controls.Add(weeklySalesButtonPanel);
            salesButtonPanel.Controls.Add(salesButton);
            salesButtonPanel.Controls.Add(monthlySalesButtonPanel);
            salesButtonPanel.Controls.Add(dailySalesButtonPanel);
            salesButtonPanel.Location = new Point(606, 115);
            salesButtonPanel.Margin = new Padding(0);
            salesButtonPanel.Name = "salesButtonPanel";
            salesButtonPanel.Size = new Size(183, 44);
            salesButtonPanel.TabIndex = 5;
            // 
            // salesButton
            // 
            salesButton.BackColor = Color.FromArgb(23, 24, 29);
            salesButton.FlatStyle = FlatStyle.Flat;
            salesButton.Font = new Font("Segoe UI", 9F);
            salesButton.ForeColor = Color.White;
            salesButton.Image = Properties.Resources.money_icon;
            salesButton.ImageAlign = ContentAlignment.MiddleLeft;
            salesButton.Location = new Point(-9, -10);
            salesButton.Name = "salesButton";
            salesButton.Padding = new Padding(25, 0, 0, 0);
            salesButton.Size = new Size(202, 68);
            salesButton.TabIndex = 2;
            salesButton.Text = "             Sales";
            salesButton.TextAlign = ContentAlignment.MiddleLeft;
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += salesButton_Click_1;
            // 
            // salesMenuTransition
            // 
            salesMenuTransition.Tick += salesMenuTransition_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(salesButtonPanel);
            Controls.Add(salesMenuContainer);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(supplierButtonPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(header);
            Font = new Font("Segoe UI", 10.2F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            supplierButtonPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            monthlySalesButtonPanel.ResumeLayout(false);
            weeklySalesButtonPanel.ResumeLayout(false);
            dailySalesButtonPanel.ResumeLayout(false);
            salesButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private PictureBox pictureBox1;
        private Label store_name;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button supplierButton;
        private Panel supplierButtonPanel;
        private Panel panel2;
        private Button dashboardButton;
        private Panel panel3;
        private Button inventoryButton;
        private Panel panel4;
        private Button ordersButton;
        private FlowLayoutPanel salesMenuContainer;
        private Panel monthlySalesButtonPanel;
        private Button monthlySalesButton;
        private Panel salesButtonPanel;
        private Button salesButton;
        private Panel weeklySalesButtonPanel;
        private Button weeklySalesButton;
        private Panel dailySalesButtonPanel;
        private Button dailySalesButton;
        private System.Windows.Forms.Timer salesMenuTransition;
    }
}