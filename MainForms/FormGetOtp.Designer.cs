namespace SmartHomeSideMenubar.Welcome
{
    partial class FormGetOtp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetOtp));
            lblemail = new Label();
            txtemail = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lbl2 = new Label();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.Transparent;
            lblemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.ForeColor = Color.CadetBlue;
            lblemail.Location = new Point(143, 102);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(189, 32);
            lblemail.TabIndex = 0;
            lblemail.Text = "Enter your email";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.ForeColor = Color.CadetBlue;
            txtemail.Location = new Point(143, 155);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.ScrollBars = ScrollBars.Horizontal;
            txtemail.Size = new Size(298, 39);
            txtemail.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton1.IconColor = Color.CadetBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(88, 155);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 49);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.CadetBlue;
            lbl2.Location = new Point(31, 355);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(498, 28);
            lbl2.TabIndex = 3;
            lbl2.Text = "Enter your email and get otp to check your email is real!";
            lbl2.Click += lbl2_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.CadetBlue;
            lbl3.Location = new Point(327, 260);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(101, 32);
            lbl3.TabIndex = 4;
            lbl3.Text = "Get OTP";
            lbl3.Click += lbl3_Click;
            // 
            // FormGetOtp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(557, 481);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(iconButton1);
            Controls.Add(txtemail);
            Controls.Add(lblemail);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGetOtp";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblemail;
        private TextBox txtemail;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lbl2;
        private Label lbl3;
    }
}