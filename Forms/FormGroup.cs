using OpcXml.Da10;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Mqtt;
using SmartHomeSideMenubar.SideForms;
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
    public partial class FormGroup : Form
    {
        private MqttHelper mqttHelper;  // Declare an instance of MqttHelper
        private bool mqttConnected = false;  // Flag to track connection status

        public FormGroup()
        {
            InitializeComponent();
            mqttHelper = new MqttHelper();  // Initialize the MqttHelper instance

            LoadGroups();

        }



        private void LoadGroups()
        {
            dataGridViewGroups.Rows.Clear();

            foreach (var group in DbGroupHelper.GetGroups())
            {
                int rowIndex = dataGridViewGroups.Rows.Add();
                dataGridViewGroups.Rows[rowIndex].Cells["columnGroupId"].Value = group.Item1;
                dataGridViewGroups.Rows[rowIndex].Cells["columnGroupName"].Value = group.Item2;
                dataGridViewGroups.Rows[rowIndex].Cells["columnCreatedAtGroup"].Value = group.Item3;
                dataGridViewGroups.Rows[rowIndex].Cells["columnUpdatedAtGroup"].Value = group.Item4;

                // Ensure checkboxes are unchecked
                dataGridViewGroups.Rows[rowIndex].Cells["columnSelectGroup"].Value = false;

                // Assign images instead of text
                dataGridViewGroups.Rows[rowIndex].Cells["btnEditGroup"].Value = "✎";
                dataGridViewGroups.Rows[rowIndex].Cells["btnDeleteGroup"].Value = "🗑";
                bool isGroupOn = DbGroupHelper.IsGroupOn(group.Item1);
                dataGridViewGroups.Rows[rowIndex].Cells["columnPowerStatus"].Value = isGroupOn;
            }
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAllGroups_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete all groups?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DbGroupHelper.DeleteAllGroups();
                    LoadGroups(); // Refresh DataGridView after deleting all groups
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete All Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteSelectedGroups_Click_1(object sender, EventArgs e)
        {
            List<int> selectedGroupIds = new List<int>();

            // Loop through all rows and add selected group IDs to the list
            foreach (DataGridViewRow row in dataGridViewGroups.Rows)
            {
                if (Convert.ToBoolean(row.Cells["columnSelectGroup"].Value)) // If checkbox is checked
                {
                    selectedGroupIds.Add(Convert.ToInt32(row.Cells["columnGroupID"].Value));
                }
            }

            if (selectedGroupIds.Count > 0)
            {
                // Show confirmation before deleting
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete the selected groups?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DbGroupHelper.DeleteSelectedGroups(selectedGroupIds); // Delete the selected groups
                        LoadGroups(); // Refresh the DataGridView after deletion
                        MessageBox.Show("Selected groups deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No groups selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddGroup_Click_1(object sender, EventArgs e)
        {
            using (var form = new GroupAddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadGroups();
                }
            }
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridViewGroups.Columns[e.ColumnIndex].Name;

                if (columnName == "btnEditGroup")
                {
                    int groupId = Convert.ToInt32(dataGridViewGroups.Rows[e.RowIndex].Cells["columnGroupID"].Value);
                    string groupName = dataGridViewGroups.Rows[e.RowIndex].Cells["columnGroupName"].Value.ToString();

                    EditGroupForm editForm = new EditGroupForm(groupId, groupName);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadGroups();
                    }
                }
                else if (columnName == "btnDeleteGroup")
                {
                    int groupId = Convert.ToInt32(dataGridViewGroups.Rows[e.RowIndex].Cells["columnGroupID"].Value);

                    // Prompt confirmation before deleting
                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to delete this group?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            DbGroupHelper.DeleteGroup(groupId);
                            LoadGroups(); // Refresh DataGridView after deleting
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                if (dataGridViewGroups.Columns[e.ColumnIndex].Name == "columnPowerStatus")
                {
                    int groupId = Convert.ToInt32(dataGridViewGroups.Rows[e.RowIndex].Cells["columnGroupID"].Value);
                    string groupName = dataGridViewGroups.Rows[e.RowIndex].Cells["columnGroupName"].Value.ToString(); // Get Group Name
                    bool isChecked = Convert.ToBoolean(dataGridViewGroups.Rows[e.RowIndex].Cells["columnPowerStatus"].EditedFormattedValue);

                    // Update all devices in this group
                    DbDevicesHelper.UpdateDevicesStatusByGroup(groupId, isChecked ? 1 : 0);

                    // Get devices associated with the group
                    var devicesInGroup = DbDevicesHelper.GetDevicesByGroupID(groupId);

                    // Only publish MQTT messages if the group has devices
                    if (devicesInGroup.Any())
                    {
                        // Publish the status change to MQTT for each device
                        if (ConnectToMqttBroker())  // Ensure MQTT connection
                        {
                            foreach (var device in devicesInGroup)
                            {
                                string deviceTopic = $"home/device/{device.DeviceID}/status";
                                mqttHelper.PublishMessage(deviceTopic, isChecked ? "ON" : "OFF");
                                MessageBox.Show(deviceTopic);
                            }
                        }

                        // Show confirmation with Group Name
                        string status = isChecked ? "ON" : "OFF";
                        MessageBox.Show($"All devices in Group '{groupName}' turned {status}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No devices found in Group '{groupName}'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridViewGroups.Rows[e.RowIndex].Cells["columnPowerStatus"].Value = false;  // Undo checkbox change
                        LoadGroups();

                    }
                }
            }
        }
        private bool ConnectToMqttBroker()
        {
            if (!mqttHelper.IsConnected)  // Check if already connected
            {
                bool isConnected = mqttHelper.Connect();  // Connect if not connected
                if (!isConnected)
                {
                    MessageBox.Show("Failed to connect to the MQTT broker.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }





        private void lblHeadergroup_Click(object sender, EventArgs e)
        {

        }

        private void panelGroupGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

