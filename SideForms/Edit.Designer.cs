namespace SmartHomeSideMenubar
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            btnedit = new Button();
            lbl1 = new Label();
            txtUser = new TextBox();
            txtEmail = new TextBox();
            lbl2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.DarkSlateGray;
            btnedit.FlatAppearance.BorderSize = 0;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.ForeColor = Color.YellowGreen;
            btnedit.Location = new Point(173, 278);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(91, 36);
            btnedit.TabIndex = 0;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.YellowGreen;
            lbl1.Location = new Point(149, 55);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(62, 25);
            lbl1.TabIndex = 1;
            lbl1.Text = "Name";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.DarkCyan;
            txtUser.Location = new Point(128, 93);
            txtUser.Name = "txtUser";
            txtUser.ScrollBars = ScrollBars.Horizontal;
            txtUser.Size = new Size(207, 33);
            txtUser.TabIndex = 2;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DarkCyan;
            txtEmail.Location = new Point(128, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.ScrollBars = ScrollBars.Horizontal;
            txtEmail.Size = new Size(207, 33);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.YellowGreen;
            lbl2.Location = new Point(149, 141);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(73, 25);
            lbl2.TabIndex = 4;
            lbl2.Text = " Email  ";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.DarkCyan;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(82, 93);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 32);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton2.IconColor = Color.DarkCyan;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(82, 191);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(40, 35);
            iconButton2.TabIndex = 6;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(138, 175);
            label1.Name = "label1";
            label1.Size = new Size(156, 13);
            label1.TabIndex = 7;
            label1.Text = "(must be real for login again)";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 361);
            Controls.Add(label1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(lbl2);
            Controls.Add(txtEmail);
            Controls.Add(txtUser);
            Controls.Add(lbl1);
            Controls.Add(btnedit);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnedit;
        private Label lbl1;
        private TextBox txtUser;
        private TextBox txtEmail;
        private Label lbl2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
    }
}