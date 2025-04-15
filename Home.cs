using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace EDP
{
    public partial class Home : Form
    {
        Dashboard dashboard;
        Suppliers suppliers;
        Inventory inventory;
        Orders orders;
        Sales sales;
        YearlySales yearlySales;
        MonthlySales monthlySales;
        WeeklySales weeklySales;
        DailySales dailySales;
        Categories categories;

        public Home()
        {
            InitializeComponent();
        }

        bool sidebarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 67)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    dasboardButtonPanel.Width = sidebarContainer.Width;
                    suppliersButtonPanel.Width = sidebarContainer.Width;
                    inventoryButtonPanel.Width = sidebarContainer.Width;
                    ordersButtonPanel.Width = sidebarContainer.Width;
                    salesMenuContainer.Width = sidebarContainer.Width;
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 188)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    dasboardButtonPanel.Width = sidebarContainer.Width;
                    suppliersButtonPanel.Width = sidebarContainer.Width;
                    inventoryButtonPanel.Width = sidebarContainer.Width;
                    ordersButtonPanel.Width = sidebarContainer.Width;
                    salesMenuContainer.Width = sidebarContainer.Width;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        bool salesMenuExpand = false;

        private void salesMenuTransition_Tick(object sender, EventArgs e)
        {
            if (salesMenuExpand == false)
            {
                salesMenuContainer.Height += 10;
                if (salesMenuContainer.Height >= 220)
                {
                    salesMenuTransition.Stop();
                    salesMenuExpand = true;
                }
            }
            else
            {
                salesMenuContainer.Height -= 10;
                if (salesMenuContainer.Height <= 44)
                {
                    salesMenuTransition.Stop();
                    salesMenuExpand = false;
                }
            }
        }

        private void salesButton_Click_1(object sender, EventArgs e)
        {
            salesMenuTransition.Start();

            if (sales == null)
            {
                sales = new Sales();
                sales.FormClosed += sales_FormClosed;
                sales.MdiParent = this;
                sales.Show();
            }
            else
            {
                sales.Activate();
            }
        }

        private void sales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sales = null;
        }


        private void yearlySalesButton_Click(object sender, EventArgs e)
        {
            if (yearlySales == null)
            {
                yearlySales = new YearlySales();
                yearlySales.FormClosed += yearlySales_FormClosed;
                yearlySales.MdiParent = this;
                yearlySales.Show();
            }
            else
            {
                yearlySales.Activate();
            }
        }

        private void yearlySales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            yearlySales = null;
        }

        private void monthlySalesButton_Click(object sender, EventArgs e)
        {
            if (monthlySales == null)
            {
                monthlySales = new MonthlySales();
                monthlySales.FormClosed += monthlySales_FormClosed;
                monthlySales.MdiParent = this;
                monthlySales.Show();
            }
            else
            {
                monthlySales.Activate();
            }
        }

        private void monthlySales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            monthlySales = null;
        }

        private void weeklySalesButton_Click(object sender, EventArgs e)
        {
            if (weeklySales == null)
            {
                weeklySales = new WeeklySales();
                weeklySales.FormClosed += weeklySales_FormClosed;
                weeklySales.MdiParent = this;
                weeklySales.Show();
            }
            else
            {
                weeklySales.Activate();
            }
        }

        private void weeklySales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            weeklySales = null;
        }

        private void dailySalesButton_Click(object sender, EventArgs e)
        {
            if (dailySales == null)
            {
                dailySales = new DailySales();
                dailySales.FormClosed += dailySales_FormClosed;
                dailySales.MdiParent = this;
                dailySales.Show();
            }
            else
            {
                dailySales.Activate();
            }
        }

        private void dailySales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dailySales = null;
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new Inventory();
                inventory.FormClosed += inventory_FormClosed;
                inventory.MdiParent = this;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
        }

        private void inventory_FormClosed(object? sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            if (suppliers == null)
            {
                suppliers = new Suppliers();
                suppliers.FormClosed += suppliers_FormClosed;
                suppliers.MdiParent = this;
                suppliers.Show();
            }
            else
            {
                suppliers.Activate();
            }
        }

        private void suppliers_FormClosed(object? sender, FormClosedEventArgs e)
        {
            suppliers = null;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new Orders();
                orders.FormClosed += orders_FormClosed;
                orders.MdiParent = this;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }

        private void orders_FormClosed(object? sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            if (categories == null)
            {
                categories = new Categories();
                categories.FormClosed += categories_FormClosed;
                categories.MdiParent = this;
                categories.Show();
            }
            else
            {
                categories.Activate();
            }
        }

        private void categories_FormClosed(object? sender, FormClosedEventArgs e)
        {
            categories = null;
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

    }
}
