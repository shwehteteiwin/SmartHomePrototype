namespace SmartHomeSideMenubar.Welcome
{
    partial class FormReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReset));
            lbl1 = new Label();
            lblpwd = new Label();
            lblcpwd = new Label();
            txtpwd = new TextBox();
            txtcpwd = new TextBox();
            btnr = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnuv = new Button();
            btnv = new Button();
            btncu = new Button();
            btncv = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.DarkOliveGreen;
            lbl1.Location = new Point(121, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(317, 37);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enter Your New Password";
            // 
            // lblpwd
            // 
            lblpwd.AutoSize = true;
            lblpwd.BackColor = Color.Transparent;
            lblpwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpwd.ForeColor = Color.DarkOliveGreen;
            lblpwd.Location = new Point(168, 113);
            lblpwd.Name = "lblpwd";
            lblpwd.Size = new Size(137, 28);
            lblpwd.TabIndex = 1;
            lblpwd.Text = "New Password";
            // 
            // lblcpwd
            // 
            lblcpwd.AutoSize = true;
            lblcpwd.BackColor = Color.Transparent;
            lblcpwd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcpwd.ForeColor = Color.DarkOliveGreen;
            lblcpwd.Location = new Point(168, 244);
            lblcpwd.Name = "lblcpwd";
            lblcpwd.Size = new Size(168, 28);
            lblcpwd.TabIndex = 2;
            lblcpwd.Text = "Confirm Password";
            // 
            // txtpwd
            // 
            txtpwd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpwd.ForeColor = Color.MediumAquamarine;
            txtpwd.Location = new Point(153, 160);
            txtpwd.Margin = new Padding(3, 4, 3, 4);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.ScrollBars = ScrollBars.Horizontal;
            txtpwd.Size = new Size(251, 39);
            txtpwd.TabIndex = 3;
            txtpwd.KeyDown += txtpwd_KeyDown;
            // 
            // txtcpwd
            // 
            txtcpwd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpwd.ForeColor = Color.MediumAquamarine;
            txtcpwd.Location = new Point(153, 291);
            txtcpwd.Margin = new Padding(3, 4, 3, 4);
            txtcpwd.Name = "txtcpwd";
            txtcpwd.PasswordChar = '*';
            txtcpwd.ScrollBars = ScrollBars.Horizontal;
            txtcpwd.Size = new Size(251, 39);
            txtcpwd.TabIndex = 4;
            // 
            // btnr
            // 
            btnr.BackColor = Color.DarkSeaGreen;
            btnr.FlatAppearance.BorderSize = 0;
            btnr.FlatStyle = FlatStyle.Flat;
            btnr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnr.ForeColor = Color.DarkOliveGreen;
            btnr.Location = new Point(195, 380);
            btnr.Margin = new Padding(3, 4, 3, 4);
            btnr.Name = "btnr";
            btnr.Size = new Size(113, 49);
            btnr.TabIndex = 5;
            btnr.Text = "Reset ";
            btnr.UseVisualStyleBackColor = false;
            btnr.Click += btnr_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconButton1.IconColor = Color.SeaGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(101, 160);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(46, 47);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconButton2.IconColor = Color.SeaGreen;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(101, 291);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(46, 47);
            iconButton2.TabIndex = 7;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnuv
            // 
            btnuv.BackColor = Color.Transparent;
            btnuv.FlatStyle = FlatStyle.Flat;
            btnuv.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuv.ForeColor = Color.DarkGreen;
            btnuv.Location = new Point(346, 160);
            btnuv.Margin = new Padding(3, 4, 3, 4);
            btnuv.Name = "btnuv";
            btnuv.Size = new Size(58, 39);
            btnuv.TabIndex = 8;
            btnuv.Text = "Hide";
            btnuv.UseVisualStyleBackColor = false;
            btnuv.Click += btnuv_Click;
            // 
            // btnv
            // 
            btnv.BackColor = Color.Transparent;
            btnv.FlatStyle = FlatStyle.Flat;
            btnv.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnv.ForeColor = Color.DarkGreen;
            btnv.Location = new Point(346, 160);
            btnv.Margin = new Padding(3, 4, 3, 4);
            btnv.Name = "btnv";
            btnv.Size = new Size(58, 39);
            btnv.TabIndex = 9;
            btnv.Text = "Show";
            btnv.UseVisualStyleBackColor = false;
            btnv.Click += btnv_Click;
            // 
            // btncu
            // 
            btncu.BackColor = Color.Transparent;
            btncu.FlatStyle = FlatStyle.Flat;
            btncu.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btncu.ForeColor = Color.DarkGreen;
            btncu.Location = new Point(351, 291);
            btncu.Margin = new Padding(3, 4, 3, 4);
            btncu.Name = "btncu";
            btncu.Size = new Size(54, 39);
            btncu.TabIndex = 10;
            btncu.Text = "Hide";
            btncu.UseVisualStyleBackColor = false;
            btncu.Click += btncu_Click;
            // 
            // btncv
            // 
            btncv.BackColor = Color.Transparent;
            btncv.FlatStyle = FlatStyle.Flat;
            btncv.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btncv.ForeColor = Color.DarkGreen;
            btncv.Location = new Point(346, 291);
            btncv.Margin = new Padding(3, 4, 3, 4);
            btncv.Name = "btncv";
            btncv.Size = new Size(59, 39);
            btncv.TabIndex = 11;
            btncv.Text = "Show";
            btncv.UseVisualStyleBackColor = false;
            btncv.Click += btncv_Click;
            // 
            // FormReset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 481);
            Controls.Add(btncv);
            Controls.Add(btncu);
            Controls.Add(btnv);
            Controls.Add(btnuv);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(btnr);
            Controls.Add(txtcpwd);
            Controls.Add(txtpwd);
            Controls.Add(lblcpwd);
            Controls.Add(lblpwd);
            Controls.Add(lbl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReset";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblpwd;
        private Label lblcpwd;
        private TextBox txtpwd;
        private TextBox txtcpwd;
        private Button btnr;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button btnuv;
        private Button btnv;
        private Button btncu;
        private Button btncv;
    }
}