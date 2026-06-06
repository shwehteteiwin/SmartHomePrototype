using SmartHomeSideMenubar.DBQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHomeSideMenubar.SideForms
{
    public partial class EditGroupForm : Form
    {
        public int GroupID { get; set; }  // Store Group ID (hidden)
        public string GroupName { get; set; }  // Store Group Name

        public EditGroupForm(int groupId, string groupName)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            GroupID = groupId;
            textBoxGroupName.Text = groupName; // Pre-fill the text box
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGroupName.Text))
            {
                MessageBox.Show("Group Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update group in database (Replace this with actual database update logic)
            DbGroupHelper.UpdateGroup(GroupID, textBoxGroupName.Text);

            MessageBox.Show("Group updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

