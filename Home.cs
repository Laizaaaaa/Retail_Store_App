using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void salesButtonGroupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesButton_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesMenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                salesMenuContainer.Height += 10;
                if (salesMenuContainer.Height >= 176)
                {
                    salesMenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                salesMenuContainer.Height -= 10;
                if (salesMenuContainer.Height >= 44)
                {
                    salesMenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void salesButton_Click_1(object sender, EventArgs e)
        {
            salesMenuTransition.Start();
        }
    }
}
