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
    public partial class FormType : Form
    {
        private MqttHelper mqttHelper;  // Declare an instance of MqttHelper
        private bool mqttConnected = false;  // Flag to track connection status
        public FormType()
        {
            InitializeComponent();
            // Define columns for Types DataGridView
            mqttHelper = new MqttHelper();  // Initialize the MqttHelper instance

            LoadTypes();

        }

        private void FormType_Load(object sender, EventArgs e)
        {

        }




        private void buttonAddType_Click(object sender, EventArgs e)
        {
            using (var form = new TypeAddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadTypes();
                }
            }
        }
        private void LoadTypes()
        {
            dataGridViewTypes.Rows.Clear();

            foreach (var type in DbTypeHelper.GetTypes())
            {
                int rowIndex = dataGridViewTypes.Rows.Add();
                dataGridViewTypes.Rows[rowIndex].Cells["columnTypeID"].Value = type.Item1;
                dataGridViewTypes.Rows[rowIndex].Cells["columnTypeName"].Value = type.Item2;
                dataGridViewTypes.Rows[rowIndex].Cells["columnCreatedATType"].Value = type.Item3;
                dataGridViewTypes.Rows[rowIndex].Cells["columnUpdatedATType"].Value = type.Item4;


                // Ensure checkboxes are unchecked
                dataGridViewTypes.Rows[rowIndex].Cells["columnSelectType"].Value = false;

                // Set "Edit" and "Delete" buttons properly
                dataGridViewTypes.Rows[rowIndex].Cells["btnEditType"].Value = "✎";
                dataGridViewTypes.Rows[rowIndex].Cells["btnDeleteType"].Value = "🗑";
                bool isTypeOn = DbTypeHelper.IsTypeOn(type.Item1);

                dataGridViewTypes.Rows[rowIndex].Cells["columnPowerStatus"].Value = isTypeOn;
            }
        }

        private void buttonDeleteAllType_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete all types?", "Confirm Delete All",
MessageBoxButtons.YesNo,
MessageBoxIcon.Warning
);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DbTypeHelper.DeleteAllTypes();
                    LoadTypes(); // Refresh DataGridView after deleting all groups
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete All Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteSelectedType_Click(object sender, EventArgs e)
        {
            List<int> selectedTypesIds = new List<int>();

            // Loop through all rows and add selected group IDs to the list
            foreach (DataGridViewRow row in dataGridViewTypes.Rows)
            {
                if (Convert.ToBoolean(row.Cells["columnSelectType"].Value)) // If checkbox is checked
                {
                    selectedTypesIds.Add(Convert.ToInt32(row.Cells["columnTypeID"].Value));
                }
            }

            if (selectedTypesIds.Count > 0)
            {
                // Show confirmation before deleting
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete the selected types?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DbTypeHelper.DeleteSelectedTypes(selectedTypesIds); // Delete the selected groups
                        LoadTypes(); // Refresh the DataGridView after deletion
                        MessageBox.Show("Selected types deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No types selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridViewTypes.Columns[e.ColumnIndex].Name;

                if (columnName == "btnEditType")
                {
                    int typeId = Convert.ToInt32(dataGridViewTypes.Rows[e.RowIndex].Cells["columnTypeID"].Value);
                    string typeName = dataGridViewTypes.Rows[e.RowIndex].Cells["columnTypeName"].Value.ToString();

                    EditTypeForm editForm = new EditTypeForm(typeId, typeName);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTypes();
                    }
                }
                else if (columnName == "btnDeleteType")
                {
                    int typeId = Convert.ToInt32(dataGridViewTypes.Rows[e.RowIndex].Cells["columnTypeID"].Value);

                    // Prompt confirmation before deleting
                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to delete this type?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            DbTypeHelper.DeleteType(typeId);
                            LoadTypes(); // Refresh DataGridView after deleting
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (dataGridViewTypes.Columns[e.ColumnIndex].Name == "columnPowerStatus")
                {
                    int typeId = Convert.ToInt32(dataGridViewTypes.Rows[e.RowIndex].Cells["columnTypeID"].Value);
                    string typeName = dataGridViewTypes.Rows[e.RowIndex].Cells["columnTypeName"].Value.ToString(); // Get Group Name
                    bool isChecked = Convert.ToBoolean(dataGridViewTypes.Rows[e.RowIndex].Cells["columnPowerStatus"].EditedFormattedValue);

                    // Update all devices in this group
                    DbDevicesHelper.UpdateDevicesStatusByType(typeId, isChecked ? 1 : 0);
                    var devicesInType = DbDevicesHelper.GetDevicesByTypeID(typeId);

                    // Only publish MQTT messages if the group has devices
                    if (devicesInType.Any())
                    {
                        // Publish the status change to MQTT for each device
                        if (ConnectToMqttBroker())  // Ensure MQTT connection
                        {
                            foreach (var device in devicesInType)
                            {
                                string deviceTopic = $"home/device/{device.DeviceID}/status";
                                mqttHelper.PublishMessage(deviceTopic, isChecked ? "ON" : "OFF");
                                MessageBox.Show(deviceTopic);
                            }
                        }

                        // Show confirmation with type Name
                        string status = isChecked ? "ON" : "OFF";
                        MessageBox.Show($"All devices in Type '{typeName}' turned {status}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No devices found in Group '{typeName}'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        dataGridViewTypes.Rows[e.RowIndex].Cells["columnPowerStatus"].Value = false;  // Undo checkbox change
                        LoadTypes();
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
    }
}
