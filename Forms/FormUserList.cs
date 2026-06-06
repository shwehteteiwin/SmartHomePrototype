using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;

namespace SmartHomeSideMenubar.Forms
{
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
            StyleDataGridView();
            LoadUsers();
            dataGridViewUsers.CellValueChanged += dataGridViewUsers_CellValueChanged;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            dataGridViewUsers.CurrentCellDirtyStateChanged += dataGridViewUsers_CurrentCellDirtyStateChanged;
        }
        // Function to Load User Details into DataGridView
        // Function to Load User Details into DataGridView
        private void LoadUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Columns.Clear();

            // Retrieve users from DbUserHelper
            var users = DbUserHelper.GetAllUsers();

            // Create columns if they haven't been created yet
            if (dataGridViewUsers.Columns.Count == 0)
            {
                dataGridViewUsers.Columns.Add("UserID", "User ID");
                dataGridViewUsers.Columns["UserID"].ReadOnly = true;
                dataGridViewUsers.Columns["UserID"].Visible = false;


                dataGridViewUsers.Columns.Add("Username", "Username");
                dataGridViewUsers.Columns["Username"].ReadOnly = true;

                dataGridViewUsers.Columns.Add("Email", "Email");
                dataGridViewUsers.Columns["Email"].ReadOnly = true;

                // Role ComboBox Column
                DataGridViewComboBoxColumn roleColumn = new DataGridViewComboBoxColumn
                {
                    Name = "Role",
                    HeaderText = "Role",
                    DataPropertyName = "Role",
                    DataSource = new string[] { "User", "Admin" },

                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Segoe UI", 12),
                        BackColor = Color.LightYellow,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                };
                dataGridViewUsers.Columns.Add(roleColumn);

                // Delete Button Column
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Segoe UI", 12),
                        ForeColor = Color.Red,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                };
                dataGridViewUsers.Columns.Add(deleteColumn);
                dataGridViewUsers.EditingControlShowing += (s, e) =>
                {
                    if (dataGridViewUsers.CurrentCell.OwningColumn is DataGridViewComboBoxColumn)
                    {
                        if (e.Control is ComboBox comboBox)
                        {
                            comboBox.Font = new Font("Verdana", 12);
                            comboBox.DropDownHeight = 150;
                            comboBox.IntegralHeight = false; // Ensure full dropdown visibility

                            // Resize ComboBox to match row height
                            comboBox.Margin = new Padding(0);
                            comboBox.Size = new Size(dataGridViewUsers.CurrentCell.Size.Width, 45); // Match row height
                        }
                    }
                };

            }

            // Add rows from the users list
            foreach (var user in users)
            {
                dataGridViewUsers.Rows.Add(
                    user.Id,
                    user.Username,
                    user.Email,
                    user.Role
                );
            }
        }

        // Commit ComboBox changes immediately
        private void dataGridViewUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.IsCurrentCellDirty)
            {
                dataGridViewUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Handle role change in DataGridView (ComboBox change)
        private void dataGridViewUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUsers.Columns["Role"].Index && e.RowIndex >= 0)
            {
                string userId = dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                string newRole = dataGridViewUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();

                // Update the role in the database using DbUserHelper
                DbUserHelper.UpdateUserRole(userId, newRole);
                MessageBox.Show("User role updated successfully!");
            }
        }

        // Handle Delete button click in DataGridView
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUsers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                string userId = dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                string userEmail = dataGridViewUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {userEmail}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Delete the user from the database using DbUserHelper
                    DbUserHelper.DeleteUsers(userId);
                    MessageBox.Show("User deleted successfully!");
                    LoadUsers(); // Refresh the DataGridView
                }
            }
        }
        private void StyleDataGridView()
        {
            // Auto-size columns to fill the grid width
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set background and grid colors
            dataGridViewUsers.BackgroundColor = Color.WhiteSmoke;
            dataGridViewUsers.GridColor = Color.LightGray;

            // Style the column headers
            dataGridViewUsers.ColumnHeadersHeight = 55;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Bold);
            dataGridViewUsers.EnableHeadersVisualStyles = false;

            // Style the cells
            dataGridViewUsers.DefaultCellStyle.Font = new Font("Verdana", 12);
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.White;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;


            // Alternate row style
            dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            // Set row height
            dataGridViewUsers.RowTemplate.Height = 45;
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                row.Height = 45; // Ensure all rows are the same height
            }

            foreach (DataGridViewColumn col in dataGridViewUsers.Columns)
            {
                if (col is DataGridViewComboBoxColumn)
                {
                    ((DataGridViewComboBoxColumn)col).DefaultCellStyle.Font = new Font("Verdana", 12);
                }
            }

            // Remove row header if not needed
            dataGridViewUsers.RowHeadersVisible = false;



        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
