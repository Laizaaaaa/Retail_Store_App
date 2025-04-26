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
    public partial class AddProduct : Form
    {
        private Home homeForm;

        public AddProduct(Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void addProductForm_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush semiTransparentBrush = new SolidBrush(Color.FromArgb(120, Color.Black)))
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);
            }
        }

        private void categoryTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Inventory(homeForm));
        }
    }
}
