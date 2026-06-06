using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

public partial class AddDeviceForm : Form
{
    private FormDevicesControl formDevicesControl;
    
    public AddDeviceForm(FormDevicesControl form)
    {
        InitializeComponent();
        this.MaximizeBox = false;  
        this.MinimizeBox = false;
        formDevicesControl = form;

    }
    private void LoadDeviceTypes()
    {
        cmbTypes.DataSource = DbTypeHelper.GetAllTypes();
        cmbTypes.DisplayMember = "TypeName";
        cmbTypes.ValueMember = "TypeID";
    } 

    private void LoadDeviceGroups()
    {
        cmbGroups.DataSource = DbGroupHelper.GetAllGroups();
        cmbGroups.DisplayMember = "GroupName";
        cmbGroups.ValueMember = "GroupID";
    }

    private Label lblDeviceName;
    private TextBox txtDeviceName;
    private Label lblDeviceType;
    private Label lblStatus;
    private ComboBox cmbStatus;
    private Button btnSave;
    private Label lblIsReal;
    private ComboBox cmbTypes;
    private ComboBox cmbGroups;
    private Label label1;
    private CheckBox chkIsReal;

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeviceForm));
        lblDeviceName = new Label();
        txtDeviceName = new TextBox();
        lblDeviceType = new Label();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        btnSave = new Button();
        chkIsReal = new CheckBox();
        lblIsReal = new Label();
        cmbTypes = new ComboBox();
        cmbGroups = new ComboBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblDeviceName
        // 
        lblDeviceName.BackColor = Color.Transparent;
        lblDeviceName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblDeviceName.Location = new Point(82, 44);
        lblDeviceName.Name = "lblDeviceName";
        lblDeviceName.Size = new Size(100, 23);
        lblDeviceName.TabIndex = 0;
        lblDeviceName.Text = "Device Name:";
        // 
        // txtDeviceName
        // 
        txtDeviceName.Location = new Point(211, 44);
        txtDeviceName.Name = "txtDeviceName";
        txtDeviceName.Size = new Size(100, 23);
        txtDeviceName.TabIndex = 1;
        // 
        // lblDeviceType
        // 
        lblDeviceType.BackColor = Color.Transparent;
        lblDeviceType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblDeviceType.Location = new Point(82, 93);
        lblDeviceType.Name = "lblDeviceType";
        lblDeviceType.Size = new Size(100, 23);
        lblDeviceType.TabIndex = 2;
        lblDeviceType.Text = "Device Type:";
        // 
        // lblStatus
        // 
        lblStatus.BackColor = Color.Transparent;
        lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblStatus.Location = new Point(82, 190);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(100, 23);
        lblStatus.TabIndex = 4;
        lblStatus.Text = "Status:";
        // 
        // cmbStatus
        // 
        cmbStatus.Items.AddRange(new object[] { "ON", "OFF" });
        cmbStatus.Location = new Point(211, 187);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(121, 23);
        cmbStatus.TabIndex = 5;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.CadetBlue;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.Location = new Point(166, 296);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(95, 32);
        btnSave.TabIndex = 8;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += BtnSave_Click;
        // 
        // chkIsReal
        // 
        chkIsReal.BackColor = Color.Transparent;
        chkIsReal.Location = new Point(207, 232);
        chkIsReal.Name = "chkIsReal";
        chkIsReal.Size = new Size(104, 24);
        chkIsReal.TabIndex = 7;
        chkIsReal.UseVisualStyleBackColor = false;
        // 
        // lblIsReal
        // 
        lblIsReal.BackColor = Color.Transparent;
        lblIsReal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblIsReal.Location = new Point(82, 236);
        lblIsReal.Name = "lblIsReal";
        lblIsReal.Size = new Size(100, 23);
        lblIsReal.TabIndex = 6;
        lblIsReal.Text = "Real Device :";
        // 
        // cmbTypes
        // 
        cmbTypes.FormattingEnabled = true;
        cmbTypes.Location = new Point(211, 90);
        cmbTypes.Name = "cmbTypes";
        cmbTypes.Size = new Size(121, 23);
        cmbTypes.TabIndex = 9;
        // 
        // cmbGroups
        // 
        cmbGroups.FormattingEnabled = true;
        cmbGroups.Location = new Point(211, 140);
        cmbGroups.Name = "cmbGroups";
        cmbGroups.Size = new Size(121, 23);
        cmbGroups.TabIndex = 12;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(82, 143);
        label1.Name = "label1";
        label1.Size = new Size(100, 23);
        label1.TabIndex = 10;
        label1.Text = "Device Group:";
        // 
        // AddDeviceForm
        // 
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(434, 361);
        Controls.Add(cmbGroups);
        Controls.Add(label1);
        Controls.Add(cmbTypes);
        Controls.Add(lblDeviceName);
        Controls.Add(txtDeviceName);
        Controls.Add(lblDeviceType);
        Controls.Add(lblStatus);
        Controls.Add(cmbStatus);
        Controls.Add(lblIsReal);
        Controls.Add(chkIsReal);
        Controls.Add(btnSave);
        Name = "AddDeviceForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Add Device";
        Load += AddDeviceForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        // Validation
        if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
        {
            MessageBox.Show("Please enter a device name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (cmbTypes.SelectedValue == null)
        {
            MessageBox.Show("Please select a valid Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (cmbGroups.SelectedValue == null)
        {
            MessageBox.Show("Please select a valid Group.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Get values
        string deviceName = txtDeviceName.Text.Trim();
        int selectedTypeId = Convert.ToInt32(cmbTypes.SelectedValue);
        int selectedGroupId = Convert.ToInt32(cmbGroups.SelectedValue);
        bool isReal = chkIsReal.Checked;
        DbDevicesHelper.DeviceStatus status = (DbDevicesHelper.DeviceStatus)Enum.Parse(typeof(DbDevicesHelper.DeviceStatus), cmbStatus.SelectedItem.ToString());

        // Add Device
        DbDevicesHelper.AddDevice(deviceName, selectedTypeId, status, isReal, selectedGroupId);

        // Notify user
        MessageBox.Show("Device added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // 🔥 Refresh DataGridView in FormDevicesControl
        formDevicesControl.LoadDevices();
        formDevicesControl.UpdateDeviceCounts();
        // Close the form
        this.Close();
    }

    private void AddDeviceForm_Load(object sender, EventArgs e)
    {
        LoadDeviceTypes();
        LoadDeviceGroups();
    }
}
