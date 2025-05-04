using System.Data;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class Staff : Form
    {
        private Home homeForm;

        public Staff(Home home)
        {
            InitializeComponent();
            staffGridView.CellContentClick += staffGridView_CellContentClick;
            this.homeForm = home;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT user_id, name AS `Name`, contact_number AS `Contact Number`, email AS `Email`, role AS `Role` FROM users\r\n";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    staffGridView.DataSource = dt;

                    staffGridView.Columns["user_id"].Visible = false;

                    // Add the "Edit" and "Delete" buttons
                    AddButtonColumns();

                    // Adjust the grid size based on data
                    int totalWidth = staffGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
                    + staffGridView.RowHeadersWidth;

                    staffGridView.Width = totalWidth - 20; 

                    staffGridView.Height = staffGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                                           + staffGridView.ColumnHeadersHeight;
                }
            }
        }

        private void AddButtonColumns()
        {
            // Prevent adding duplicate View column
            if (staffGridView.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewColumn = new DataGridViewButtonColumn
                {
                    Name = "View",
                    HeaderText = "View",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                };
                staffGridView.Columns.Add(viewColumn);
            }

            // Prevent adding duplicate Edit column
            if (staffGridView.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                staffGridView.Columns.Add(editColumn);
            }

            // Prevent adding duplicate Delete column
            if (staffGridView.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                staffGridView.Columns.Add(deleteColumn);
            }
        }

        private void staffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int staffId = (int)staffGridView.Rows[e.RowIndex].Cells["user_id"].Value;

                if (e.ColumnIndex == staffGridView.Columns["View"].Index)
                {
                    OpenViewForm(staffId);
                }
                else if (e.ColumnIndex == staffGridView.Columns["Edit"].Index)
                {
                    OpenEditForm(staffId);
                }
                else if (e.ColumnIndex == staffGridView.Columns["Delete"].Index)
                {
                    DeleteStaff(staffId);
                }
            }
        }

        private void OpenViewForm(int staffId)
        {
            homeForm.OpenChildForm(new ViewStaffInformation(homeForm, staffId));
        }


        private void OpenEditForm(int staffId)
        {
            homeForm.OpenChildForm(new EditStaffForm(homeForm, staffId));
            LoadStaffData();  // Reload data after editing
        }

        private void DeleteStaff(int staffId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DBConnection.GetConnection())
                    {
                        string query = "DELETE FROM users WHERE user_id = @staffId";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@staffId", staffId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Staff deleted successfully.");
                                LoadStaffData(); // Reload data after deleting
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete staff.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            homeForm.OpenChildForm(new AddStaff(homeForm));
        }
    }
}
