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
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, dashboardPanel.ClientRectangle);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using (var conn = DBConnection.GetConnection())
            {
                //Total Revenue
                using (var cmd = new MySqlCommand("SELECT SUM(total_sales) FROM Daily_Sales_Report", conn))
                {
                    object result = cmd.ExecuteScalar();
                    totalRevenue.Text = result != DBNull.Value ? $"${Convert.ToDecimal(result):N2}" : "$0.00";
                }

                // Total Products Sold
                using (var cmd = new MySqlCommand("SELECT SUM(total_items_sold) FROM Daily_Sales_Report", conn))
                {
                    object result = cmd.ExecuteScalar();
                    totalProductsSold.Text = result != DBNull.Value ? result.ToString() : "0";
                }

                // Today's Gross Sale
                using (var cmd = new MySqlCommand("SELECT SUM(total_sales) FROM Daily_Sales_Report WHERE date(date) = CURDATE()", conn))
                {
                    object result = cmd.ExecuteScalar();
                    todaysGrossSale.Text = result != DBNull.Value ? $"${Convert.ToDecimal(result):N2}" : "$0.00";
                }

                // Products Sold Today
                using (var cmd = new MySqlCommand("SELECT SUM(total_items_sold) FROM Daily_Sales_Report WHERE date(date) = CURDATE()", conn))
                {
                    object result = cmd.ExecuteScalar();
                    productsSoldToday.Text = result != DBNull.Value ? result.ToString() : "0";
                }
            }
        }
    }
}
