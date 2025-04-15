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
    public partial class DailySales : Form
    {
        public DailySales()
        {
            InitializeComponent();
        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
