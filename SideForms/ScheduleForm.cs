using Newtonsoft.Json.Linq;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;

public partial class ScheduleForm : Form
{
    private FormDevicesControl formDevicesControl;
    private string repeatDays = "";
    private int selectedDeviceID;
    private string selectedDevice;

    public ScheduleForm(FormDevicesControl form, int deviceID, string deviceName, string deviceStatus)
    {
        
        InitializeComponent();
        formDevicesControl = form;
        // Set values to the controls
        this.selectedDeviceID= deviceID;
    }

    private Label lblDeviceName;
    private TextBox txtDeviceName;
    private Label lblStatus;
    private ComboBox cmbStatus;
    private Label lblStartTime;
    private DateTimePicker dtpStartTime;
    private Label lblEndTime;
    private DateTimePicker dtpEndTime;
    private Button btnRepeatDays;
    private Button btnApply;
    private Button btnCancel;

    private void InitializeComponent()
    {
        txtDeviceName.Text = selectedDevice; //in Initialize Component
        this.Name = "ScheduleForm";
        this.Text = "Set Schedule";
        this.Size = new System.Drawing.Size(400, 300);
        cmbStatus = new ComboBox();
        dtpStartTime = new DateTimePicker();
        dtpEndTime = new DateTimePicker();
        
        lblDeviceName = new Label { Text = "Selected Device:", Location = new System.Drawing.Point(20, 20) };
        txtDeviceName = new TextBox { Text = selectedDevice, Location = new System.Drawing.Point(120, 20), ReadOnly = true };
        

        lblStatus = new Label { Text = "Device Status:", Location = new System.Drawing.Point(20, 50) };
        cmbStatus.Items.AddRange(new object[] { "ON", "OFF" });
        cmbStatus.Location = new Point(120, 50);
        cmbStatus.Name = "cmbStatus";

        lblStartTime = new Label { Text = "Start Time:", Location = new System.Drawing.Point(20, 80) };
        dtpStartTime.Format = DateTimePickerFormat.Time;
        dtpStartTime.Location = new Point(120,80);
        dtpStartTime.ShowUpDown = true; // Removes calendar popup

        lblEndTime = new Label { Text = "End Time:", Location = new System.Drawing.Point(20, 110) };
        dtpEndTime.Format = DateTimePickerFormat.Time;
        dtpEndTime.Location = new Point(120, 110);
        dtpEndTime.ShowUpDown = true;

        btnRepeatDays = new Button { Text = "Repeat", Location = new System.Drawing.Point(20, 140) };
        btnApply = new Button { Text = "Apply", Location = new System.Drawing.Point(100, 180) };
        btnCancel = new Button { Text = "Cancel", Location = new System.Drawing.Point(200, 180) };

        btnRepeatDays.Click += (s, e) =>
        {
            using (var repeatForm = new RepeatDaysForm())
            {
                if (repeatForm.ShowDialog() == DialogResult.OK)
                {
                    repeatDays = repeatForm.SelectedDays;
                }
            }
        };

        btnApply.Click += (s, e) =>
        {
            // Get values
            DbScheduleHelper.DeviceStatus status = (DbScheduleHelper.DeviceStatus)Enum.Parse(typeof(DbScheduleHelper.DeviceStatus), cmbStatus.SelectedItem.ToString());
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndTime.Value;

            DbScheduleHelper.AddSchedule(selectedDeviceID, status, startTime, endTime, repeatDays);
            MessageBox.Show("Schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        };
        btnCancel.Click += (s, e) => this.Close();

        // 
        // AddDeviceForm
        // 
        
        Controls.Add(lblDeviceName);
        Controls.Add(txtDeviceName);
        Controls.Add(lblStatus);
        Controls.Add(cmbStatus);
        Controls.Add(lblStartTime);
        Controls.Add(dtpStartTime);
        Controls.Add(lblEndTime);
        Controls.Add(dtpEndTime);
        Controls.Add(btnRepeatDays);
        Controls.Add(btnApply);
        Controls.Add(btnCancel);
        SuspendLayout();
    }


}
