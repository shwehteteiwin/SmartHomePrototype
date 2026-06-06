using SmartHomeSideMenubar;
using SmartHomeSideMenubar.DBQuery;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;

namespace main.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDevices();  // Load UI elements
            UpdateDeviceCounts(); // Update counts on load
        }

        private void LoadDevices()
        {
            flpDevices.Controls.Clear();
            List<Device> devices = DbDevicesHelper.GetAllDevices(); // Always get latest data

            foreach (var device in devices)
            {
                Console.WriteLine($"Loading Device {device.Id}, Name: {device.DeviceName}, Status: {device.Status}");

                Panel panel = new Panel
                {
                    Width = 150,
                    Height = 80,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label lblName = new Label
                {
                    Text = device.DeviceName,
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                CheckBox toggleSwitch = new CheckBox
                {
                    Checked = (device.Status == DeviceStatus.ON), // ✅ Make sure latest status is reflected
                    Text = "ON/OFF",
                    Location = new Point(10, 40),
                    Tag = device.Id
                };

                toggleSwitch.CheckedChanged += ToggleSwitch_CheckedChanged;

                panel.Controls.Add(lblName);
                panel.Controls.Add(toggleSwitch);
                flpDevices.Controls.Add(panel);
            }

            // ✅ Ensure "All Devices" toggle updates correctly
            bool allOn = devices.All(d => d.Status == DeviceStatus.ON);
            bool allOff = devices.All(d => d.Status == DeviceStatus.OFF);

            btnAllDevicesStatus.CheckedChanged -= btnAllDevicesStatus_CheckedChanged;
            btnAllDevicesStatus.Checked = allOn;
            btnAllDevicesStatus.CheckedChanged += btnAllDevicesStatus_CheckedChanged;
        }

        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox toggleSwitch = sender as CheckBox;
            if (toggleSwitch != null)
            {
                int deviceId = (int)toggleSwitch.Tag;
                DeviceStatus newStatus = toggleSwitch.Checked ? DeviceStatus.ON : DeviceStatus.OFF;

                Console.WriteLine($"Toggling Device {deviceId} to {(newStatus == DeviceStatus.ON ? "ON" : "OFF")}");

                // ✅ Update the database
                DbDevicesHelper.UpdateDeviceStatus(deviceId, newStatus);

                // ✅ Refresh UI (important!)
                LoadDevices();  // Reload all devices
                UpdateDeviceCounts();  // Update count labels
            }
        }




        private void UpdateDeviceCounts()
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
            CheckBox allDevicesToggle = sender as CheckBox;
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
            }
        }
    }
}
