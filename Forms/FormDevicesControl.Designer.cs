
using MaterialSkin.Controls;
using SmartHomeSideMenubar.Controls;

namespace SmartHomeSideMenubar.Forms
{
    partial class FormDevicesControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel1 = new RoundedPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtSearchDevice = new TextBox();
            panel1 = new Panel();
            roundedPanel4 = new RoundedPanel();
            btnDeleteSelected = new Button();
            roundedPanel2 = new RoundedPanel();
            btnAdd = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnAllDevicesStatus = new ToggleButton();
            label4 = new Label();
            panelCounts = new Panel();
            lblClosedDevices = new Label();
            lblOpenDevices = new Label();
            lblTotalDevices = new Label();
            panelGroupGrid = new Panel();
            dgvDevices = new DataGridView();
            columnDeviceID = new DataGridViewTextBoxColumn();
            columnTypesID = new DataGridViewTextBoxColumn();
            columnGroupID = new DataGridViewTextBoxColumn();
            columnSelectDevice = new DataGridViewCheckBoxColumn();
            columnStatusDevice = new DataGridViewCheckBoxColumn();
            columnDeviceName = new DataGridViewTextBoxColumn();
            columnRoomsDevice = new DataGridViewTextBoxColumn();
            columnTypesDevice = new DataGridViewTextBoxColumn();
            columnIsReal = new DataGridViewCheckBoxColumn();
            columnCreatedAtDevice = new DataGridViewTextBoxColumn();
            columnUpdatedAtDevice = new DataGridViewTextBoxColumn();
            btnEditDevice = new DataGridViewTextBoxColumn();
            btnDeleteDevice = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelCounts.SuspendLayout();
            panelGroupGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(panel2);
            panelHeader.Controls.Add(panel1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1381, 145);
            panelHeader.TabIndex = 2;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 29, 69);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(344, 107);
            label1.TabIndex = 9;
            label1.Text = "Device Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(408, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 145);
            panel2.TabIndex = 8;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 3;
            roundedPanel1.Controls.Add(iconButton1);
            roundedPanel1.Controls.Add(txtSearchDevice);
            roundedPanel1.Location = new Point(57, 52);
            roundedPanel1.Margin = new Padding(3, 4, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(543, 61);
            roundedPanel1.TabIndex = 7;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.White;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.CadetBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(465, 15);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(62, 37);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "\r\n";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtSearchDevice
            // 
            txtSearchDevice.BorderStyle = BorderStyle.None;
            txtSearchDevice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchDevice.Location = new Point(47, 15);
            txtSearchDevice.Margin = new Padding(3, 4, 3, 4);
            txtSearchDevice.Name = "txtSearchDevice";
            txtSearchDevice.Size = new Size(415, 35);
            txtSearchDevice.TabIndex = 0;
            txtSearchDevice.TextChanged += txtSearchDevice_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(roundedPanel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1024, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 145);
            panel1.TabIndex = 6;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BorderColor = Color.DarkGreen;
            roundedPanel4.BorderRadius = 20;
            roundedPanel4.BorderSize = 2;
            roundedPanel4.Controls.Add(btnDeleteSelected);
            roundedPanel4.Location = new Point(171, 41);
            roundedPanel4.Margin = new Padding(3, 4, 3, 4);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(159, 72);
            roundedPanel4.TabIndex = 9;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.FromArgb(200, 35, 51);
            btnDeleteSelected.Dock = DockStyle.Fill;
            btnDeleteSelected.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnDeleteSelected.FlatAppearance.BorderSize = 0;
            btnDeleteSelected.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            btnDeleteSelected.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            btnDeleteSelected.FlatStyle = FlatStyle.Flat;
            btnDeleteSelected.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSelected.ForeColor = Color.Snow;
            btnDeleteSelected.Location = new Point(0, 0);
            btnDeleteSelected.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(159, 72);
            btnDeleteSelected.TabIndex = 7;
            btnDeleteSelected.Text = "Delete Seleted";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BorderColor = Color.DarkGreen;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderSize = 2;
            roundedPanel2.Controls.Add(btnAdd);
            roundedPanel2.Location = new Point(15, 41);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(150, 72);
            roundedPanel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 136, 56);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Snow;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 72);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Device";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panelCounts);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(1381, 208);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btnAllDevicesStatus);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(744, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(389, 208);
            panel5.TabIndex = 109;
            // 
            // label6
            // 
            label6.CausesValidation = false;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 33, 32);
            label6.Location = new Point(296, 112);
            label6.Name = "label6";
            label6.Padding = new Padding(11, 0, 0, 0);
            label6.Size = new Size(59, 25);
            label6.TabIndex = 8;
            label6.Text = "ON";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.CausesValidation = false;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 33, 32);
            label5.Location = new Point(40, 112);
            label5.Name = "label5";
            label5.Padding = new Padding(11, 0, 0, 0);
            label5.Size = new Size(59, 25);
            label5.TabIndex = 6;
            label5.Text = "OFF";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAllDevicesStatus
            // 
            btnAllDevicesStatus.ForeColor = Color.Yellow;
            btnAllDevicesStatus.Location = new Point(131, 95);
            btnAllDevicesStatus.Margin = new Padding(3, 4, 3, 4);
            btnAllDevicesStatus.MinimumSize = new Size(51, 29);
            btnAllDevicesStatus.Name = "btnAllDevicesStatus";
            btnAllDevicesStatus.OffBackColor = Color.Black;
            btnAllDevicesStatus.OffToggleColor = Color.White;
            btnAllDevicesStatus.OnBackColor = Color.FromArgb(116, 86, 176);
            btnAllDevicesStatus.OnToggleColor = Color.White;
            btnAllDevicesStatus.Size = new Size(129, 63);
            btnAllDevicesStatus.TabIndex = 7;
            btnAllDevicesStatus.UseVisualStyleBackColor = true;
            btnAllDevicesStatus.CheckedChanged += btnAllDevicesStatus_CheckedChanged;
            // 
            // label4
            // 
            label4.CausesValidation = false;
            label4.Dock = DockStyle.Top;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 33, 32);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(11, 0, 0, 0);
            label4.Size = new Size(389, 79);
            label4.TabIndex = 6;
            label4.Text = "All Devices ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // panelCounts
            // 
            panelCounts.BackColor = Color.AliceBlue;
            panelCounts.Controls.Add(lblClosedDevices);
            panelCounts.Controls.Add(lblOpenDevices);
            panelCounts.Controls.Add(lblTotalDevices);
            panelCounts.Location = new Point(279, 0);
            panelCounts.Margin = new Padding(3, 4, 3, 4);
            panelCounts.Name = "panelCounts";
            panelCounts.Size = new Size(389, 208);
            panelCounts.TabIndex = 108;
            // 
            // lblClosedDevices
            // 
            lblClosedDevices.FlatStyle = FlatStyle.Flat;
            lblClosedDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClosedDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblClosedDevices.Location = new Point(26, 132);
            lblClosedDevices.Name = "lblClosedDevices";
            lblClosedDevices.Size = new Size(359, 25);
            lblClosedDevices.TabIndex = 5;
            lblClosedDevices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOpenDevices
            // 
            lblOpenDevices.FlatStyle = FlatStyle.Flat;
            lblOpenDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOpenDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblOpenDevices.Location = new Point(26, 89);
            lblOpenDevices.Name = "lblOpenDevices";
            lblOpenDevices.Size = new Size(359, 25);
            lblOpenDevices.TabIndex = 4;
            lblOpenDevices.TextAlign = ContentAlignment.MiddleCenter;
            lblOpenDevices.Click += lblOpenDevices_Click;
            // 
            // lblTotalDevices
            // 
            lblTotalDevices.FlatStyle = FlatStyle.Flat;
            lblTotalDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblTotalDevices.Location = new Point(26, 43);
            lblTotalDevices.Name = "lblTotalDevices";
            lblTotalDevices.Size = new Size(350, 25);
            lblTotalDevices.TabIndex = 3;
            lblTotalDevices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGroupGrid
            // 
            panelGroupGrid.BackColor = Color.Transparent;
            panelGroupGrid.Controls.Add(dgvDevices);
            panelGroupGrid.Dock = DockStyle.Fill;
            panelGroupGrid.Location = new Point(0, 353);
            panelGroupGrid.Margin = new Padding(34, 40, 34, 40);
            panelGroupGrid.Name = "panelGroupGrid";
            panelGroupGrid.Padding = new Padding(29, 33, 29, 33);
            panelGroupGrid.Size = new Size(1381, 646);
            panelGroupGrid.TabIndex = 7;
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 240, 255);
            dgvDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDevices.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 37, 88);
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDevices.ColumnHeadersHeight = 55;
            dgvDevices.Columns.AddRange(new DataGridViewColumn[] { columnDeviceID, columnTypesID, columnGroupID, columnSelectDevice, columnStatusDevice, columnDeviceName, columnRoomsDevice, columnTypesDevice, columnIsReal, columnCreatedAtDevice, columnUpdatedAtDevice, btnEditDevice, btnDeleteDevice });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDevices.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDevices.Dock = DockStyle.Fill;
            dgvDevices.EnableHeadersVisualStyles = false;
            dgvDevices.GridColor = Color.Gainsboro;
            dgvDevices.Location = new Point(29, 33);
            dgvDevices.Margin = new Padding(3, 4, 3, 4);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.RowHeadersVisible = false;
            dgvDevices.RowHeadersWidth = 51;
            dgvDevices.RowTemplate.Height = 45;
            dgvDevices.Size = new Size(1323, 580);
            dgvDevices.TabIndex = 3;
            dgvDevices.CellContentClick += dgvDevices_CellContentClick_1;
            // 
            // columnDeviceID
            // 
            columnDeviceID.HeaderText = "Device ID";
            columnDeviceID.MinimumWidth = 120;
            columnDeviceID.Name = "columnDeviceID";
            columnDeviceID.Visible = false;
            columnDeviceID.Width = 125;
            // 
            // columnTypesID
            // 
            columnTypesID.HeaderText = "TypeID";
            columnTypesID.MinimumWidth = 6;
            columnTypesID.Name = "columnTypesID";
            columnTypesID.Visible = false;
            columnTypesID.Width = 125;
            // 
            // columnGroupID
            // 
            columnGroupID.HeaderText = "GroupId";
            columnGroupID.MinimumWidth = 6;
            columnGroupID.Name = "columnGroupID";
            columnGroupID.Visible = false;
            columnGroupID.Width = 125;
            // 
            // columnSelectDevice
            // 
            columnSelectDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnSelectDevice.FillWeight = 200F;
            columnSelectDevice.HeaderText = "Select";
            columnSelectDevice.MinimumWidth = 70;
            columnSelectDevice.Name = "columnSelectDevice";
            // 
            // columnStatusDevice
            // 
            columnStatusDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnStatusDevice.HeaderText = "Status";
            columnStatusDevice.MinimumWidth = 70;
            columnStatusDevice.Name = "columnStatusDevice";
            // 
            // columnDeviceName
            // 
            columnDeviceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnDeviceName.FillWeight = 200F;
            columnDeviceName.HeaderText = "Device Name";
            columnDeviceName.MinimumWidth = 120;
            columnDeviceName.Name = "columnDeviceName";
            columnDeviceName.ReadOnly = true;
            // 
            // columnRoomsDevice
            // 
            columnRoomsDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnRoomsDevice.FillWeight = 200F;
            columnRoomsDevice.HeaderText = "Rooms";
            columnRoomsDevice.MinimumWidth = 100;
            columnRoomsDevice.Name = "columnRoomsDevice";
            columnRoomsDevice.ReadOnly = true;
            // 
            // columnTypesDevice
            // 
            columnTypesDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnTypesDevice.HeaderText = "Types";
            columnTypesDevice.MinimumWidth = 100;
            columnTypesDevice.Name = "columnTypesDevice";
            columnTypesDevice.ReadOnly = true;
            // 
            // columnIsReal
            // 
            columnIsReal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnIsReal.HeaderText = "Real";
            columnIsReal.MinimumWidth = 70;
            columnIsReal.Name = "columnIsReal";
            columnIsReal.ReadOnly = true;
            // 
            // columnCreatedAtDevice
            // 
            columnCreatedAtDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCreatedAtDevice.FillWeight = 200F;
            columnCreatedAtDevice.HeaderText = "Created";
            columnCreatedAtDevice.MinimumWidth = 100;
            columnCreatedAtDevice.Name = "columnCreatedAtDevice";
            columnCreatedAtDevice.ReadOnly = true;
            columnCreatedAtDevice.Resizable = DataGridViewTriState.True;
            columnCreatedAtDevice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnUpdatedAtDevice
            // 
            columnUpdatedAtDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnUpdatedAtDevice.FillWeight = 200F;
            columnUpdatedAtDevice.HeaderText = "Updated";
            columnUpdatedAtDevice.MinimumWidth = 100;
            columnUpdatedAtDevice.Name = "columnUpdatedAtDevice";
            columnUpdatedAtDevice.ReadOnly = true;
            columnUpdatedAtDevice.Resizable = DataGridViewTriState.True;
            columnUpdatedAtDevice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnEditDevice
            // 
            btnEditDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.DarkBlue;
            btnEditDevice.DefaultCellStyle = dataGridViewCellStyle3;
            btnEditDevice.FillWeight = 200F;
            btnEditDevice.HeaderText = "Edit";
            btnEditDevice.MinimumWidth = 70;
            btnEditDevice.Name = "btnEditDevice";
            btnEditDevice.ReadOnly = true;
            btnEditDevice.Resizable = DataGridViewTriState.True;
            btnEditDevice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDeleteDevice
            // 
            btnDeleteDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.DarkRed;
            btnDeleteDevice.DefaultCellStyle = dataGridViewCellStyle4;
            btnDeleteDevice.FillWeight = 200F;
            btnDeleteDevice.HeaderText = "Delete";
            btnDeleteDevice.MinimumWidth = 70;
            btnDeleteDevice.Name = "btnDeleteDevice";
            btnDeleteDevice.ReadOnly = true;
            btnDeleteDevice.Resizable = DataGridViewTriState.True;
            btnDeleteDevice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormDevicesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1381, 999);
            Controls.Add(panelGroupGrid);
            Controls.Add(panel4);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDevicesControl";
            Text = "FormControl";
            Load += FormDevicesControl_Load;
            panelHeader.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelCounts.ResumeLayout(false);
            panelGroupGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panel1;

        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel1;
        private TextBox txtSearchDevice;
        private Panel panel2;
        private RoundedPanel roundedPanel4;
        private Button btnDeleteSelected;
        private Button btnAdd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Panel panel4;
        private Panel panelCounts;
        private Label lblClosedDevices;
        private Label lblOpenDevices;
        private Label lblTotalDevices;
        private Panel panel5;
        private Label label6;
        private Label label5;
        private ToggleButton btnAllDevicesStatus;
        private Label label4;
        private Panel panelGroupGrid;
        private DataGridView dgvDevices;
        private DataGridViewTextBoxColumn columnDeviceID;
        private DataGridViewTextBoxColumn columnTypesID;
        private DataGridViewTextBoxColumn columnGroupID;
        private DataGridViewCheckBoxColumn columnSelectDevice;
        private DataGridViewCheckBoxColumn columnStatusDevice;
        private DataGridViewTextBoxColumn columnDeviceName;
        private DataGridViewTextBoxColumn columnRoomsDevice;
        private DataGridViewTextBoxColumn columnTypesDevice;
        private DataGridViewCheckBoxColumn columnIsReal;
        private DataGridViewTextBoxColumn columnCreatedAtDevice;
        private DataGridViewTextBoxColumn columnUpdatedAtDevice;
        private DataGridViewTextBoxColumn btnEditDevice;
        private DataGridViewTextBoxColumn btnDeleteDevice;
    }
}