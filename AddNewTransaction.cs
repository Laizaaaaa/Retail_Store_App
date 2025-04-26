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
    public partial class AddNewTransaction : Form
    {
        private Home homeForm;

        public AddNewTransaction(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newTransactionLabel_Click(object sender, EventArgs e)
        {

        }
        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void completeTransaction_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Sales(homeForm));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Sales(homeForm));
        }
    }
}
