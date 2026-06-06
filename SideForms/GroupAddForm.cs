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

namespace SmartHomeSideMenubar.Forms
{
    public partial class GroupAddForm : Form
    {
        public GroupAddForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string groupName = textBoxGroupName.Text.Trim();
            if (!string.IsNullOrEmpty(groupName))
            {
                DbGroupHelper.AddGroup(groupName);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a group name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
