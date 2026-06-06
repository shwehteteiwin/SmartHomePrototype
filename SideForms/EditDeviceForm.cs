using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartHomeSideMenubar.SideForms
{
    public partial class EditDeviceForm : Form
    {
        private int deviceID;

        public EditDeviceForm(int deviceID, string deviceName, int typeId, int groupId, int isReal)
        {
            InitializeComponent();
            this.deviceID = deviceID;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            LoadDeviceTypes(); // Load Types
            LoadDeviceGroups(); // Load Groups

            txtDeviceName.Text = deviceName;
            cmbDeviceType.SelectedValue = typeId;  // Set TypeID
            cmbDeviceGroups.SelectedValue = groupId;  // Set GroupID
            chkIsReal.Checked = isReal == 1; // Convert int to bool
        }

        private void LoadDeviceTypes()
        {
            var types = DbTypeHelper.GetAllTypes(); // Fetch all types

            if (types.Count > 0)
            {
                cmbDeviceType.DataSource = types;
                cmbDeviceType.DisplayMember = "TypeName";
                cmbDeviceType.ValueMember = "TypeID";
            }
        }

        private void LoadDeviceGroups()
        {
            var groups = DbGroupHelper.GetAllGroups(); // Fetch all groups

            if (groups.Count > 0)
            {
                cmbDeviceGroups.DataSource = groups;
                cmbDeviceGroups.DisplayMember = "GroupName";
                cmbDeviceGroups.ValueMember = "GroupID";
            }
        }

     
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string newName = txtDeviceName.Text.Trim();
                bool success = false;

                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Device name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Try parsing selected values (handling potential null issues)
                if (int.TryParse(cmbDeviceType.SelectedValue?.ToString(), out int newTypeId) &&
                    int.TryParse(cmbDeviceGroups.SelectedValue?.ToString(), out int newGroupId))
                {
                    bool newIsReal = chkIsReal.Checked; // Convert bool to int

                    // Update the database
                    success = DbDevicesHelper.UpdateDevice(deviceID, newName, newTypeId, newGroupId, newIsReal);
                }

                // Show result message
                if (success)
                {
                    MessageBox.Show("Device updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update device. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating device: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
