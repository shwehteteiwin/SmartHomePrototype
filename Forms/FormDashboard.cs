using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Controls;
using SmartHomeSideMenubar.Models;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Documents;

namespace SmartHomeSideMenubar.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void LoadDeviceGroups()
        {
            cmbGroups.DataSource = DbGroupHelper.GetAllGroups();
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupID";
        }
        private void openPp(Form cForm, object btnsender)
        {
            cForm.TopLevel = false;
            cForm.FormBorderStyle = FormBorderStyle.None;
            this.panelPp.Controls.Add(cForm);
            this.panelPp.Tag = cForm;
            cForm.BringToFront();
            cForm.Show();
        }


        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            openPp(new Profile(), sender);
        }
        bool expand = false;

        public void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDeviceGroups();
            LoadRooms();
            cmbGroups.SelectedIndexChanged += cmbGroups_SelectedIndexChanged; // Attach event
            btnAllDevicesStatus.CheckedChanged += btnAllDevicesStatus_CheckedChanged; // Handle toggle button

            // Automatically select the first room and update counts
            if (cmbGroups.Items.Count > 0)
            {
                cmbGroups.SelectedIndex = 0; // Select first group
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);
                UpdateDeviceCounts();
                LoadOpenedDevices(groupId);
            }
        }
        private void UpdateDeviceCounts()
        {
            LoadRooms();
            if (cmbGroups.SelectedValue != null && cmbGroups.SelectedValue is int selectedGroupId)
            {
                int totalDevices = DbDevicesHelper.GetDeviceCountByGroup(selectedGroupId);
                int openedDevices = DbDevicesHelper.GetOpenedDeviceCountByGroup(selectedGroupId);
                int closedDevices = DbDevicesHelper.GetClosedDeviceCountByGroup(selectedGroupId);

                lblAllDevices.Text = $"{totalDevices}";
                lblOpenedDevices.Text = $"{openedDevices}";
                lblClosedDevices.Text = $"{closedDevices}";
            }
        }

        private void LoadOpenedDevices(int groupId)
        {
            UpdateDeviceCounts();
            // Clear previous devices
            panelDevicesList.Controls.Clear();

            // Fetch all opened devices (Status = 1) for the selected group
            List<Device> openedDevices = DbDevicesHelper.GetOpenedDevicesByGroup(groupId);
            int totalWidth = 0;
            int panelWidth = panelDevicesList.Width; // Get panel width

            // First, calculate total width of all device buttons in a row
            foreach (Device device in openedDevices)
            {
                totalWidth += 200 + 10; // Button width + margin
            }

            int leftMargin = Math.Max((panelWidth - totalWidth) / 2, 0); // Ensure no negative values

            foreach (Device device in openedDevices)
            {
                Panel panelOpenedDevice = new Panel
                {
                    Size = new Size(200, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.MediumAquamarine,
                    ForeColor = Color.White

                };
                // Apply left margin only to the first button
                if (device == openedDevices.First())
                {
                    panelOpenedDevice.Margin = new Padding(leftMargin, 5, 10, 5);
                }
                else
                {
                    panelOpenedDevice.Margin = new Padding(10, 5, 10, 5); // Normal margin for others
                }
                Label lblDeviceName = new Label
                {
                    Text = device.DeviceName,
                    Location = new Point(10, panelOpenedDevice.Height / 4),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(4, 33, 32)
                };

                ToggleButton btnStatus = new ToggleButton
                {
                    Checked = true, // Opened devices should be ON
                    Location = new Point(lblDeviceName.Width + 20, panelOpenedDevice.Height / 4),
                    Size = new Size(50, 30)
                };

                // Add event handler to toggle device status
                btnStatus.CheckedChanged += (s, e) =>
                {
                    bool newStatus = btnStatus.Checked;

                    // Convert boolean to DeviceStatus enum
                    DeviceStatus deviceStatus = newStatus ? DeviceStatus.ON : DeviceStatus.OFF;
                    DbDevicesHelper.UpdateDeviceStatus(device.DeviceID, deviceStatus);
                    LoadOpenedDevices(groupId); // Refresh device list after status change
                };


                panelOpenedDevice.Controls.Add(lblDeviceName);
                panelOpenedDevice.Controls.Add(btnStatus);

                panelDevicesList.Controls.Add(panelOpenedDevice);

                //yOffset += 110; // Increase spacing for the next device
            }
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroups.SelectedValue != null && int.TryParse(cmbGroups.SelectedValue.ToString(), out int groupId))
            {
                LoadOpenedDevices(groupId);
                UpdateDeviceCounts();
            }
        }

        private bool isHandlingEvent = false; // Add this flag at the class level

        private void btnAllDevicesStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (isHandlingEvent) return; // Prevent re-entry if already handling

            isHandlingEvent = true; // Mark as handling

            if (cmbGroups.SelectedValue == null || !int.TryParse(cmbGroups.SelectedValue.ToString(), out int groupId))
            {
                MessageBox.Show("Please select a valid group first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAllDevicesStatus.Checked = false;
                isHandlingEvent = false; // Reset flag before returning
                return;
            }
            bool turnOn = btnAllDevicesStatus.Checked; // Get desired state from toggle button

            // Toggle all devices to match the main switch state
            DbDevicesHelper.UpdateAllDevicesStatusByGroup(groupId, turnOn);

            // Refresh UI
            UpdateDeviceCounts();
            LoadOpenedDevices(groupId);

            isHandlingEvent = false; // Reset flag after handling


        }

        // Weather Section

        private string apiKey = "e415282b8d8b3c5bad3e8f7c5926e2c8";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string city = TBCity.Text.Trim();
            if (!string.IsNullOrEmpty(city))
            {
                GetWeather(city);
            }
            else
            {
                MessageBox.Show("Please enter a city name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetWeather(string city)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
                using (WebClient web = new WebClient())
                {
                    string response = web.DownloadString(url);
                    dynamic jsonData = JsonConvert.DeserializeObject(response);

                    if (jsonData != null)
                    {
                        double temperature = jsonData.main.temp;
                        string iconCode = jsonData.weather[0].icon;
                        string iconUrl = $"http://openweathermap.org/img/wn/{iconCode}.png";

                        // Update UI
                        lblTemperature.Text = $"{temperature}°C";
                        WeatherIcon.Load(iconUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching weather data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRooms()
        {
            panelWorkingRoom.Controls.Clear(); // Clear previous room panels

            List<Group> roomGroups = DbGroupHelper.GetAllGroups(); // Fetch all rooms from DB

            int yOffset = 8; // Start Y position for dynamic controls

            foreach (Group room in roomGroups)
            {
                // Create a panel for each room (inside panelWorkingRoom)
                Panel panelRoomNames = new Panel
                {
                    Size = new Size(panelWorkingRoom.Width - 20, 50), // Reduce width slightly for spacing
                    BackColor = Color.MediumAquamarine,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, yOffset) // Position dynamically
                };

                // Create Label for the room name
                Label lblRoomName = new Label
                {
                    Text = room.GroupName,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 15)
                };

                // Create Toggle Button
                CheckBox toggleBtn = new CheckBox
                {
                    Appearance = Appearance.Button,
                    Text = "ON",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Checked=true,
                    Size = new Size(60, 30),
                    Location = new Point(panelRoomNames.Width - 80, 10)
                };

                // Add controls to room panel
                panelRoomNames.Controls.Add(lblRoomName);
                panelRoomNames.Controls.Add(toggleBtn);

                // Add room panel to the main panel
                panelWorkingRoom.Controls.Add(panelRoomNames);

                // Increase Y offset for the next room
                yOffset += panelRoomNames.Height + 10;
            }

            // Enable scrolling if too many rooms
            panelWorkingRoom.AutoScroll = true;
        }



    }

}