using System.Data;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    dashboardPanel.ClientRectangle,
                    Color.FromArgb(255, 100, 149, 237), // Start color (Cornflower Blue)
                    Color.FromArgb(255, 72, 61, 139),   // End color (Dark Slate Blue)
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical)) // Can be Horizontal, ForwardDiagonal, etc.
            {
                e.Graphics.FillRectangle(brush, dashboardPanel.ClientRectangle);
            }
        }

    }
}
