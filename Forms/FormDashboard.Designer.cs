namespace SmartHomeSideMenubar.Forms
{
    partial class FormDashboard
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
            panelRightMost = new Panel();
            panelWorkingRoom = new Panel();
            panelWeather = new Panel();
            lblTemperature = new Label();
            WeatherIcon = new PictureBox();
            btnSearch = new Controls.RoundedBtn();
            TBCity = new TextBox();
            label14 = new Label();
            panelProfile = new Panel();
            btnProfile = new FontAwesome.Sharp.IconButton();
            panelPp = new Panel();
            panelDevicesList = new FlowLayoutPanel();
            panelTopofDashboard = new Panel();
            checkBox1 = new CheckBox();
            label7 = new Label();
            cmbGroups = new ComboBox();
            btnAlertNoti = new Controls.RoundedBtn();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnAllDevicesStatus = new Controls.ToggleButton();
            label4 = new Label();
            panelCounts = new Panel();
            lblClosedDevices = new Label();
            label1 = new Label();
            label3 = new Label();
            lblOpenedDevices = new Label();
            label2 = new Label();
            lblAllDevices = new Label();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelRightMost.SuspendLayout();
            panelWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WeatherIcon).BeginInit();
            panelProfile.SuspendLayout();
            panelPp.SuspendLayout();
            panelTopofDashboard.SuspendLayout();
            panel3.SuspendLayout();
            panelCounts.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelRightMost
            // 
            panelRightMost.BackColor = Color.FromArgb(35, 91, 80);
            panelRightMost.Controls.Add(panelWorkingRoom);
            panelRightMost.Controls.Add(panelWeather);
            panelRightMost.Controls.Add(panelProfile);
            panelRightMost.Dock = DockStyle.Right;
            panelRightMost.Location = new Point(1056, 0);
            panelRightMost.Margin = new Padding(3, 4, 3, 4);
            panelRightMost.Name = "panelRightMost";
            panelRightMost.Size = new Size(251, 948);
            panelRightMost.TabIndex = 2;
            // 
            // panelWorkingRoom
            // 
            panelWorkingRoom.Dock = DockStyle.Fill;
            panelWorkingRoom.Location = new Point(0, 520);
            panelWorkingRoom.Margin = new Padding(3, 4, 3, 4);
            panelWorkingRoom.Name = "panelWorkingRoom";
            panelWorkingRoom.Size = new Size(251, 428);
            panelWorkingRoom.TabIndex = 2;
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.FromArgb(116, 86, 176);
            panelWeather.Controls.Add(lblTemperature);
            panelWeather.Controls.Add(WeatherIcon);
            panelWeather.Controls.Add(btnSearch);
            panelWeather.Controls.Add(TBCity);
            panelWeather.Controls.Add(label14);
            panelWeather.Dock = DockStyle.Top;
            panelWeather.Location = new Point(0, 200);
            panelWeather.Margin = new Padding(3, 4, 3, 4);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(251, 320);
            panelWeather.TabIndex = 1;
            // 
            // lblTemperature
            // 
            lblTemperature.CausesValidation = false;
            lblTemperature.FlatStyle = FlatStyle.Flat;
            lblTemperature.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.White;
            lblTemperature.Location = new Point(83, 256);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(97, 48);
            lblTemperature.TabIndex = 15;
            lblTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherIcon
            // 
            WeatherIcon.BackColor = Color.Transparent;
            WeatherIcon.Location = new Point(38, 107);
            WeatherIcon.Margin = new Padding(3, 4, 3, 4);
            WeatherIcon.Name = "WeatherIcon";
            WeatherIcon.Size = new Size(181, 145);
            WeatherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            WeatherIcon.TabIndex = 13;
            WeatherIcon.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderRadius = 0;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(176, 8);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // TBCity
            // 
            TBCity.Font = new Font("Segoe UI", 10F);
            TBCity.Location = new Point(7, 53);
            TBCity.Margin = new Padding(3, 4, 3, 4);
            TBCity.Multiline = true;
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(236, 44);
            TBCity.TabIndex = 10;
            // 
            // label14
            // 
            label14.CausesValidation = false;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(7, 8);
            label14.Name = "label14";
            label14.Size = new Size(162, 40);
            label14.TabIndex = 9;
            label14.Text = "Enter City:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelProfile
            // 
            panelProfile.Controls.Add(btnProfile);
            panelProfile.Dock = DockStyle.Top;
            panelProfile.Location = new Point(0, 0);
            panelProfile.Margin = new Padding(3, 4, 3, 4);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(251, 200);
            panelProfile.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderColor = Color.White;
            btnProfile.FlatAppearance.BorderSize = 3;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            btnProfile.IconColor = Color.White;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.IconSize = 45;
            btnProfile.Location = new Point(97, 67);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(57, 67);
            btnProfile.TabIndex = 3;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // panelPp
            // 
            panelPp.AutoScroll = true;
            panelPp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPp.BackgroundImageLayout = ImageLayout.Stretch;
            panelPp.Controls.Add(panelDevicesList);
            panelPp.Controls.Add(panelTopofDashboard);
            panelPp.Dock = DockStyle.Fill;
            panelPp.Font = new Font("Segoe UI", 10F);
            panelPp.Location = new Point(0, 0);
            panelPp.Margin = new Padding(3, 4, 3, 4);
            panelPp.Name = "panelPp";
            panelPp.Size = new Size(1056, 948);
            panelPp.TabIndex = 1;
            // 
            // panelDevicesList
            // 
            panelDevicesList.AutoScroll = true;
            panelDevicesList.Dock = DockStyle.Fill;
            panelDevicesList.Location = new Point(0, 439);
            panelDevicesList.Margin = new Padding(3, 4, 3, 4);
            panelDevicesList.Name = "panelDevicesList";
            panelDevicesList.Size = new Size(1056, 509);
            panelDevicesList.TabIndex = 107;
            // 
            // panelTopofDashboard
            // 
            panelTopofDashboard.Controls.Add(checkBox1);
            panelTopofDashboard.Controls.Add(label7);
            panelTopofDashboard.Controls.Add(cmbGroups);
            panelTopofDashboard.Controls.Add(btnAlertNoti);
            panelTopofDashboard.Controls.Add(panel3);
            panelTopofDashboard.Controls.Add(panelCounts);
            panelTopofDashboard.Dock = DockStyle.Top;
            panelTopofDashboard.Location = new Point(0, 0);
            panelTopofDashboard.Margin = new Padding(3, 4, 3, 4);
            panelTopofDashboard.Name = "panelTopofDashboard";
            panelTopofDashboard.Size = new Size(1056, 439);
            panelTopofDashboard.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(738, 103);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 27);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.CausesValidation = false;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.FromArgb(4, 33, 32);
            label7.Location = new Point(549, 16);
            label7.Name = "label7";
            label7.Padding = new Padding(11, 0, 0, 0);
            label7.Size = new Size(129, 36);
            label7.TabIndex = 103;
            label7.Text = "Select Room :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbGroups
            // 
            cmbGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbGroups.BackColor = SystemColors.MenuHighlight;
            cmbGroups.Cursor = Cursors.Hand;
            cmbGroups.Font = new Font("Segoe UI Black", 10F);
            cmbGroups.ForeColor = Color.Black;
            cmbGroups.FormattingEnabled = true;
            cmbGroups.Location = new Point(685, 16);
            cmbGroups.Margin = new Padding(3, 4, 3, 4);
            cmbGroups.Name = "cmbGroups";
            cmbGroups.Size = new Size(357, 31);
            cmbGroups.TabIndex = 102;
            cmbGroups.SelectedIndexChanged += cmbGroups_SelectedIndexChanged;
            // 
            // btnAlertNoti
            // 
            btnAlertNoti.Anchor = AnchorStyles.None;
            btnAlertNoti.BackColor = Color.Transparent;
            btnAlertNoti.BorderRadius = 5;
            btnAlertNoti.FlatAppearance.BorderColor = Color.Red;
            btnAlertNoti.FlatAppearance.BorderSize = 3;
            btnAlertNoti.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAlertNoti.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAlertNoti.FlatStyle = FlatStyle.Flat;
            btnAlertNoti.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAlertNoti.ForeColor = Color.Red;
            btnAlertNoti.Location = new Point(14, 368);
            btnAlertNoti.Margin = new Padding(3, 4, 3, 4);
            btnAlertNoti.Name = "btnAlertNoti";
            btnAlertNoti.Size = new Size(1029, 53);
            btnAlertNoti.TabIndex = 106;
            btnAlertNoti.Text = "!!!!!!!!!........Alert Message Blur Blur Blur Blur Blur........!!!!!!!!!!!";
            btnAlertNoti.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnAllDevicesStatus);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(531, 141);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 200);
            panel3.TabIndex = 104;
            // 
            // label6
            // 
            label6.CausesValidation = false;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 33, 32);
            label6.Location = new Point(43, 114);
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
            label5.Location = new Point(283, 112);
            label5.Name = "label5";
            label5.Padding = new Padding(11, 0, 0, 0);
            label5.Size = new Size(59, 25);
            label5.TabIndex = 6;
            label5.Text = "OFF";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAllDevicesStatus
            // 
            btnAllDevicesStatus.Location = new Point(131, 95);
            btnAllDevicesStatus.Margin = new Padding(3, 4, 3, 4);
            btnAllDevicesStatus.MinimumSize = new Size(51, 29);
            btnAllDevicesStatus.Name = "btnAllDevicesStatus";
            btnAllDevicesStatus.OffBackColor = Color.FromArgb(116, 86, 176);
            btnAllDevicesStatus.OffToggleColor = Color.White;
            btnAllDevicesStatus.OnBackColor = Color.Black;
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
            // 
            // panelCounts
            // 
            panelCounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCounts.BackColor = Color.White;
            panelCounts.Controls.Add(lblClosedDevices);
            panelCounts.Controls.Add(label1);
            panelCounts.Controls.Add(label3);
            panelCounts.Controls.Add(lblOpenedDevices);
            panelCounts.Controls.Add(label2);
            panelCounts.Controls.Add(lblAllDevices);
            panelCounts.Location = new Point(110, 141);
            panelCounts.Margin = new Padding(3, 4, 3, 4);
            panelCounts.Name = "panelCounts";
            panelCounts.Size = new Size(389, 204);
            panelCounts.TabIndex = 105;
            // 
            // lblClosedDevices
            // 
            lblClosedDevices.FlatStyle = FlatStyle.Flat;
            lblClosedDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClosedDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblClosedDevices.Location = new Point(251, 132);
            lblClosedDevices.Name = "lblClosedDevices";
            lblClosedDevices.Size = new Size(134, 25);
            lblClosedDevices.TabIndex = 5;
            lblClosedDevices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.CausesValidation = false;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(4, 33, 32);
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Padding = new Padding(11, 0, 0, 0);
            label1.Size = new Size(255, 25);
            label1.TabIndex = 0;
            label1.Text = "All Devices :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(4, 33, 32);
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Padding = new Padding(11, 0, 0, 0);
            label3.Size = new Size(255, 25);
            label3.TabIndex = 2;
            label3.Text = "Closed Devices :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOpenedDevices
            // 
            lblOpenedDevices.FlatStyle = FlatStyle.Flat;
            lblOpenedDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOpenedDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblOpenedDevices.Location = new Point(251, 89);
            lblOpenedDevices.Name = "lblOpenedDevices";
            lblOpenedDevices.Size = new Size(134, 25);
            lblOpenedDevices.TabIndex = 4;
            lblOpenedDevices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(4, 33, 32);
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Padding = new Padding(11, 0, 0, 0);
            label2.Size = new Size(255, 25);
            label2.TabIndex = 1;
            label2.Text = "Opened Devices :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAllDevices
            // 
            lblAllDevices.FlatStyle = FlatStyle.Flat;
            lblAllDevices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAllDevices.ForeColor = Color.FromArgb(4, 33, 32);
            lblAllDevices.Location = new Point(251, 44);
            lblAllDevices.Name = "lblAllDevices";
            lblAllDevices.Size = new Size(134, 25);
            lblAllDevices.TabIndex = 3;
            lblAllDevices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 40);
            panel1.TabIndex = 13;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.MenuHighlight;
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Black", 10F);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(116, 40);
            iconButton1.TabIndex = 14;
            iconButton1.Text = "Rooms";
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 40);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 80);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 120);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 16;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1307, 948);
            Controls.Add(panelPp);
            Controls.Add(panelRightMost);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panelRightMost.ResumeLayout(false);
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WeatherIcon).EndInit();
            panelProfile.ResumeLayout(false);
            panelPp.ResumeLayout(false);
            panelTopofDashboard.ResumeLayout(false);
            panelTopofDashboard.PerformLayout();
            panel3.ResumeLayout(false);
            panelCounts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRightMost;
        private Panel panelPp;
        private Panel panelProfile;
        private FontAwesome.Sharp.IconButton btnProfile;
        private Panel panelDropdown;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelTopofDashboard;
        private Label label7;
        private ComboBox cmbGroups;
        private Controls.RoundedBtn btnAlertNoti;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Controls.ToggleButton btnAllDevicesStatus;
        private Label label4;
        private Panel panelCounts;
        private Label lblClosedDevices;
        private Label label1;
        private Label label3;
        private Label lblOpenedDevices;
        private Label label2;
        private Label lblAllDevices;
        private Panel panelWeather;
        private Controls.RoundedBtn btnSearch;
        private TextBox TBCity;
        private Label label14;
        private PictureBox WeatherIcon;
        private Label lblTemperature;
        private FlowLayoutPanel panelDevicesList;
        private Panel panelWorkingRoom;
        private CheckBox checkBox1;
    }
}