namespace SmartHomeSideMenubar.SideForms
{
    partial class EditDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeviceForm));
            cmbDeviceGroups = new ComboBox();
            label1 = new Label();
            cmbDeviceType = new ComboBox();
            lblDeviceName = new Label();
            txtDeviceName = new TextBox();
            lblDeviceType = new Label();
            lblAdjustable = new Label();
            chkIsReal = new CheckBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbDeviceGroups
            // 
            cmbDeviceGroups.FormattingEnabled = true;
            cmbDeviceGroups.Location = new Point(249, 239);
            cmbDeviceGroups.Margin = new Padding(3, 4, 3, 4);
            cmbDeviceGroups.Name = "cmbDeviceGroups";
            cmbDeviceGroups.Size = new Size(138, 28);
            cmbDeviceGroups.TabIndex = 23;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 239);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 22;
            label1.Text = "Device Group:";
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Location = new Point(249, 155);
            cmbDeviceType.Margin = new Padding(3, 4, 3, 4);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(138, 28);
            cmbDeviceType.TabIndex = 21;
            // 
            // lblDeviceName
            // 
            lblDeviceName.BackColor = Color.Transparent;
            lblDeviceName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceName.Location = new Point(98, 84);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(114, 31);
            lblDeviceName.TabIndex = 13;
            lblDeviceName.Text = "Device Name:";
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(249, 84);
            txtDeviceName.Margin = new Padding(3, 4, 3, 4);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(114, 27);
            txtDeviceName.TabIndex = 14;
            // 
            // lblDeviceType
            // 
            lblDeviceType.BackColor = Color.Transparent;
            lblDeviceType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceType.Location = new Point(98, 159);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(114, 31);
            lblDeviceType.TabIndex = 15;
            lblDeviceType.Text = "Device Type:";
            // 
            // lblAdjustable
            // 
            lblAdjustable.BackColor = Color.Transparent;
            lblAdjustable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdjustable.Location = new Point(98, 313);
            lblAdjustable.Name = "lblAdjustable";
            lblAdjustable.Size = new Size(114, 31);
            lblAdjustable.TabIndex = 18;
            lblAdjustable.Text = "Real Device:";
            // 
            // chkIsReal
            // 
            chkIsReal.BackColor = Color.Transparent;
            chkIsReal.Location = new Point(249, 312);
            chkIsReal.Margin = new Padding(3, 4, 3, 4);
            chkIsReal.Name = "chkIsReal";
            chkIsReal.Size = new Size(119, 32);
            chkIsReal.TabIndex = 19;
            chkIsReal.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CadetBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(187, 393);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 43);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // EditDeviceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 481);
            Controls.Add(cmbDeviceGroups);
            Controls.Add(label1);
            Controls.Add(cmbDeviceType);
            Controls.Add(lblDeviceName);
            Controls.Add(txtDeviceName);
            Controls.Add(lblDeviceType);
            Controls.Add(lblAdjustable);
            Controls.Add(chkIsReal);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDeviceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDeviceGroups;
        private Label label1;
        private ComboBox cmbDeviceType;
        private Label lblDeviceName;
        private TextBox txtDeviceName;
        private Label lblDeviceType;
        private Label lblAdjustable;
        private CheckBox chkIsReal;
        private Button btnSave;
    }
}