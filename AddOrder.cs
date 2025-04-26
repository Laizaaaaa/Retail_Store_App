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
    public partial class AddOrder : Form
    {
        private Home homeForm;

        public AddOrder(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Orders(homeForm));
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Orders(homeForm));
        }
    }
}
