namespace SmartHomeSideMenubar.Forms
{
    partial class FormType
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
            panelGroupHeaderGrid = new Panel();
            lblHeadergroup = new Label();
            panelGroupButtons = new Panel();
            buttonDeleteSelectedType = new Button();
            buttonAddType = new Button();
            buttonDeleteAllType = new Button();
            panelGroupGrid = new Panel();
            dataGridViewTypes = new DataGridView();
            columnTypeID = new DataGridViewTextBoxColumn();
            columnSelectType = new DataGridViewCheckBoxColumn();
            columnTypeName = new DataGridViewTextBoxColumn();
            columnCreatedAtType = new DataGridViewTextBoxColumn();
            columnUpdatedAtType = new DataGridViewTextBoxColumn();
            btnEditType = new DataGridViewTextBoxColumn();
            btnDeleteType = new DataGridViewTextBoxColumn();
            columnPowerStatus = new DataGridViewCheckBoxColumn();
            roundedPanel1 = new Controls.RoundedPanel();
            roundedPanel2 = new Controls.RoundedPanel();
            roundedPanel3 = new Controls.RoundedPanel();
            panelGroupHeaderGrid.SuspendLayout();
            panelGroupButtons.SuspendLayout();
            panelGroupGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
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
            panelGroupHeaderGrid.Size = new Size(1019, 164);
            panelGroupHeaderGrid.TabIndex = 4;
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
            lblHeadergroup.Text = "Types of Devices";
            lblHeadergroup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGroupButtons
            // 
            panelGroupButtons.Controls.Add(roundedPanel3);
            panelGroupButtons.Controls.Add(roundedPanel2);
            panelGroupButtons.Controls.Add(roundedPanel1);
            panelGroupButtons.Dock = DockStyle.Right;
            panelGroupButtons.Location = new Point(404, 0);
            panelGroupButtons.Margin = new Padding(3, 4, 3, 4);
            panelGroupButtons.Name = "panelGroupButtons";
            panelGroupButtons.Padding = new Padding(34, 40, 34, 40);
            panelGroupButtons.Size = new Size(615, 164);
            panelGroupButtons.TabIndex = 2;
            // 
            // buttonDeleteSelectedType
            // 
            buttonDeleteSelectedType.BackColor = Color.FromArgb(200, 35, 51);
            buttonDeleteSelectedType.Dock = DockStyle.Fill;
            buttonDeleteSelectedType.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonDeleteSelectedType.FlatAppearance.BorderSize = 0;
            buttonDeleteSelectedType.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteSelectedType.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteSelectedType.FlatStyle = FlatStyle.Flat;
            buttonDeleteSelectedType.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            buttonDeleteSelectedType.ForeColor = Color.Snow;
            buttonDeleteSelectedType.Location = new Point(0, 0);
            buttonDeleteSelectedType.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteSelectedType.Name = "buttonDeleteSelectedType";
            buttonDeleteSelectedType.Size = new Size(196, 69);
            buttonDeleteSelectedType.TabIndex = 2;
            buttonDeleteSelectedType.Text = "Delete Seleted Types";
            buttonDeleteSelectedType.UseVisualStyleBackColor = false;
            buttonDeleteSelectedType.Click += buttonDeleteSelectedType_Click;
            // 
            // buttonAddType
            // 
            buttonAddType.BackColor = Color.FromArgb(33, 136, 56);
            buttonAddType.Dock = DockStyle.Fill;
            buttonAddType.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonAddType.FlatAppearance.BorderSize = 0;
            buttonAddType.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 167, 69);
            buttonAddType.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69);
            buttonAddType.FlatStyle = FlatStyle.Flat;
            buttonAddType.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            buttonAddType.ForeColor = Color.Snow;
            buttonAddType.Location = new Point(0, 0);
            buttonAddType.Margin = new Padding(3, 4, 3, 4);
            buttonAddType.Name = "buttonAddType";
            buttonAddType.Size = new Size(136, 68);
            buttonAddType.TabIndex = 1;
            buttonAddType.Text = "Add Type";
            buttonAddType.UseVisualStyleBackColor = false;
            buttonAddType.Click += buttonAddType_Click;
            // 
            // buttonDeleteAllType
            // 
            buttonDeleteAllType.BackColor = Color.FromArgb(200, 35, 51);
            buttonDeleteAllType.Dock = DockStyle.Fill;
            buttonDeleteAllType.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonDeleteAllType.FlatAppearance.BorderSize = 0;
            buttonDeleteAllType.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteAllType.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            buttonDeleteAllType.FlatStyle = FlatStyle.Flat;
            buttonDeleteAllType.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            buttonDeleteAllType.ForeColor = Color.Snow;
            buttonDeleteAllType.Location = new Point(0, 0);
            buttonDeleteAllType.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteAllType.Name = "buttonDeleteAllType";
            buttonDeleteAllType.Size = new Size(131, 69);
            buttonDeleteAllType.TabIndex = 2;
            buttonDeleteAllType.Text = "Delete All Types";
            buttonDeleteAllType.UseVisualStyleBackColor = false;
            buttonDeleteAllType.Click += buttonDeleteAllType_Click;
            // 
            // panelGroupGrid
            // 
            panelGroupGrid.BackColor = Color.Transparent;
            panelGroupGrid.Controls.Add(dataGridViewTypes);
            panelGroupGrid.Dock = DockStyle.Fill;
            panelGroupGrid.Location = new Point(0, 164);
            panelGroupGrid.Margin = new Padding(34, 40, 34, 40);
            panelGroupGrid.Name = "panelGroupGrid";
            panelGroupGrid.Padding = new Padding(29, 33, 29, 33);
            panelGroupGrid.Size = new Size(1019, 524);
            panelGroupGrid.TabIndex = 5;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AllowUserToAddRows = false;
            dataGridViewTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 240, 255);
            dataGridViewTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTypes.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 37, 88);
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTypes.ColumnHeadersHeight = 55;
            dataGridViewTypes.Columns.AddRange(new DataGridViewColumn[] { columnTypeID, columnSelectType, columnTypeName, columnCreatedAtType, columnUpdatedAtType, btnEditType, btnDeleteType, columnPowerStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(8, 29, 69);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTypes.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.EnableHeadersVisualStyles = false;
            dataGridViewTypes.GridColor = Color.Gainsboro;
            dataGridViewTypes.Location = new Point(29, 33);
            dataGridViewTypes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.RowHeadersVisible = false;
            dataGridViewTypes.RowHeadersWidth = 51;
            dataGridViewTypes.RowTemplate.Height = 45;
            dataGridViewTypes.Size = new Size(961, 458);
            dataGridViewTypes.TabIndex = 1;
            dataGridViewTypes.CellContentClick += dataGridViewTypes_CellContentClick;
            // 
            // columnTypeID
            // 
            columnTypeID.HeaderText = "Type ID";
            columnTypeID.MinimumWidth = 6;
            columnTypeID.Name = "columnTypeID";
            columnTypeID.Visible = false;
            columnTypeID.Width = 125;
            // 
            // columnSelectType
            // 
            columnSelectType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnSelectType.FillWeight = 200F;
            columnSelectType.HeaderText = "Select";
            columnSelectType.MinimumWidth = 70;
            columnSelectType.Name = "columnSelectType";
            // 
            // columnTypeName
            // 
            columnTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnTypeName.FillWeight = 200F;
            columnTypeName.HeaderText = "Types";
            columnTypeName.MinimumWidth = 100;
            columnTypeName.Name = "columnTypeName";
            // 
            // columnCreatedAtType
            // 
            columnCreatedAtType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCreatedAtType.FillWeight = 200F;
            columnCreatedAtType.HeaderText = "Created At";
            columnCreatedAtType.MinimumWidth = 100;
            columnCreatedAtType.Name = "columnCreatedAtType";
            columnCreatedAtType.Resizable = DataGridViewTriState.True;
            columnCreatedAtType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnUpdatedAtType
            // 
            columnUpdatedAtType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnUpdatedAtType.FillWeight = 200F;
            columnUpdatedAtType.HeaderText = "Updated At";
            columnUpdatedAtType.MinimumWidth = 100;
            columnUpdatedAtType.Name = "columnUpdatedAtType";
            columnUpdatedAtType.Resizable = DataGridViewTriState.True;
            columnUpdatedAtType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnEditType
            // 
            btnEditType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.DarkBlue;
            btnEditType.DefaultCellStyle = dataGridViewCellStyle3;
            btnEditType.FillWeight = 200F;
            btnEditType.HeaderText = "Edit";
            btnEditType.MinimumWidth = 80;
            btnEditType.Name = "btnEditType";
            btnEditType.Resizable = DataGridViewTriState.True;
            btnEditType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDeleteType
            // 
            btnDeleteType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.DarkRed;
            btnDeleteType.DefaultCellStyle = dataGridViewCellStyle4;
            btnDeleteType.FillWeight = 200F;
            btnDeleteType.HeaderText = "Delete";
            btnDeleteType.MinimumWidth = 80;
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Resizable = DataGridViewTriState.True;
            btnDeleteType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnPowerStatus
            // 
            columnPowerStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPowerStatus.FillWeight = 200F;
            columnPowerStatus.HeaderText = "Status";
            columnPowerStatus.MinimumWidth = 50;
            columnPowerStatus.Name = "columnPowerStatus";
            columnPowerStatus.Visible = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(buttonAddType);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngle = 90F;
            roundedPanel1.Location = new Point(111, 54);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(136, 68);
            roundedPanel1.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(buttonDeleteAllType);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.GradientAngle = 90F;
            roundedPanel2.Location = new Point(253, 54);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(131, 69);
            roundedPanel2.TabIndex = 4;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderRadius = 30;
            roundedPanel3.Controls.Add(buttonDeleteSelectedType);
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.GradientAngle = 90F;
            roundedPanel3.Location = new Point(390, 53);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(196, 69);
            roundedPanel3.TabIndex = 5;
            // 
            // FormType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 688);
            Controls.Add(panelGroupGrid);
            Controls.Add(panelGroupHeaderGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormType";
            Text = "FormType";
            Load += FormType_Load;
            panelGroupHeaderGrid.ResumeLayout(false);
            panelGroupButtons.ResumeLayout(false);
            panelGroupGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGroupHeaderGrid;
        private Label lblHeadergroup;
        private Panel panelGroupButtons;
        private Button buttonDeleteSelectedType;
        private Button buttonAddType;
        private Button buttonDeleteAllType;
        private Panel panelGroupGrid;
        private DataGridView dataGridViewTypes;
        private DataGridViewTextBoxColumn columnTypeID;
        private DataGridViewCheckBoxColumn columnSelectType;
        private DataGridViewTextBoxColumn columnTypeName;
        private DataGridViewTextBoxColumn columnCreatedAtType;
        private DataGridViewTextBoxColumn columnUpdatedAtType;
        private DataGridViewTextBoxColumn btnEditType;
        private DataGridViewTextBoxColumn btnDeleteType;
        private DataGridViewCheckBoxColumn columnPowerStatus;
        private Controls.RoundedPanel roundedPanel2;
        private Controls.RoundedPanel roundedPanel1;
        private Controls.RoundedPanel roundedPanel3;
    }
}