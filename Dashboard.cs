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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDashboardData();
            LoadBestSellingProductsData();
            LoadDiscountedProductsData();
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

        private void LoadBestSellingProductsData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM best_selling_products";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    bestSellingProductsGridView.DataSource = dt;

                    if (bestSellingProductsGridView.Columns.Contains("ID"))
                    {
                        bestSellingProductsGridView.Columns["ID"].Visible = false;
                    }
                }
            }
        }

        private void LoadDiscountedProductsData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM view_discounted_products";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    discountedProductsGridView.DataSource = dt;

                    if (discountedProductsGridView.Columns.Contains("ID"))
                    {
                        discountedProductsGridView.Columns["ID"].Visible = false;
                    }
                }
            }
        }

        private void totalRevenue_Click(object sender, EventArgs e)
        {

        }

        private void totalProductsSold_Click(object sender, EventArgs e)
        {

        }

        private void totalRevenuePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void discountedProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
