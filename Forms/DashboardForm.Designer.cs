namespace main.Forms
{
    partial class DashboardForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            flpDevices = new FlowLayoutPanel();
            panel5 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnAllDevicesStatus = new SmartHomeSideMenubar.Controls.ToggleButton();
            label4 = new Label();
            lblTotalDevices = new Label();
            lblOpenDevices = new Label();
            lblClosedDevices = new Label();
            panelCounts = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panelCounts.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 125);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 125);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(211, 50);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.Controls.Add(flpDevices);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50);
            panel2.Size = new Size(1307, 823);
            panel2.TabIndex = 1;
            // 
            // flpDevices
            // 
            flpDevices.AutoSize = true;
            flpDevices.Dock = DockStyle.Fill;
            flpDevices.Location = new Point(50, 346);
            flpDevices.Name = "flpDevices";
            flpDevices.Size = new Size(1207, 427);
            flpDevices.TabIndex = 109;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelCounts);
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(50, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(1207, 296);
            panel5.TabIndex = 108;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnAllDevicesStatus);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(561, 63);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 200);
            panel3.TabIndex = 106;
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
            // panelCounts
            // 
            panelCounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCounts.BackColor = Color.White;
            panelCounts.Controls.Add(lblClosedDevices);
            panelCounts.Controls.Add(lblOpenDevices);
            panelCounts.Controls.Add(lblTotalDevices);
            panelCounts.Location = new Point(80, 63);
            panelCounts.Margin = new Padding(3, 4, 3, 4);
            panelCounts.Name = "panelCounts";
            panelCounts.Size = new Size(413, 204);
            panelCounts.TabIndex = 107;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 948);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelCounts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private SmartHomeSideMenubar.Controls.ToggleButton btnAllDevicesStatus;
        private Label label4;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private FlowLayoutPanel flpDevices;
        private Panel panelCounts;
        private Label lblClosedDevices;
        private Label lblOpenDevices;
        private Label lblTotalDevices;
    }
}