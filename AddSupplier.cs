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
    public partial class AddSupplier : Form
    {
        private Home homeForm;

        public AddSupplier(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Suppliers(homeForm));
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Suppliers(homeForm));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
