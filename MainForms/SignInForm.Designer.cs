namespace SmartHomeSideMenubar
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lblpass = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtemail = new TextBox();
            txtpwd = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            lblemm = new Label();
            btn4back = new Button();
            btn4signin = new Button();
            lblsignin = new Label();
            btnuv = new Button();
            btnv = new Button();
            lblforgot = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpass.ForeColor = Color.Teal;
            lblpass.Location = new Point(109, 203);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(122, 32);
            lblpass.TabIndex = 2;
            lblpass.Text = "Password";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton1.IconColor = Color.FromArgb(0, 192, 192);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 34;
            iconButton1.Location = new Point(58, 141);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 40);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.ForeColor = Color.Teal;
            txtemail.Location = new Point(109, 137);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.ScrollBars = ScrollBars.Horizontal;
            txtemail.Size = new Size(260, 39);
            txtemail.TabIndex = 5;
            txtemail.TextChanged += textBox1_TextChanged;
            txtemail.KeyDown += txtemail_KeyDown;
            // 
            // txtpwd
            // 
            txtpwd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpwd.ForeColor = Color.Teal;
            txtpwd.Location = new Point(107, 239);
            txtpwd.Margin = new Padding(3, 4, 3, 4);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.ScrollBars = ScrollBars.Horizontal;
            txtpwd.Size = new Size(260, 39);
            txtpwd.TabIndex = 6;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Transparent;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconButton2.IconColor = Color.Teal;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(58, 234);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(43, 44);
            iconButton2.TabIndex = 9;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // lblemm
            // 
            lblemm.AutoSize = true;
            lblemm.BackColor = Color.Transparent;
            lblemm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblemm.ForeColor = Color.Teal;
            lblemm.Location = new Point(109, 101);
            lblemm.Name = "lblemm";
            lblemm.Size = new Size(76, 32);
            lblemm.TabIndex = 1;
            lblemm.Text = "Email";
            // 
            // btn4back
            // 
            btn4back.BackColor = SystemColors.ActiveCaption;
            btn4back.FlatAppearance.BorderSize = 0;
            btn4back.FlatStyle = FlatStyle.Flat;
            btn4back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4back.ForeColor = SystemColors.ActiveCaptionText;
            btn4back.Location = new Point(54, 396);
            btn4back.Margin = new Padding(3, 4, 3, 4);
            btn4back.Name = "btn4back";
            btn4back.Size = new Size(131, 49);
            btn4back.TabIndex = 4;
            btn4back.Text = "Back";
            btn4back.UseVisualStyleBackColor = false;
            btn4back.Click += btn4back_Click;
            // 
            // btn4signin
            // 
            btn4signin.BackColor = SystemColors.ActiveCaption;
            btn4signin.FlatAppearance.BorderSize = 0;
            btn4signin.FlatStyle = FlatStyle.Flat;
            btn4signin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4signin.ForeColor = Color.Black;
            btn4signin.Location = new Point(232, 396);
            btn4signin.Margin = new Padding(3, 4, 3, 4);
            btn4signin.Name = "btn4signin";
            btn4signin.Size = new Size(137, 49);
            btn4signin.TabIndex = 7;
            btn4signin.Text = "Sign in";
            btn4signin.UseVisualStyleBackColor = false;
            btn4signin.Click += btn4signin_Click;
            // 
            // lblsignin
            // 
            lblsignin.AutoSize = true;
            lblsignin.BackColor = Color.Transparent;
            lblsignin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsignin.ForeColor = Color.Teal;
            lblsignin.Location = new Point(157, 23);
            lblsignin.Name = "lblsignin";
            lblsignin.Size = new Size(131, 46);
            lblsignin.TabIndex = 0;
            lblsignin.Text = "Sign in";
            // 
            // btnuv
            // 
            btnuv.BackColor = Color.White;
            btnuv.FlatStyle = FlatStyle.Flat;
            btnuv.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuv.ForeColor = Color.Teal;
            btnuv.Location = new Point(308, 239);
            btnuv.Margin = new Padding(3, 4, 3, 4);
            btnuv.Name = "btnuv";
            btnuv.Size = new Size(59, 39);
            btnuv.TabIndex = 11;
            btnuv.Text = "Hide";
            btnuv.UseVisualStyleBackColor = false;
            btnuv.Click += btnuv_Click;
            // 
            // btnv
            // 
            btnv.BackColor = Color.White;
            btnv.FlatStyle = FlatStyle.Flat;
            btnv.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnv.ForeColor = Color.Teal;
            btnv.Location = new Point(308, 239);
            btnv.Margin = new Padding(3, 4, 3, 4);
            btnv.Name = "btnv";
            btnv.Size = new Size(59, 39);
            btnv.TabIndex = 12;
            btnv.Text = "Show";
            btnv.UseVisualStyleBackColor = false;
            btnv.Click += btnv_Click;
            // 
            // lblforgot
            // 
            lblforgot.AutoSize = true;
            lblforgot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblforgot.ForeColor = Color.Teal;
            lblforgot.Location = new Point(222, 316);
            lblforgot.Name = "lblforgot";
            lblforgot.Size = new Size(158, 28);
            lblforgot.TabIndex = 13;
            lblforgot.Text = "Forgot Password";
            lblforgot.Click += lblforgot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblforgot);
            panel1.Controls.Add(btnv);
            panel1.Controls.Add(btnuv);
            panel1.Controls.Add(lblsignin);
            panel1.Controls.Add(btn4signin);
            panel1.Controls.Add(btn4back);
            panel1.Controls.Add(lblemm);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(txtpwd);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(lblpass);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(37, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 527);
            panel1.TabIndex = 11;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 553);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form4_Load;
            Resize += Form4_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblpass;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtemail;
        private TextBox txtpwd;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label lblemm;
        private Button btn4back;
        private Button btn4signin;
        private Label lblsignin;
        private Button btnuv;
        private Button btnv;
        private Label lblforgot;
        private Panel panel1;
    }
}