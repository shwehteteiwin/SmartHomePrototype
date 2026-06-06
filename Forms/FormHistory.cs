using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;
using static SmartHomeSideMenubar.DBQuery.DbHistoryHelper;

namespace SmartHomeSideMenubar.Forms
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            LoadHistory();
            StyleDataGridView();

            // Handle delete button clicks.
            dataGridViewHistory.CellContentClick += dataGridViewHistory_CellContentClick;

        }
        private void LoadHistory()
        {
            dataGridViewHistory.Rows.Clear();
            dataGridViewHistory.Columns.Clear();

            // Retrieve history records from DbHistoryHelper.
            List<HistoryRecord> historyRecords = DbHistoryHelper.GetAllHistory();
            //historyRecords.Reverse();

            // Create columns if they haven't been created yet.
            if (dataGridViewHistory.Columns.Count == 0)
            {
                // HistoryID column (read-only)
                dataGridViewHistory.Columns.Add("HistoryID", "HistoryID");
                dataGridViewHistory.Columns["HistoryID"].ReadOnly = true;
                dataGridViewHistory.Columns["HistoryID"].Visible = false;


                // HistoryName column (read-only)
                dataGridViewHistory.Columns.Add("HistoryName", "HistoryName");
                dataGridViewHistory.Columns["HistoryName"].ReadOnly = true;

                // CreatedAt column (read-only)
                dataGridViewHistory.Columns.Add("CreatedAt", "CreatedAt");
                dataGridViewHistory.Columns["CreatedAt"].ReadOnly = true;

                // Delete Button Column
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,

                };
                dataGridViewHistory.Columns.Add(deleteColumn);
            }

            // Add rows for each history record.
            foreach (var record in historyRecords)
            {
                dataGridViewHistory.Rows.Add(record.HistoryID, record.HistoryName, record.CreatedAt);
            }
            foreach (DataGridViewRow row in dataGridViewHistory.Rows)
            {
                row.Height = 65;
            }
        }

        // Handle Delete button click in DataGridView.
        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verify the click is on the Delete button column.
            if (e.RowIndex >= 0 && dataGridViewHistory.Columns[e.ColumnIndex].Name == "Delete")
            {
                int historyId = Convert.ToInt32(dataGridViewHistory.Rows[e.RowIndex].Cells["HistoryID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Delete the history record.
                    DbHistoryHelper.DeleteHistory(historyId);
                    MessageBox.Show("History record deleted successfully!");

                    // Refresh the DataGridView.
                    LoadHistory();
                }
            }
        }
        private void StyleDataGridView()
        {
            // Auto-size columns to fill the grid width.
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set background and grid colors.
            dataGridViewHistory.BackgroundColor = Color.WhiteSmoke;
            dataGridViewHistory.GridColor = Color.LightGray;

            // Style the column headers.
            dataGridViewHistory.ColumnHeadersHeight = 65;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridViewHistory.EnableHeadersVisualStyles = false;

            // Style the cells.
            dataGridViewHistory.DefaultCellStyle.Font = new Font("Verdana", 11);
            dataGridViewHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewHistory.DefaultCellStyle.BackColor = Color.White;

            // Alternate row style.
            dataGridViewHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set row height.
            dataGridViewHistory.RowTemplate.Height = 65;

            // Hide row headers.
            dataGridViewHistory.RowHeadersVisible = false;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all history records?",
    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DbHistoryHelper.DeleteAllHistory();
                MessageBox.Show("All history records deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHistory(); // Refresh the DataGridView
            }
        }
    }
}
