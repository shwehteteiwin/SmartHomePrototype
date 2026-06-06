using SmartHomeSideMenubar;
using SmartHomeSideMenubar.DBQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;
using SmartHomeSideMenubar.Controls.SmartHomeSideMenubar.Controls;
using SmartHomeSideMenubar.SideForms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using SmartHomeSideMenubar.Mqtt;

namespace SmartHomeSideMenubar.Forms
{
    public partial class FormDevicesControl : Form
    {
        private MqttHelper mqttHelper;  // Declare an instance of MqttHelper
        private bool mqttConnected = false;  // Flag to track connection status


        public FormDevicesControl()
        {
            InitializeComponent();
            dgvDevices.DataError += dgvDevices_DataError; // Handle errors
            mqttHelper = new MqttHelper(); // Initialize mqttHelper only once
            LoadDevices();
        }

        public void LoadDevices(string searchQuery = "")
        {
            try
            {
                List<Device> devices = DbDevicesHelper.GetAllDevices();
                dgvDevices.AutoGenerateColumns = false; // Disable auto-generate columns to ensure control over them
                dgvDevices.Rows.Clear();

                if (devices == null || devices.Count == 0)
                {
                    Console.WriteLine("[DEBUG] No devices found.");
                    return;
                }
                // Create the DataGridViewCheckBoxColumn manually for the "Status" column if it should be a toggle
                // Filter devices based on the search query
                var filteredDevices = devices
                    .Where(d => d.DeviceName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                foreach (var device in filteredDevices)
                {
                    int rowIndex = dgvDevices.Rows.Add();

                    dgvDevices.Rows[rowIndex].Cells["columnDeviceID"].Value = device.DeviceID;
                    dgvDevices.Rows[rowIndex].Cells["columnDeviceName"].Value = device.DeviceName;
                    dgvDevices.Rows[rowIndex].Cells["columnTypesDevice"].Value = device.TypeName; // Store an integer
                    dgvDevices.Rows[rowIndex].Cells["columnTypesID"].Value = device.TypeID; // Store an integer
                    dgvDevices.Rows[rowIndex].Cells["columnIsReal"].Value = device.IsReal;
                    dgvDevices.Rows[rowIndex].Cells["columnGroupID"].Value = device.GroupID;  // Store GroupID for editing
                    dgvDevices.Rows[rowIndex].Cells["columnCreatedAtDevice"].Value = device.Created;
                    dgvDevices.Rows[rowIndex].Cells["columnUpdatedAtDevice"].Value = device.Updated;
                    dgvDevices.Rows[rowIndex].Cells["columnRoomsDevice"].Value = device.GroupName;
                    dgvDevices.Rows[rowIndex].Cells["btnEditDevice"].Value = "✎";
                    dgvDevices.Rows[rowIndex].Cells["btnDeleteDevice"].Value = "🗑";
                    dgvDevices.Rows[rowIndex].Cells["columnStatusDevice"].Value = (device.Status == DeviceStatus.ON) ? true : false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading devices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDevices_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Data error in grid: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm(this);
            addDeviceForm.ShowDialog();

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            List<int> selectedDeviceIds = new List<int>();

            // Loop through all rows and add selected group IDs to the list
            foreach (DataGridViewRow row in dgvDevices.Rows)
            {
                if (Convert.ToBoolean(row.Cells["columnSelectDevice"].Value)) // If checkbox is checked
                {
                    selectedDeviceIds.Add(Convert.ToInt32(row.Cells["columnDeviceID"].Value));
                }
            }

            if (selectedDeviceIds.Count > 0)
            {
                // Show confirmation before deleting
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete the selected devices?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DbDevicesHelper.DeleteSelectedDevices(selectedDeviceIds); // Delete the selected groups
                        LoadDevices(); // Refresh the DataGridView after deletion
                        UpdateDeviceCounts();
                        MessageBox.Show("Selected devices deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No devices selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* private void btnDeleteAll_Click(object sender, EventArgs e)
         {
             DialogResult confirm = MessageBox.Show("Are you sure you want to delete all devices?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

             if (confirm == DialogResult.Yes)
             {
                 try
                 {
                     DbDevicesHelper.DeleteAllDevices();
                     LoadDevices();
                     UpdateDeviceCounts();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex.Message, "Delete All Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }

         }*/

        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        public void HandleDevicesAndMqtt()
        {
            // Create an instance of MqttHelper
            MqttHelper mqttHelper = new MqttHelper();

            // Connect to the MQTT broker
            bool isConnected = mqttHelper.Connect();
            if (!isConnected)
            {
                Console.WriteLine("Failed to connect to the MQTT broker.");
                return;
            }

            // Fetch all devices from the database
            List<Device> devices = DbDevicesHelper.GetAllDevices();

            // Generate MQTT topics for each device
            List<string> mqttTopics = mqttHelper.GenerateMqttTopicsForDevices(devices);

            // Subscribe to the topics
            mqttHelper.SubscribeToDeviceTopics(devices);

            // Example: Publish a message to a device control topic
            mqttHelper.PublishControlMessage(1, "ON"); // For example, control device with DeviceID 1
        }

        private void ProcessMqttMessage(string topic, string message)
        {
            string[] topicParts = topic.Split('/');

            if (topicParts.Length > 3)
            {
                int deviceID = int.Parse(topicParts[2]);  // Extract device ID
                string status = topicParts[3];  // Assuming status is at this position in the topic

                // Update the device status and handle UI/database updates
                /*UpdateDeviceStatusInUI(deviceID, status);
                LoadDevices();
                UpdateDeviceCounts();
                // Display a debug message*/
                MessageBox.Show($"Received MQTT Message:\nTopic: {topic}\nMessage: {message}",
                    "MQTT Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void UpdateDeviceStatusInUI(int deviceID, string status)
        {
            foreach (DataGridViewRow row in dgvDevices.Rows)
            {
                if (Convert.ToInt32(row.Cells["columnDeviceID"].Value) == deviceID)
                {
                    bool newStatus = status == "ON";
                    row.Cells["columnStatusDevice"].Value = newStatus;  // Update UI status

                    // Update the database
                    DeviceStatus deviceStatus = newStatus ? DeviceStatus.ON : DeviceStatus.OFF;
                    DbDevicesHelper.UpdateDeviceStatus(deviceID, deviceStatus);
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

        private void SubscribeToDeviceStatusUpdates()
        {
            if (ConnectToMqttBroker())  // Only connect if not already connected
            {
                List<Device> devices = DbDevicesHelper.GetAllDevices();  // Fetch devices from DB
                foreach (var device in devices)
                {
                    string topic = $"home/device/{device.DeviceID}/status";
                    mqttHelper.SubscribeToTopic(topic);  // Subscribe to each device's status topic

                    // **Show UI Message for Each Subscription**
                    //MessageBox.Show($"Subscribed to: {topic}", "MQTT Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                mqttHelper.SetMessageReceivedHandler((topic, message) =>
                {
                    ProcessMqttMessage(topic, message);  // Process incoming MQTT messages
                });
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Disconnect from MQTT if connected
            if (mqttHelper.IsConnected)
            {
                mqttHelper.Disconnect();  // Disconnect when form is closing
            }
        }


        private void DisconnectMqtt()
        {
            if (mqttConnected)
            {
                mqttHelper.Disconnect();  // Disconnect if connected
                mqttConnected = false;
            }
        }
        private void FormDevicesControl_Load(object sender, EventArgs e)
        {
            SubscribeToDeviceStatusUpdates();  // Subscribe to topics when form loads
            LoadDevices();
            UpdateDeviceCounts();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateDeviceCounts()
        {
            List<Device> devices = DbDevicesHelper.GetAllDevices(); // Get fresh data
            int total = devices.Count;
            int open = devices.Count(d => d.Status == DeviceStatus.ON);
            int closed = devices.Count(d => d.Status == DeviceStatus.OFF);

            lblTotalDevices.Text = $"Total Devices: {total}";
            lblOpenDevices.Text = $"Devices ON: {open}";
            lblClosedDevices.Text = $"Devices OFF: {closed}";

            Console.WriteLine($"DEBUG: Total={total}, ON={open}, OFF={closed}"); // ✅ Debugging
        }

        private void btnAllDevicesStatus_CheckedChanged(object sender, EventArgs e)
        {
            /* CheckBox allDevicesToggle = sender as CheckBox;
             if (allDevicesToggle != null)
             {
                 bool turnOn = allDevicesToggle.Checked; // Check if it should turn ON or OFF
                 DeviceStatus newStatus = turnOn ? DeviceStatus.ON : DeviceStatus.OFF;

                 Console.WriteLine($"Toggling ALL devices to {(turnOn ? "ON" : "OFF")}");

                 // Update all devices in the database
                 DbDevicesHelper.UpdateAllDevicesStatus(newStatus);

                 // Refresh UI to reflect changes
                 LoadDevices();
                 UpdateDeviceCounts();
             }*/
            CheckBox allDevicesToggle = sender as CheckBox;
            if (allDevicesToggle != null)
            {
                bool turnOn = allDevicesToggle.Checked; // Check if it should turn ON or OFF
                DeviceStatus newStatus = turnOn ? DeviceStatus.ON : DeviceStatus.OFF;

                Console.WriteLine($"Toggling ALL devices to {(turnOn ? "ON" : "OFF")}");

                // Get all devices from the database
                List<Device> devices = DbDevicesHelper.GetAllDevices();

                // Update all devices in the database
                DbDevicesHelper.UpdateAllDevicesStatus(newStatus);

                // Refresh UI to reflect changes
                LoadDevices();
                UpdateDeviceCounts();

                // **Send MQTT messages only for real devices**
                if (ConnectToMqttBroker()) // Ensure MQTT is connected
                {
                    foreach (var device in devices)
                    {
                        if (device.IsReal) // Only send for real devices
                        {
                            string topic = $"home/device/{device.DeviceID}/status";
                            string message = newStatus == DeviceStatus.ON ? "ON" : "OFF";
                            mqttHelper.PublishMessage(topic, message);
                        }
                    }

                }
                LoadDevices();

                UpdateDeviceCounts();

            }
        }

        private void lblOpenDevices_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchDevice_TextChanged_1(object sender, EventArgs e)
        {
            LoadDevices(txtSearchDevice.Text); // Pass the search text to filter devices
        }

        private void panelGroupGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDevices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDevices.Rows[e.RowIndex];

                // **Toggle Device Status**
                if (dgvDevices.Columns[e.ColumnIndex].Name == "columnStatusDevice")
                {
                    try
                    {
                        int deviceID = Convert.ToInt32(row.Cells["columnDeviceID"].Value);
                        bool currentStatus = Convert.ToBoolean(row.Cells["columnStatusDevice"].Value);
                        bool isReal = Convert.ToBoolean(row.Cells["columnIsReal"].Value);  // Check if real or virtual
                        // Toggle Status
                        DeviceStatus newStatus = currentStatus ? DeviceStatus.OFF : DeviceStatus.ON;
                        row.Cells["columnStatusDevice"].Value = !currentStatus; // Update UI first

                        // Debugging - Check status before publishing to MQTT
                        //MessageBox.Show($"Current Status: {currentStatus}\nNew Status: {newStatus}", "Status Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update database (no return value expected)
                        DbDevicesHelper.UpdateDeviceStatus(deviceID, newStatus);
                        LoadDevices();
                        UpdateDeviceCounts();
                        if (isReal) // Only publish MQTT for real devices
                        {
                            if (ConnectToMqttBroker())
                            {
                                string topic = $"home/device/{deviceID}/status";
                                string message = newStatus == DeviceStatus.ON ? "ON" : "OFF";
                                mqttHelper.PublishMessage(topic, message);
                                MessageBox.Show($"Sent MQTT Message:\nTopic: {topic}\nMessage: {message}", "MQTT Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Virtual device status updated in UI only.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //For virtual mqtt
                        // **Publish the status change to MQTT**
                        //if (ConnectToMqttBroker())  // Ensure we are connected to MQTT
                        //{
                        //    string topic = $"home/device/{deviceID}/status";
                        //    string message = newStatus == DeviceStatus.ON ? "ON" : "OFF";
                        //    mqttHelper.PublishMessage(topic, message);

                        //    // Show message box with topic and message sent
                        //    MessageBox.Show($"Publishing to MQTT topic: {topic}\nMessage: {message}", "MQTT Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //    MessageBox.Show("Device status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


                //edit devices
                else if (dgvDevices.Columns[e.ColumnIndex].Name == "btnEditDevice")
                {
                    try
                    {
                        int deviceID = Convert.ToInt32(row.Cells["columnDeviceID"].Value);
                        string deviceName = row.Cells["columnDeviceName"].Value.ToString();
                        string selectedTypeName = row.Cells["columnTypesDevice"].Value.ToString();
                        string selectedGroupName = row.Cells["columnRoomsDevice"].Value.ToString();

                        int typeId = GetTypeIDByName(selectedTypeName);
                        int groupId = GetGroupIDByName(selectedGroupName);

                        // If IDs are invalid, show error
                        if (typeId == -1)
                        {
                            MessageBox.Show("Invalid Type Name: " + selectedTypeName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (groupId == -1)
                        {
                            MessageBox.Show("Invalid Group Name: " + selectedGroupName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int IsReal = Convert.ToInt32(row.Cells["columnIsReal"].Value);

                        // Open the Edit Device Form with correct IDs
                        EditDeviceForm editForm = new EditDeviceForm(deviceID, deviceName, typeId, groupId, IsReal);

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDevices();
                            MessageBox.Show("Device updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error editing device: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }





                // **Delete Device**
                else if (dgvDevices.Columns[e.ColumnIndex].Name == "btnDeleteDevice")
                {
                    try
                    {
                        int deviceID = Convert.ToInt32(row.Cells["columnDeviceID"].Value);

                        // Confirm delete
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this device?", "Confirm Delete",
                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // Delete from database
                            DbDevicesHelper.DeleteDevice(deviceID);

                            // Remove from UI
                            dgvDevices.Rows.RemoveAt(e.RowIndex);

                            MessageBox.Show("Device deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting device: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
    }

}
    

