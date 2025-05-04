using System;
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
    public partial class ViewStaffInformation : Form
    {
        private int staffId;
        private Home homeForm;
        public ViewStaffInformation(Home home, int id)
        {
            InitializeComponent();
            this.homeForm = home;
            this.staffId = id;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new Staff(homeForm));
        }

        private void viewStaffInformation_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT name, contact_number, email, role FROM users WHERE user_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", staffId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nameTxtbox.Text = reader.GetString("name");
                                contactNumberTxtbox.Text = reader.GetString("contact_number");
                                emailTxtbox.Text = reader.GetString("email");
                                roleTxtbox.Text = reader.GetString("role");
                            }
                            else
                            {
                                MessageBox.Show("Staff not found.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
