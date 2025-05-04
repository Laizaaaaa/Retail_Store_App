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
        LoginForm loginForm;

        public Home()
        {
            InitializeComponent();
            OpenChildForm(new Dashboard());
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
            OpenChildForm(new Dashboard());
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
                    logoutBtn.Margin = new Padding(3, 90, 3, 3);
                }
            }
            else
            {
                salesMenuContainer.Height -= 10;


                if (salesMenuContainer.Height <= 44)
                {
                    salesMenuTransition.Stop();
                    salesMenuExpand = false;
                    logoutBtn.Margin = new Padding(3, 270, 3, 3);
                }
            }
        }


        private void salesButton_Click_1(object sender, EventArgs e)
        {
            salesMenuTransition.Start();

            OpenChildForm(new Sales(this));
        }

        private void yearlySalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YearlySales());
        }

        private void monthlySalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MonthlySales());
        }

        private void weeklySalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WeeklySales());
        }
        private void dailySalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailySales());
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory(this));
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Suppliers(this));
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Orders(this));
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Categories());
        }
        private void staffButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff(this));
        }

        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.FormClosed += (s, e) => { activeForm = null; };
            childForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            exitFullScreenButton.Visible = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizeButton.Visible = false;
            exitFullScreenButton.Visible = true;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitFullScreenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizeButton.Visible = true;
            exitFullScreenButton.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
