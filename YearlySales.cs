﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class YearlySales : Form
    {
        public YearlySales()
        {
            InitializeComponent();
        }

        private void YearlySales_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadYearlySalesData();
        }
        private void LoadYearlySalesData()
        {
            using (var conn = DBConnection.GetConnection())
            {

                string query = "SELECT * FROM Yearly_Sales_Report";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    yearlySalesGridView.DataSource = dt;
                }
            }
        }
    }
}
