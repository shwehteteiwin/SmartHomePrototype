using SmartHomeSideMenubar.DBQuery;
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
    public partial class TypeAddForm : Form
    {
        public TypeAddForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string typeName = textBoxTypeName.Text.Trim();
            if (!string.IsNullOrEmpty(typeName))
            {
                DbTypeHelper.AddType(typeName);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a type name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
