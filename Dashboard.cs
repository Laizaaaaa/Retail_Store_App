namespace EDP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                    Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical)) // Can be Horizontal, ForwardDiagonal, etc.
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void totalRevenuePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showSalesPanel(object sender, EventArgs e)
        {

        }

        private void showInventoryPanel(object sender, EventArgs e)
        {

        }

        private void showDashboardPanel(object sender, EventArgs e)
        {

        }

        private void showOrdersPanel(object sender, EventArgs e)
        {

        }

        private void storeName_Click(object sender, EventArgs e)
        {

        }
    }
}
