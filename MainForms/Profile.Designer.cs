using SmartHomeSideMenubar.Controls;
using SmartHomeSideMenubar.Controls;

namespace SmartHomeSideMenubar
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            label1 = new Label();
            panel1 = new Panel();
            lble = new Label();
            lbln = new Label();
            roundedPanel3 = new RoundedPanel();
            pbx = new PictureBox();
            roundedPanel2 = new RoundedPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            roundedPanel1 = new RoundedPanel();
            btnEdit = new FontAwesome.Sharp.IconButton();
            roundedBtn3 = new RoundedBtn();
            roundedBtn2 = new RoundedBtn();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 25F);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 112);
            label1.TabIndex = 31;
            label1.Text = "PROFILE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lble);
            panel1.Controls.Add(lbln);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(roundedBtn3);
            panel1.Controls.Add(roundedBtn2);
            panel1.Controls.Add(iconButton2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 836);
            panel1.TabIndex = 45;
            // 
            // lble
            // 
            lble.BorderStyle = BorderStyle.FixedSingle;
            lble.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble.ForeColor = Color.Indigo;
            lble.Location = new Point(632, 391);
            lble.Name = "lble";
            lble.Size = new Size(277, 51);
            lble.TabIndex = 52;
            lble.Text = "nanmyintthu492@gmail.com";
            lble.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbln
            // 
            lbln.BorderStyle = BorderStyle.FixedSingle;
            lbln.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbln.ForeColor = Color.Indigo;
            lbln.Location = new Point(632, 238);
            lbln.Name = "lbln";
            lbln.Size = new Size(277, 50);
            lbln.TabIndex = 51;
            lbln.Text = "Nang Myint Thu";
            lbln.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BorderColor = Color.Black;
            roundedPanel3.BorderRadius = 10;
            roundedPanel3.BorderSize = 0;
            roundedPanel3.Controls.Add(pbx);
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.Location = new Point(268, 131);
            roundedPanel3.Margin = new Padding(3, 4, 3, 4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(279, 295);
            roundedPanel3.TabIndex = 49;
            // 
            // pbx
            // 
            pbx.BorderStyle = BorderStyle.FixedSingle;
            pbx.Dock = DockStyle.Fill;
            pbx.Image = (Image)resources.GetObject("pbx.Image");
            pbx.Location = new Point(0, 0);
            pbx.Margin = new Padding(3, 4, 3, 4);
            pbx.Name = "pbx";
            pbx.Size = new Size(279, 295);
            pbx.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx.TabIndex = 25;
            pbx.TabStop = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BorderColor = Color.Red;
            roundedPanel2.BorderRadius = 10;
            roundedPanel2.BorderSize = 0;
            roundedPanel2.Controls.Add(iconButton1);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(646, 594);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(157, 53);
            roundedPanel2.TabIndex = 50;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Red;
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(4, 63, 53);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(157, 53);
            iconButton1.TabIndex = 30;
            iconButton1.Text = "Sign Out";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderColor = Color.FromArgb(116, 86, 176);
            roundedPanel1.BorderRadius = 10;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(btnEdit);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.Location = new Point(350, 594);
            roundedPanel1.Margin = new Padding(3, 4, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(157, 53);
            roundedPanel1.TabIndex = 48;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(21, 63, 53);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(21, 63, 53);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 28;
            btnEdit.Location = new Point(0, 0);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(157, 53);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // roundedBtn3
            // 
            roundedBtn3.BackColor = Color.FromArgb(116, 86, 176);
            roundedBtn3.BorderRadius = 30;
            roundedBtn3.FlatAppearance.BorderSize = 0;
            roundedBtn3.FlatStyle = FlatStyle.Flat;
            roundedBtn3.Font = new Font("Segoe UI Black", 10F);
            roundedBtn3.ForeColor = Color.White;
            roundedBtn3.Location = new Point(632, 322);
            roundedBtn3.Margin = new Padding(3, 4, 3, 4);
            roundedBtn3.Name = "roundedBtn3";
            roundedBtn3.Size = new Size(106, 40);
            roundedBtn3.TabIndex = 47;
            roundedBtn3.Text = "Email:";
            roundedBtn3.UseVisualStyleBackColor = false;
            // 
            // roundedBtn2
            // 
            roundedBtn2.BackColor = Color.FromArgb(116, 86, 176);
            roundedBtn2.BorderRadius = 30;
            roundedBtn2.FlatAppearance.BorderSize = 0;
            roundedBtn2.FlatStyle = FlatStyle.Flat;
            roundedBtn2.Font = new Font("Segoe UI Black", 10F);
            roundedBtn2.ForeColor = Color.White;
            roundedBtn2.Location = new Point(632, 167);
            roundedBtn2.Margin = new Padding(3, 4, 3, 4);
            roundedBtn2.Name = "roundedBtn2";
            roundedBtn2.Size = new Size(106, 40);
            roundedBtn2.TabIndex = 46;
            roundedBtn2.Text = "Name:";
            roundedBtn2.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(116, 86, 176);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(268, 434);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(279, 49);
            iconButton2.TabIndex = 45;
            iconButton2.Text = "Update Photo";
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton2.UseMnemonic = false;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 948);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label btnEmail;
        private Label labelUserName;
        private Label lblName;
        private Label lblEmail;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label lble;
        private Label lbln;
        private RoundedPanel roundedPanel3;
        private PictureBox pbx;
        private RoundedPanel roundedPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RoundedPanel roundedPanel1;
        private FontAwesome.Sharp.IconButton btnEdit;
        private RoundedBtn roundedBtn3;
        private RoundedBtn roundedBtn2;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}