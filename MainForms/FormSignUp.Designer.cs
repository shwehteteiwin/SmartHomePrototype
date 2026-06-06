using System.Resources;

namespace SmartHomeSideMenubar
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            lblsignup = new Label();
            lblsen = new Label();
            lblun = new Label();
            lblemail = new Label();
            lblpw = new Label();
            lblcpw = new Label();
            txtuser = new TextBox();
            txtemail = new TextBox();
            txtpwd = new TextBox();
            txtcpwd = new TextBox();
            btnsignup = new Button();
            panel1 = new Panel();
            btncv = new Button();
            btncu = new Button();
            btnv = new Button();
            btnuv = new Button();
            button1 = new Button();
            iconbtncpwd = new FontAwesome.Sharp.IconButton();
            iconbtnpwd = new FontAwesome.Sharp.IconButton();
            iconbtnemail = new FontAwesome.Sharp.IconButton();
            iconbtnuser = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblsignup
            // 
            lblsignup.AutoSize = true;
            lblsignup.BackColor = Color.Transparent;
            lblsignup.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsignup.ForeColor = Color.Green;
            lblsignup.Location = new Point(232, 43);
            lblsignup.Name = "lblsignup";
            lblsignup.Size = new Size(142, 46);
            lblsignup.TabIndex = 0;
            lblsignup.Text = "Sign up";
            lblsignup.TextAlign = ContentAlignment.TopCenter;
            lblsignup.Click += lblsignup_Click;
            // 
            // lblsen
            // 
            lblsen.AutoSize = true;
            lblsen.BackColor = Color.Transparent;
            lblsen.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsen.ForeColor = SystemColors.ControlDarkDark;
            lblsen.Location = new Point(148, 104);
            lblsen.Name = "lblsen";
            lblsen.Size = new Size(306, 37);
            lblsen.TabIndex = 1;
            lblsen.Text = "Let's create your account";
            lblsen.TextAlign = ContentAlignment.TopCenter;
            lblsen.Click += lblsen_Click;
            // 
            // lblun
            // 
            lblun.AutoSize = true;
            lblun.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblun.ForeColor = Color.Black;
            lblun.Location = new Point(132, 156);
            lblun.Name = "lblun";
            lblun.Size = new Size(132, 32);
            lblun.TabIndex = 2;
            lblun.Text = "User Name";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.ForeColor = Color.Black;
            lblemail.Location = new Point(132, 257);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(71, 32);
            lblemail.TabIndex = 3;
            lblemail.Text = "Email";
            // 
            // lblpw
            // 
            lblpw.AutoSize = true;
            lblpw.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpw.ForeColor = Color.Black;
            lblpw.Location = new Point(132, 356);
            lblpw.Name = "lblpw";
            lblpw.Size = new Size(111, 32);
            lblpw.TabIndex = 4;
            lblpw.Text = "Password";
            // 
            // lblcpw
            // 
            lblcpw.AutoSize = true;
            lblcpw.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcpw.ForeColor = Color.Black;
            lblcpw.Location = new Point(132, 463);
            lblcpw.Name = "lblcpw";
            lblcpw.Size = new Size(204, 32);
            lblcpw.TabIndex = 5;
            lblcpw.Text = "Confirm Password";
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(128, 192);
            txtuser.Margin = new Padding(3, 4, 3, 4);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(282, 43);
            txtuser.TabIndex = 6;
            txtuser.TextChanged += txtuser_TextChanged;
            txtuser.KeyDown += txtuser_KeyDown;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(128, 293);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.ScrollBars = ScrollBars.Horizontal;
            txtemail.Size = new Size(282, 39);
            txtemail.TabIndex = 7;
            txtemail.KeyDown += txtemail_KeyDown;
            // 
            // txtpwd
            // 
            txtpwd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpwd.Location = new Point(128, 392);
            txtpwd.Margin = new Padding(3, 4, 3, 4);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.ScrollBars = ScrollBars.Horizontal;
            txtpwd.Size = new Size(282, 39);
            txtpwd.TabIndex = 8;
            txtpwd.TextChanged += txtpwd_TextChanged;
            txtpwd.KeyDown += txtpwd_KeyDown;
            // 
            // txtcpwd
            // 
            txtcpwd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpwd.Location = new Point(128, 510);
            txtcpwd.Margin = new Padding(3, 4, 3, 4);
            txtcpwd.Name = "txtcpwd";
            txtcpwd.PasswordChar = '*';
            txtcpwd.ScrollBars = ScrollBars.Horizontal;
            txtcpwd.Size = new Size(282, 39);
            txtcpwd.TabIndex = 9;
            txtcpwd.TextChanged += txtcpwd_TextChanged;
            txtcpwd.KeyDown += txtcpwd_KeyDown;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.FromArgb(0, 64, 0);
            btnsignup.FlatAppearance.BorderSize = 0;
            btnsignup.FlatStyle = FlatStyle.Flat;
            btnsignup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignup.ForeColor = SystemColors.ButtonFace;
            btnsignup.Location = new Point(296, 593);
            btnsignup.Margin = new Padding(3, 4, 3, 4);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(134, 52);
            btnsignup.TabIndex = 10;
            btnsignup.Text = "Sign up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btncv);
            panel1.Controls.Add(btncu);
            panel1.Controls.Add(btnv);
            panel1.Controls.Add(btnuv);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(iconbtncpwd);
            panel1.Controls.Add(iconbtnpwd);
            panel1.Controls.Add(iconbtnemail);
            panel1.Controls.Add(iconbtnuser);
            panel1.Controls.Add(lblsignup);
            panel1.Controls.Add(btnsignup);
            panel1.Controls.Add(lblsen);
            panel1.Controls.Add(txtcpwd);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(lblcpw);
            panel1.Controls.Add(txtpwd);
            panel1.Controls.Add(lblun);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(lblpw);
            panel1.Controls.Add(lblemail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 702);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // btncv
            // 
            btncv.BackColor = Color.White;
            btncv.FlatStyle = FlatStyle.Flat;
            btncv.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btncv.ForeColor = Color.DarkSeaGreen;
            btncv.Location = new Point(345, 511);
            btncv.Margin = new Padding(3, 4, 3, 4);
            btncv.Name = "btncv";
            btncv.Size = new Size(64, 38);
            btncv.TabIndex = 19;
            btncv.Text = "Show";
            btncv.UseVisualStyleBackColor = false;
            btncv.Click += btncv_Click;
            // 
            // btncu
            // 
            btncu.FlatStyle = FlatStyle.Flat;
            btncu.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btncu.ForeColor = Color.DarkSeaGreen;
            btncu.Location = new Point(356, 510);
            btncu.Margin = new Padding(3, 4, 3, 4);
            btncu.Name = "btncu";
            btncu.Size = new Size(53, 38);
            btncu.TabIndex = 18;
            btncu.Text = "Hide";
            btncu.UseVisualStyleBackColor = true;
            btncu.Click += btncu_Click;
            // 
            // btnv
            // 
            btnv.BackColor = Color.White;
            btnv.FlatStyle = FlatStyle.Flat;
            btnv.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnv.ForeColor = Color.DarkSeaGreen;
            btnv.Location = new Point(345, 392);
            btnv.Margin = new Padding(3, 4, 3, 4);
            btnv.Name = "btnv";
            btnv.Size = new Size(65, 39);
            btnv.TabIndex = 17;
            btnv.Text = "Show";
            btnv.UseVisualStyleBackColor = false;
            btnv.Click += btnv_Click;
            // 
            // btnuv
            // 
            btnuv.FlatStyle = FlatStyle.Flat;
            btnuv.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuv.ForeColor = Color.DarkSeaGreen;
            btnuv.Location = new Point(356, 392);
            btnuv.Margin = new Padding(3, 4, 3, 4);
            btnuv.Name = "btnuv";
            btnuv.Size = new Size(54, 39);
            btnuv.TabIndex = 16;
            btnuv.Text = "Hide";
            btnuv.UseVisualStyleBackColor = true;
            btnuv.Click += btnuv_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(65, 593);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // iconbtncpwd
            // 
            iconbtncpwd.FlatStyle = FlatStyle.Flat;
            iconbtncpwd.ForeColor = Color.Transparent;
            iconbtncpwd.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconbtncpwd.IconColor = Color.DarkSeaGreen;
            iconbtncpwd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtncpwd.IconSize = 28;
            iconbtncpwd.Location = new Point(77, 518);
            iconbtncpwd.Margin = new Padding(3, 4, 3, 4);
            iconbtncpwd.Name = "iconbtncpwd";
            iconbtncpwd.Size = new Size(37, 31);
            iconbtncpwd.TabIndex = 14;
            iconbtncpwd.UseVisualStyleBackColor = true;
            // 
            // iconbtnpwd
            // 
            iconbtnpwd.FlatStyle = FlatStyle.Flat;
            iconbtnpwd.ForeColor = Color.Transparent;
            iconbtnpwd.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconbtnpwd.IconColor = Color.DarkSeaGreen;
            iconbtnpwd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnpwd.IconSize = 28;
            iconbtnpwd.Location = new Point(65, 382);
            iconbtnpwd.Margin = new Padding(3, 4, 3, 4);
            iconbtnpwd.Name = "iconbtnpwd";
            iconbtnpwd.Size = new Size(49, 49);
            iconbtnpwd.TabIndex = 13;
            iconbtnpwd.UseVisualStyleBackColor = true;
            // 
            // iconbtnemail
            // 
            iconbtnemail.FlatStyle = FlatStyle.Flat;
            iconbtnemail.ForeColor = Color.Transparent;
            iconbtnemail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconbtnemail.IconColor = Color.DarkSeaGreen;
            iconbtnemail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnemail.IconSize = 28;
            iconbtnemail.Location = new Point(77, 293);
            iconbtnemail.Margin = new Padding(3, 4, 3, 4);
            iconbtnemail.Name = "iconbtnemail";
            iconbtnemail.Size = new Size(45, 49);
            iconbtnemail.TabIndex = 12;
            iconbtnemail.UseVisualStyleBackColor = true;
            // 
            // iconbtnuser
            // 
            iconbtnuser.BackColor = Color.Transparent;
            iconbtnuser.FlatStyle = FlatStyle.Flat;
            iconbtnuser.ForeColor = Color.Transparent;
            iconbtnuser.IconChar = FontAwesome.Sharp.IconChar.User;
            iconbtnuser.IconColor = Color.DarkSeaGreen;
            iconbtnuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnuser.IconSize = 28;
            iconbtnuser.Location = new Point(71, 192);
            iconbtnuser.Margin = new Padding(3, 4, 3, 4);
            iconbtnuser.Name = "iconbtnuser";
            iconbtnuser.Size = new Size(51, 55);
            iconbtnuser.TabIndex = 11;
            iconbtnuser.UseVisualStyleBackColor = false;
            iconbtnuser.Click += iconbtnuser_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(505, 702);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Label lblsignup;
        private Label lblsen;
        private Label lblun;
        private Label lblemail;
        private Label lblpw;
        private Label lblcpw;
        private TextBox txtuser;
        private TextBox txtemail;
        private TextBox txtpwd;
        private TextBox txtcpwd;
        private Button btnsignup;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconbtnuser;
        private FontAwesome.Sharp.IconButton iconbtncpwd;
        private FontAwesome.Sharp.IconButton iconbtnpwd;
        private FontAwesome.Sharp.IconButton iconbtnemail;
        private Button button1;
        private Button btnv;
        private Button btnuv;
        private Button btncv;
        private Button btncu;
    }
}