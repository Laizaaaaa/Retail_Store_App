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
            menuButton = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            sidebarContainer = new FlowLayoutPanel();
            dasboardButtonPanel = new Panel();
            dashboardButton = new Button();
            salesMenuContainer = new FlowLayoutPanel();
            salesButtonPanel = new Panel();
            salesButton = new Button();
            dailySalesButtonPanel = new Panel();
            dailySalesButton = new Button();
            weeklySalesButtonPanel = new Panel();
            weeklySalesButton = new Button();
            monthlySalesButtonPanel = new Panel();
            monthlySalesButton = new Button();
            yearlySalesButtonPanel = new Panel();
            yearlySalesButton = new Button();
            suppliersButtonPanel = new Panel();
            suppliersButton = new Button();
            inventoryButtonPanel = new Panel();
            inventoryButton = new Button();
            ordersButtonPanel = new Panel();
            ordersButton = new Button();
            categoriesButtonPanel = new Panel();
            categoriesButton = new Button();
            salesMenuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebarContainer.SuspendLayout();
            dasboardButtonPanel.SuspendLayout();
            salesMenuContainer.SuspendLayout();
            salesButtonPanel.SuspendLayout();
            dailySalesButtonPanel.SuspendLayout();
            weeklySalesButtonPanel.SuspendLayout();
            monthlySalesButtonPanel.SuspendLayout();
            yearlySalesButtonPanel.SuspendLayout();
            suppliersButtonPanel.SuspendLayout();
            inventoryButtonPanel.SuspendLayout();
            ordersButtonPanel.SuspendLayout();
            categoriesButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(store_name);
            header.Controls.Add(menuButton);
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
            // menuButton
            // 
            menuButton.Image = Properties.Resources.menu_bar_icon;
            menuButton.Location = new Point(12, 13);
            menuButton.Margin = new Padding(3, 4, 3, 4);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(35, 39);
            menuButton.SizeMode = PictureBoxSizeMode.CenterImage;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(23, 24, 29);
            sidebarContainer.Controls.Add(dasboardButtonPanel);
            sidebarContainer.Controls.Add(salesMenuContainer);
            sidebarContainer.Controls.Add(suppliersButtonPanel);
            sidebarContainer.Controls.Add(inventoryButtonPanel);
            sidebarContainer.Controls.Add(ordersButtonPanel);
            sidebarContainer.Controls.Add(categoriesButtonPanel);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.FlowDirection = FlowDirection.TopDown;
            sidebarContainer.Location = new Point(0, 61);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Padding = new Padding(0, 50, 0, 0);
            sidebarContainer.Size = new Size(188, 509);
            sidebarContainer.TabIndex = 1;
            // 
            // dasboardButtonPanel
            // 
            dasboardButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            dasboardButtonPanel.Controls.Add(dashboardButton);
            dasboardButtonPanel.Location = new Point(3, 53);
            dasboardButtonPanel.Name = "dasboardButtonPanel";
            dasboardButtonPanel.Size = new Size(183, 44);
            dasboardButtonPanel.TabIndex = 4;
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
            dashboardButton.Click += dashboardButton_Click;
            // 
            // salesMenuContainer
            // 
            salesMenuContainer.BackColor = Color.FromArgb(23, 24, 29);
            salesMenuContainer.Controls.Add(salesButtonPanel);
            salesMenuContainer.Controls.Add(dailySalesButtonPanel);
            salesMenuContainer.Controls.Add(weeklySalesButtonPanel);
            salesMenuContainer.Controls.Add(monthlySalesButtonPanel);
            salesMenuContainer.Controls.Add(yearlySalesButtonPanel);
            salesMenuContainer.Location = new Point(3, 103);
            salesMenuContainer.Name = "salesMenuContainer";
            salesMenuContainer.Size = new Size(183, 44);
            salesMenuContainer.TabIndex = 0;
            // 
            // salesButtonPanel
            // 
            salesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            salesButtonPanel.Controls.Add(salesButton);
            salesButtonPanel.Location = new Point(0, 0);
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
            // dailySalesButtonPanel
            // 
            dailySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            dailySalesButtonPanel.Controls.Add(dailySalesButton);
            dailySalesButtonPanel.Location = new Point(0, 44);
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
            dailySalesButton.Click += dailySalesButton_Click;
            // 
            // weeklySalesButtonPanel
            // 
            weeklySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            weeklySalesButtonPanel.Controls.Add(weeklySalesButton);
            weeklySalesButtonPanel.Location = new Point(0, 88);
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
            weeklySalesButton.Click += weeklySalesButton_Click;
            // 
            // monthlySalesButtonPanel
            // 
            monthlySalesButtonPanel.BackColor = Color.FromArgb(32, 33, 36);
            monthlySalesButtonPanel.Controls.Add(monthlySalesButton);
            monthlySalesButtonPanel.Location = new Point(0, 132);
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
            monthlySalesButton.Click += monthlySalesButton_Click;
            // 
            // yearlySalesButtonPanel
            // 
            yearlySalesButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            yearlySalesButtonPanel.Controls.Add(yearlySalesButton);
            yearlySalesButtonPanel.Location = new Point(0, 176);
            yearlySalesButtonPanel.Margin = new Padding(0);
            yearlySalesButtonPanel.Name = "yearlySalesButtonPanel";
            yearlySalesButtonPanel.Size = new Size(183, 44);
            yearlySalesButtonPanel.TabIndex = 7;
            // 
            // yearlySalesButton
            // 
            yearlySalesButton.BackColor = Color.FromArgb(32, 33, 36);
            yearlySalesButton.FlatStyle = FlatStyle.Flat;
            yearlySalesButton.Font = new Font("Segoe UI", 9F);
            yearlySalesButton.ForeColor = Color.White;
            yearlySalesButton.Image = Properties.Resources.money_icon;
            yearlySalesButton.ImageAlign = ContentAlignment.MiddleLeft;
            yearlySalesButton.Location = new Point(-9, -11);
            yearlySalesButton.Name = "yearlySalesButton";
            yearlySalesButton.Padding = new Padding(25, 0, 0, 0);
            yearlySalesButton.Size = new Size(202, 68);
            yearlySalesButton.TabIndex = 2;
            yearlySalesButton.Text = "             Yearly Sales";
            yearlySalesButton.TextAlign = ContentAlignment.MiddleLeft;
            yearlySalesButton.UseVisualStyleBackColor = false;
            yearlySalesButton.Click += yearlySalesButton_Click;
            // 
            // suppliersButtonPanel
            // 
            suppliersButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            suppliersButtonPanel.Controls.Add(suppliersButton);
            suppliersButtonPanel.Location = new Point(3, 153);
            suppliersButtonPanel.Name = "suppliersButtonPanel";
            suppliersButtonPanel.Size = new Size(183, 44);
            suppliersButtonPanel.TabIndex = 3;
            // 
            // suppliersButton
            // 
            suppliersButton.FlatStyle = FlatStyle.Flat;
            suppliersButton.Font = new Font("Segoe UI", 9F);
            suppliersButton.ForeColor = Color.White;
            suppliersButton.Image = Properties.Resources.supplier_icon;
            suppliersButton.ImageAlign = ContentAlignment.MiddleLeft;
            suppliersButton.Location = new Point(-9, -10);
            suppliersButton.Name = "suppliersButton";
            suppliersButton.Padding = new Padding(25, 0, 0, 0);
            suppliersButton.Size = new Size(202, 68);
            suppliersButton.TabIndex = 2;
            suppliersButton.Text = "             Suppliers";
            suppliersButton.TextAlign = ContentAlignment.MiddleLeft;
            suppliersButton.UseVisualStyleBackColor = true;
            suppliersButton.Click += suppliersButton_Click;
            // 
            // inventoryButtonPanel
            // 
            inventoryButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            inventoryButtonPanel.Controls.Add(inventoryButton);
            inventoryButtonPanel.Location = new Point(3, 203);
            inventoryButtonPanel.Name = "inventoryButtonPanel";
            inventoryButtonPanel.Size = new Size(183, 44);
            inventoryButtonPanel.TabIndex = 5;
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
            inventoryButton.Click += inventoryButton_Click;
            // 
            // ordersButtonPanel
            // 
            ordersButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            ordersButtonPanel.Controls.Add(ordersButton);
            ordersButtonPanel.Location = new Point(3, 253);
            ordersButtonPanel.Name = "ordersButtonPanel";
            ordersButtonPanel.Size = new Size(183, 44);
            ordersButtonPanel.TabIndex = 6;
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
            ordersButton.Click += ordersButton_Click;
            // 
            // categoriesButtonPanel
            // 
            categoriesButtonPanel.BackColor = Color.FromArgb(23, 24, 29);
            categoriesButtonPanel.Controls.Add(categoriesButton);
            categoriesButtonPanel.Location = new Point(3, 303);
            categoriesButtonPanel.Name = "categoriesButtonPanel";
            categoriesButtonPanel.Size = new Size(183, 44);
            categoriesButtonPanel.TabIndex = 7;
            // 
            // categoriesButton
            // 
            categoriesButton.FlatStyle = FlatStyle.Flat;
            categoriesButton.Font = new Font("Segoe UI", 9F);
            categoriesButton.ForeColor = Color.White;
            categoriesButton.Image = Properties.Resources.categories_icon;
            categoriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            categoriesButton.Location = new Point(-9, -10);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Padding = new Padding(25, 0, 0, 0);
            categoriesButton.Size = new Size(202, 68);
            categoriesButton.TabIndex = 2;
            categoriesButton.Text = "             Categories";
            categoriesButton.TextAlign = ContentAlignment.MiddleLeft;
            categoriesButton.UseVisualStyleBackColor = true;
            categoriesButton.Click += categoriesButton_Click;
            // 
            // salesMenuTransition
            // 
            salesMenuTransition.Interval = 10;
            salesMenuTransition.Tick += salesMenuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(914, 570);
            Controls.Add(sidebarContainer);
            Controls.Add(header);
            Font = new Font("Segoe UI", 10.2F);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebarContainer.ResumeLayout(false);
            dasboardButtonPanel.ResumeLayout(false);
            salesMenuContainer.ResumeLayout(false);
            salesButtonPanel.ResumeLayout(false);
            dailySalesButtonPanel.ResumeLayout(false);
            weeklySalesButtonPanel.ResumeLayout(false);
            monthlySalesButtonPanel.ResumeLayout(false);
            yearlySalesButtonPanel.ResumeLayout(false);
            suppliersButtonPanel.ResumeLayout(false);
            inventoryButtonPanel.ResumeLayout(false);
            ordersButtonPanel.ResumeLayout(false);
            categoriesButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private PictureBox menuButton;
        private Label store_name;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FlowLayoutPanel sidebarContainer;
        private Button suppliersButton;
        private Panel suppliersButtonPanel;
        private Panel dasboardButtonPanel;
        private Button dashboardButton;
        private Panel inventoryButtonPanel;
        private Button inventoryButton;
        private Panel ordersButtonPanel;
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
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel categoriesButtonPanel;
        private Button categoriesButton;
        private Panel yearlySalesButtonPanel;
        private Button yearlySalesButton;
    }
}