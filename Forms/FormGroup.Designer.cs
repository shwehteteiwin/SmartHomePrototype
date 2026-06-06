
namespace SmartHomeSideMenubar.Forms
{
    partial class FormGroup
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            panelGroupGrid = new Panel();
            dataGridViewGroups = new DataGridView();
            columnGroupID = new DataGridViewTextBoxColumn();
            columnSelectGroup = new DataGridViewCheckBoxColumn();
            columnPowerStatus = new DataGridViewCheckBoxColumn();
            columnGroupName = new DataGridViewTextBoxColumn();
            columnCreatedAtGroup = new DataGridViewTextBoxColumn();
            columnUpdatedAtGroup = new DataGridViewTextBoxColumn();
            btnEditGroup = new DataGridViewTextBoxColumn();
            btnDeleteGroup = new DataGridViewTextBoxColumn();
            panelGroupHeaderGrid = new Panel();
            lblHeadergroup = new Label();
            panelGroupButtons = new Panel();
            buttonDeleteSelectedGroups = new Button();
            buttonAddGroup = new Button();
            buttonDeleteAllGroups = new Button();
            roundedPanel1 = new Controls.RoundedPanel();
            roundedPanel2 = new Controls.RoundedPanel();
            roundedPanel3 = new Controls.RoundedPanel();
            panelGroupGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).BeginInit();
            panelGroupHeaderGrid.SuspendLayout();
            panelGroupButtons.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelGroupGrid
            // 
            panelGroupGrid.BackColor = Color.Transparent;
            panelGroupGrid.Controls.Add(dataGridViewGroups);
            panelGroupGrid.Dock = DockStyle.Fill;
            panelGroupGrid.Location = new Point(0, 164);
            panelGroupGrid.Margin = new Padding(34, 40, 34, 40);
            panelGroupGrid.Name = "panelGroupGrid";
            panelGroupGrid.Padding = new Padding(29, 33, 29, 33);
            panelGroupGrid.Size = new Size(1061, 436);
            panelGroupGrid.TabIndex = 4;
            panelGroupGrid.Paint += panelGroupGrid_Paint;
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(230, 240, 255);
            dataGridViewGroups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewGroups.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(10, 37, 88);
            dataGridViewCellStyle12.Font = new Font("Sitka Small", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Snow;
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumOrchid;
            dataGridViewCellStyle12.SelectionForeColor = Color.DarkGreen;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewGroups.ColumnHeadersHeight = 55;
            dataGridViewGroups.Columns.AddRange(new DataGridViewColumn[] { columnGroupID, columnSelectGroup, columnPowerStatus, columnGroupName, columnCreatedAtGroup, columnUpdatedAtGroup, btnEditGroup, btnDeleteGroup });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dataGridViewGroups.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewGroups.Dock = DockStyle.Fill;
            dataGridViewGroups.EnableHeadersVisualStyles = false;
            dataGridViewGroups.GridColor = Color.Gainsboro;
            dataGridViewGroups.Location = new Point(29, 33);
            dataGridViewGroups.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.RowHeadersVisible = false;
            dataGridViewGroups.RowHeadersWidth = 51;
            dataGridViewGroups.RowTemplate.Height = 45;
            dataGridViewGroups.Size = new Size(1003, 370);
            dataGridViewGroups.TabIndex = 1;
            dataGridViewGroups.CellContentClick += dataGridViewGroups_CellContentClick;
            // 
            // columnGroupID
            // 
            columnGroupID.FillWeight = 200F;
            columnGroupID.HeaderText = "Group ID";
            columnGroupID.MinimumWidth = 50;
            columnGroupID.Name = "columnGroupID";
            columnGroupID.Visible = false;
            columnGroupID.Width = 50;
            // 
            // columnSelectGroup
            // 
            columnSelectGroup.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnSelectGroup.FillWeight = 200F;
            columnSelectGroup.HeaderText = "Select";
            columnSelectGroup.MinimumWidth = 70;
            columnSelectGroup.Name = "columnSelectGroup";
            // 
            // columnPowerStatus
            // 
            columnPowerStatus.HeaderText = "Status";
            columnPowerStatus.MinimumWidth = 6;
            columnPowerStatus.Name = "columnPowerStatus";
            columnPowerStatus.Width = 125;
            // 
            // columnGroupName
            // 
            columnGroupName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnGroupName.FillWeight = 200F;
            columnGroupName.HeaderText = "Rooms";
            columnGroupName.MinimumWidth = 100;
            columnGroupName.Name = "columnGroupName";
            // 
            // columnCreatedAtGroup
            // 
            columnCreatedAtGroup.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCreatedAtGroup.FillWeight = 200F;
            columnCreatedAtGroup.HeaderText = "Created At";
            columnCreatedAtGroup.MinimumWidth = 100;
            columnCreatedAtGroup.Name = "columnCreatedAtGroup";
            columnCreatedAtGroup.Resizable = DataGridViewTriState.True;
            columnCreatedAtGroup.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnUpdatedAtGroup
            // 
            columnUpdatedAtGroup.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnUpdatedAtGroup.FillWeight = 200F;
            columnUpdatedAtGroup.HeaderText = "Updated At";
            columnUpdatedAtGroup.MinimumWidth = 100;
            columnUpdatedAtGroup.Name = "columnUpdatedAtGroup";
            columnUpdatedAtGroup.Resizable = DataGridViewTriState.True;
            columnUpdatedAtGroup.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnEditGroup
            // 
            btnEditGroup.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = Color.DarkBlue;
            btnEditGroup.DefaultCellStyle = dataGridViewCellStyle13;
            btnEditGroup.FillWeight = 200F;
            btnEditGroup.HeaderText = "Edit";
            btnEditGroup.MinimumWidth = 80;
            btnEditGroup.Name = "btnEditGroup";
            btnEditGroup.Resizable = DataGridViewTriState.True;
            btnEditGroup.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.DarkRed;
            btnDeleteGroup.DefaultCellStyle = dataGridViewCellStyle14;
            btnDeleteGroup.FillWeight = 200F;
            btnDeleteGroup.HeaderText = "Delete";
            btnDeleteGroup.MinimumWidth = 80;
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Resizable = DataGridViewTriState.True;
            btnDeleteGroup.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panelGroupHeaderGrid
            // 
            panelGroupHeaderGrid.BackColor = Color.Transparent;
            panelGroupHeaderGrid.Controls.Add(lblHeadergroup);
            panelGroupHeaderGrid.Controls.Add(panelGroupButtons);
            panelGroupHeaderGrid.Dock = DockStyle.Top;
            panelGroupHeaderGrid.Location = new Point(0, 0);
            panelGroupHeaderGrid.Margin = new Padding(3, 4, 3, 4);
            panelGroupHeaderGrid.Name = "panelGroupHeaderGrid";
            panelGroupHeaderGrid.Size = new Size(1061, 164);
            panelGroupHeaderGrid.TabIndex = 3;
            // 
            // lblHeadergroup
            // 
            lblHeadergroup.BackColor = Color.Transparent;
            lblHeadergroup.Dock = DockStyle.Left;
            lblHeadergroup.Font = new Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeadergroup.ForeColor = Color.FromArgb(8, 29, 69);
            lblHeadergroup.ImageAlign = ContentAlignment.MiddleLeft;
            lblHeadergroup.Location = new Point(0, 0);
            lblHeadergroup.Name = "lblHeadergroup";
            lblHeadergroup.Padding = new Padding(11, 13, 11, 13);
            lblHeadergroup.Size = new Size(357, 164);
            lblHeadergroup.TabIndex = 0;
            lblHeadergroup.Text = "Rooms For Devices";
            lblHeadergroup.TextAlign = ContentAlignment.MiddleCenter;
            lblHeadergroup.Click += lblHeadergroup_Click;
            // 
            // panelGroupButtons
            // 
            panelGroupButtons.Controls.Add(roundedPanel3);
            panelGroupButtons.Controls.Add(roundedPanel2);
            panelGroupButtons.Controls.Add(roundedPanel1);
            panelGroupButtons.Dock = DockStyle.Right;
            panelGroupButtons.Location = new Point(446, 0);
            panelGroupButtons.Margin = new Padding(3, 4, 3, 4);
            panelGroupButtons.Name = "panelGroupButtons";
            panelGroupButtons.Padding = new Padding(34, 40, 34, 40);
            panelGroupButtons.Size = new Size(615, 164);
            panelGroupButtons.TabIndex = 2;
            // 
            // buttonDeleteSelectedGroups
            // 
            buttonDeleteSelectedGroups.BackColor = Color.FromArgb(200, 35, 51);
            buttonDeleteSelectedGroups.Dock = DockStyle.Fill;
            buttonDeleteSelectedGroups.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonDeleteSelectedGroups.FlatAppearance.BorderSize = 0;
            buttonDeleteSelectedGroups.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteSelectedGroups.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteSelectedGroups.FlatStyle = FlatStyle.Flat;
            buttonDeleteSelectedGroups.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteSelectedGroups.ForeColor = Color.Snow;
            buttonDeleteSelectedGroups.Location = new Point(0, 0);
            buttonDeleteSelectedGroups.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteSelectedGroups.Name = "buttonDeleteSelectedGroups";
            buttonDeleteSelectedGroups.Size = new Size(242, 60);
            buttonDeleteSelectedGroups.TabIndex = 2;
            buttonDeleteSelectedGroups.Text = "Delete Seleted Rooms";
            buttonDeleteSelectedGroups.UseVisualStyleBackColor = false;
            buttonDeleteSelectedGroups.Click += buttonDeleteSelectedGroups_Click_1;
            // 
            // buttonAddGroup
            // 
            buttonAddGroup.BackColor = Color.FromArgb(33, 136, 56);
            buttonAddGroup.Dock = DockStyle.Fill;
            buttonAddGroup.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonAddGroup.FlatAppearance.BorderSize = 0;
            buttonAddGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 167, 69);
            buttonAddGroup.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69);
            buttonAddGroup.FlatStyle = FlatStyle.Flat;
            buttonAddGroup.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddGroup.ForeColor = Color.Snow;
            buttonAddGroup.Location = new Point(0, 0);
            buttonAddGroup.Margin = new Padding(3, 4, 3, 4);
            buttonAddGroup.Name = "buttonAddGroup";
            buttonAddGroup.Size = new Size(132, 57);
            buttonAddGroup.TabIndex = 1;
            buttonAddGroup.Text = "Add Room";
            buttonAddGroup.UseVisualStyleBackColor = false;
            buttonAddGroup.Click += buttonAddGroup_Click_1;
            // 
            // buttonDeleteAllGroups
            // 
            buttonDeleteAllGroups.BackColor = Color.FromArgb(200, 35, 51);
            buttonDeleteAllGroups.Dock = DockStyle.Fill;
            buttonDeleteAllGroups.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonDeleteAllGroups.FlatAppearance.BorderSize = 0;
            buttonDeleteAllGroups.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteAllGroups.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteAllGroups.FlatStyle = FlatStyle.Flat;
            buttonDeleteAllGroups.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteAllGroups.ForeColor = Color.Snow;
            buttonDeleteAllGroups.Location = new Point(0, 0);
            buttonDeleteAllGroups.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteAllGroups.Name = "buttonDeleteAllGroups";
            buttonDeleteAllGroups.Size = new Size(192, 60);
            buttonDeleteAllGroups.TabIndex = 2;
            buttonDeleteAllGroups.Text = "Delete All Rooms";
            buttonDeleteAllGroups.UseVisualStyleBackColor = false;
            buttonDeleteAllGroups.Click += buttonDeleteAllGroups_Click_1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(buttonAddGroup);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngle = 90F;
            roundedPanel1.Location = new Point(9, 64);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(132, 57);
            roundedPanel1.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(buttonDeleteAllGroups);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.GradientAngle = 90F;
            roundedPanel2.Location = new Point(147, 64);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(192, 60);
            roundedPanel2.TabIndex = 4;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderRadius = 30;
            roundedPanel3.Controls.Add(buttonDeleteSelectedGroups);
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.GradientAngle = 90F;
            roundedPanel3.Location = new Point(345, 64);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(242, 60);
            roundedPanel3.TabIndex = 5;
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1061, 600);
            Controls.Add(panelGroupGrid);
            Controls.Add(panelGroupHeaderGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGroup";
            Text = "FormGroup";
            panelGroupGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).EndInit();
            panelGroupHeaderGrid.ResumeLayout(false);
            panelGroupButtons.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGroupGrid;
        private DataGridView dataGridViewGroups;

        private Panel panelGroupHeaderGrid;
        private Label lblHeadergroup;
        private Panel panelGroupButtons;
        private Button buttonDeleteSelectedGroups;
        private Button buttonAddGroup;
        private Button buttonDeleteAllGroups;
        private DataGridViewTextBoxColumn columnGroupID;
        private DataGridViewCheckBoxColumn columnSelectGroup;
        private DataGridViewCheckBoxColumn columnPowerStatus;
        private DataGridViewTextBoxColumn columnGroupName;
        private DataGridViewTextBoxColumn columnCreatedAtGroup;
        private DataGridViewTextBoxColumn columnUpdatedAtGroup;
        private DataGridViewTextBoxColumn btnEditGroup;
        private DataGridViewTextBoxColumn btnDeleteGroup;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedPanel roundedPanel2;
        private Controls.RoundedPanel roundedPanel3;
    }
}