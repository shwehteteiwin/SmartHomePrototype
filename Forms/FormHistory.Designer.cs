using SmartHomeSideMenubar.Controls;

namespace SmartHomeSideMenubar.Forms
{
    partial class FormHistory
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
            label2 = new Label();
            panel1 = new Panel();
            roundedPanel3 = new RoundedPanel();
            btnDeleteAll = new Button();
            panel2 = new Panel();
            dataGridViewHistory = new DataGridView();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(50, 50);
            label2.Name = "label2";
            label2.Size = new Size(339, 60);
            label2.TabIndex = 3;
            label2.Text = "Record history";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50, 50, 50, 0);
            panel1.Size = new Size(914, 125);
            panel1.TabIndex = 4;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BorderColor = Color.DarkGreen;
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.BorderSize = 2;
            roundedPanel3.Controls.Add(btnDeleteAll);
            roundedPanel3.Dock = DockStyle.Right;
            roundedPanel3.Location = new Point(725, 50);
            roundedPanel3.Margin = new Padding(3, 4, 3, 4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(139, 75);
            roundedPanel3.TabIndex = 9;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(200, 35, 51);
            btnDeleteAll.Dock = DockStyle.Fill;
            btnDeleteAll.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 53, 69);
            btnDeleteAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAll.ForeColor = Color.Snow;
            btnDeleteAll.Location = new Point(0, 0);
            btnDeleteAll.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(139, 75);
            btnDeleteAll.TabIndex = 7;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewHistory);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50);
            panel2.Size = new Size(914, 475);
            panel2.TabIndex = 4;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.AllowUserToDeleteRows = false;
            dataGridViewHistory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHistory.ColumnHeadersHeight = 55;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(50, 50);
            dataGridViewHistory.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.Size = new Size(814, 375);
            dataGridViewHistory.TabIndex = 2;
            dataGridViewHistory.CellContentClick += dataGridViewHistory_CellContentClick_1;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHistory";
            Text = "FormHistory";
            Load += FormHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewHistory;
        private RoundedPanel roundedPanel3;
        private Button btnDeleteAll;
    }
}