namespace SmartHomeSideMenubar
{
    partial class SideMenuBar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelDashboard = new Panel();
            panelSettings = new Panel();
            btnSettings = new FontAwesome.Sharp.IconButton();
            panelGroup = new Panel();
            btnGroup = new FontAwesome.Sharp.IconButton();
            panelHistory = new Panel();
            btnHistory = new FontAwesome.Sharp.IconButton();
            panelSidebar = new Panel();
            panel1 = new Panel();
            btnTypes = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnMenuControl = new FontAwesome.Sharp.IconButton();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelDesktop = new Panel();
            panelControls = new Panel();
            label1 = new Label();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnCloseApp = new FontAwesome.Sharp.IconButton();
            panelDashboard.SuspendLayout();
            panelSettings.SuspendLayout();
            panelGroup.SuspendLayout();
            panelHistory.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panelDesktop.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(4, 32, 33);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 25;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(240, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "      Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(btnDashboard);
            panelDashboard.Location = new Point(10, 236);
            panelDashboard.Margin = new Padding(3, 4, 3, 4);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(240, 67);
            panelDashboard.TabIndex = 1;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(btnSettings);
            panelSettings.Location = new Point(8, 530);
            panelSettings.Margin = new Padding(3, 4, 3, 4);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(240, 67);
            panelSettings.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(4, 32, 33);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            btnSettings.IconColor = Color.AntiqueWhite;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 25;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(11, 0, 0, 0);
            btnSettings.Size = new Size(240, 67);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "      User Lists";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelGroup
            // 
            panelGroup.Controls.Add(btnGroup);
            panelGroup.Location = new Point(8, 386);
            panelGroup.Margin = new Padding(3, 4, 3, 4);
            panelGroup.Name = "panelGroup";
            panelGroup.Size = new Size(240, 67);
            panelGroup.TabIndex = 5;
            // 
            // btnGroup
            // 
            btnGroup.BackColor = Color.FromArgb(4, 32, 33);
            btnGroup.FlatAppearance.BorderSize = 0;
            btnGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnGroup.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnGroup.FlatStyle = FlatStyle.Flat;
            btnGroup.Font = new Font("Segoe UI", 10F);
            btnGroup.ForeColor = Color.White;
            btnGroup.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnGroup.IconColor = Color.AntiqueWhite;
            btnGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGroup.IconSize = 25;
            btnGroup.ImageAlign = ContentAlignment.MiddleLeft;
            btnGroup.Location = new Point(0, 0);
            btnGroup.Margin = new Padding(3, 4, 3, 4);
            btnGroup.Name = "btnGroup";
            btnGroup.Padding = new Padding(11, 0, 0, 0);
            btnGroup.Size = new Size(240, 67);
            btnGroup.TabIndex = 0;
            btnGroup.Text = "      Rooms";
            btnGroup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGroup.UseVisualStyleBackColor = false;
            btnGroup.Click += btnGroup_Click;
            // 
            // panelHistory
            // 
            panelHistory.Controls.Add(btnHistory);
            panelHistory.Location = new Point(8, 458);
            panelHistory.Margin = new Padding(3, 4, 3, 4);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(240, 67);
            panelHistory.TabIndex = 6;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(4, 32, 33);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10F);
            btnHistory.ForeColor = Color.White;
            btnHistory.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnHistory.IconColor = Color.AntiqueWhite;
            btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistory.IconSize = 25;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 0);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(11, 0, 0, 0);
            btnHistory.Size = new Size(240, 67);
            btnHistory.TabIndex = 0;
            btnHistory.Text = "      History/Logs";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(4, 32, 33);
            panelSidebar.Controls.Add(panel1);
            panelSidebar.Controls.Add(panel8);
            panelSidebar.Controls.Add(panelDashboard);
            panelSidebar.Controls.Add(panelGroup);
            panelSidebar.Controls.Add(panelSettings);
            panelSidebar.Controls.Add(panelHistory);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.MaximumSize = new Size(251, 0);
            panelSidebar.MinimumSize = new Size(69, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(251, 948);
            panelSidebar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTypes);
            panel1.Location = new Point(10, 311);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 67);
            panel1.TabIndex = 2;
            // 
            // btnTypes
            // 
            btnTypes.BackColor = Color.FromArgb(4, 32, 33);
            btnTypes.FlatAppearance.BorderSize = 0;
            btnTypes.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnTypes.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnTypes.FlatStyle = FlatStyle.Flat;
            btnTypes.Font = new Font("Segoe UI", 10F);
            btnTypes.ForeColor = Color.White;
            btnTypes.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnTypes.IconColor = Color.White;
            btnTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTypes.IconSize = 25;
            btnTypes.ImageAlign = ContentAlignment.MiddleLeft;
            btnTypes.Location = new Point(0, 0);
            btnTypes.Margin = new Padding(3, 4, 3, 4);
            btnTypes.Name = "btnTypes";
            btnTypes.Padding = new Padding(11, 0, 0, 0);
            btnTypes.Size = new Size(240, 67);
            btnTypes.TabIndex = 0;
            btnTypes.Text = "      Types";
            btnTypes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTypes.UseVisualStyleBackColor = false;
            btnTypes.Click += btnTypes_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnProfile);
            panel8.Controls.Add(btnMenuControl);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 200);
            panel8.TabIndex = 9;
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
            btnProfile.TabIndex = 4;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnMenuControl
            // 
            btnMenuControl.BackColor = Color.FromArgb(21, 63, 53);
            btnMenuControl.FlatAppearance.BorderSize = 0;
            btnMenuControl.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 45, 38);
            btnMenuControl.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 45, 38);
            btnMenuControl.FlatStyle = FlatStyle.Flat;
            btnMenuControl.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenuControl.IconColor = Color.White;
            btnMenuControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuControl.IconSize = 25;
            btnMenuControl.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuControl.Location = new Point(206, 7);
            btnMenuControl.Margin = new Padding(3, 4, 3, 4);
            btnMenuControl.Name = "btnMenuControl";
            btnMenuControl.Size = new Size(40, 40);
            btnMenuControl.TabIndex = 0;
            btnMenuControl.UseVisualStyleBackColor = false;
            btnMenuControl.Click += btnMenuControl_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 1;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panelDesktop
            // 
            panelDesktop.AutoScroll = true;
            panelDesktop.Controls.Add(panelControls);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(251, 0);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1315, 948);
            panelDesktop.TabIndex = 9;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(116, 86, 176);
            panelControls.Controls.Add(label1);
            panelControls.Controls.Add(btnMinimize);
            panelControls.Controls.Add(btnMaximize);
            panelControls.Controls.Add(btnCloseApp);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(3, 4, 3, 4);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1315, 47);
            panelControls.TabIndex = 10;
            panelControls.Paint += panelControls_Paint;
            panelControls.MouseDown += panelControls_MouseDown;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(6, 0, 0, 0);
            label1.Size = new Size(304, 47);
            label1.TabIndex = 11;
            label1.Text = "SMART HOME | PROTOTYPE";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI Black", 12F);
            btnMinimize.ForeColor = Color.LimeGreen;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(1228, 0);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(29, 47);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI Black", 12F);
            btnMaximize.ForeColor = Color.Yellow;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(1257, 0);
            btnMaximize.Margin = new Padding(3, 4, 3, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(29, 47);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.Dock = DockStyle.Right;
            btnCloseApp.FlatAppearance.BorderSize = 0;
            btnCloseApp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCloseApp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCloseApp.FlatStyle = FlatStyle.Flat;
            btnCloseApp.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseApp.ForeColor = Color.Red;
            btnCloseApp.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCloseApp.IconColor = Color.White;
            btnCloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseApp.IconSize = 20;
            btnCloseApp.Location = new Point(1286, 0);
            btnCloseApp.Margin = new Padding(0);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(29, 47);
            btnCloseApp.TabIndex = 0;
            btnCloseApp.Text = "X";
            btnCloseApp.UseVisualStyleBackColor = true;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // SideMenuBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 948);
            Controls.Add(panelDesktop);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SideMenuBar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += SideMenuBar_Load_1;
            panelDashboard.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            panelGroup.ResumeLayout(false);
            panelHistory.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelDashboard;
        private Panel panelSettings;
        private FontAwesome.Sharp.IconButton btnSettings;
        private Panel panelGroup;
        private FontAwesome.Sharp.IconButton btnGroup;
        private Panel panelHistory;
        private FontAwesome.Sharp.IconButton btnHistory;
        private Panel panelSidebar;
        private FontAwesome.Sharp.IconButton btnMenuControl;
        private Panel panel8;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panelDesktop;
        private Panel panelControls;
        private FontAwesome.Sharp.IconButton btnCloseApp;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnTypes;
        private FontAwesome.Sharp.IconButton btnProfile;
    }
}
