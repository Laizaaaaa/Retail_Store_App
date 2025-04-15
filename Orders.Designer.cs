namespace EDP
{
    partial class Orders
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
            ordersGridView = new DataGridView();
            orderItemsGridView = new DataGridView();
            ordersPanel = new Panel();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            ordersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.AllowUserToAddRows = false;
            ordersGridView.AllowUserToDeleteRows = false;
            ordersGridView.AllowUserToResizeColumns = false;
            ordersGridView.AllowUserToResizeRows = false;
            ordersGridView.BackgroundColor = Color.WhiteSmoke;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(21, 84);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersVisible = false;
            ordersGridView.Size = new Size(340, 380);
            ordersGridView.TabIndex = 1;
            // 
            // orderItemsGridView
            // 
            orderItemsGridView.AllowUserToAddRows = false;
            orderItemsGridView.AllowUserToDeleteRows = false;
            orderItemsGridView.AllowUserToResizeColumns = false;
            orderItemsGridView.AllowUserToResizeRows = false;
            orderItemsGridView.BackgroundColor = Color.WhiteSmoke;
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.Location = new Point(367, 84);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersVisible = false;
            orderItemsGridView.Size = new Size(340, 380);
            orderItemsGridView.TabIndex = 2;
            // 
            // ordersPanel
            // 
            ordersPanel.Controls.Add(label1);
            ordersPanel.Controls.Add(label3);
            ordersPanel.Controls.Add(orderItemsGridView);
            ordersPanel.Controls.Add(ordersGridView);
            ordersPanel.Dock = DockStyle.Fill;
            ordersPanel.Location = new Point(0, 0);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(730, 510);
            ordersPanel.TabIndex = 4;
            ordersPanel.Paint += ordersPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(512, 43);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Order Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(180, 43);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Orders";
            // 
            // Orders
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(730, 510);
            Controls.Add(ordersPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            ordersPanel.ResumeLayout(false);
            ordersPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ordersGridView;
        private DataGridView orderItemsGridView;
        private Panel ordersPanel;
        private Label label1;
        private Label label3;
    }
}