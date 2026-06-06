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
    public partial class EditTypeForm : Form
    {
        public int TypeID { get; set; }  // Store Type ID (hidden)
        public string TypeName { get; set; }  // Store Type Name

        public EditTypeForm(int typeId, string typeName)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            TypeID = typeId;
            textBoxTypeName.Text = typeName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTypeName.Text))
            {
                MessageBox.Show("Type Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update Type in database (Replace this with actual database update logic)
            DbTypeHelper.UpdateType(TypeID, textBoxTypeName.Text);

            MessageBox.Show("Typep updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
