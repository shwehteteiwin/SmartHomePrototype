namespace SmartHomeSideMenubar
{
    partial class OTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP));
            txtemail = new TextBox();
            lbleemail = new Label();
            lblsen = new Label();
            lblotp = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.ForeColor = Color.CadetBlue;
            txtemail.Location = new Point(117, 112);
            txtemail.Name = "txtemail";
            txtemail.ScrollBars = ScrollBars.Horizontal;
            txtemail.Size = new Size(259, 33);
            txtemail.TabIndex = 1;
            // 
            // lbleemail
            // 
            lbleemail.AutoSize = true;
            lbleemail.BackColor = Color.Transparent;
            lbleemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbleemail.ForeColor = Color.CadetBlue;
            lbleemail.Location = new Point(117, 71);
            lbleemail.Name = "lbleemail";
            lbleemail.Size = new Size(150, 25);
            lbleemail.TabIndex = 2;
            lbleemail.Text = "Enter your email";
            // 
            // lblsen
            // 
            lblsen.AutoSize = true;
            lblsen.BackColor = Color.Transparent;
            lblsen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsen.ForeColor = Color.CadetBlue;
            lblsen.Location = new Point(51, 264);
            lblsen.Name = "lblsen";
            lblsen.Size = new Size(343, 21);
            lblsen.TabIndex = 3;
            lblsen.Text = "Enter your email, we will send you opt after click";
            // 
            // lblotp
            // 
            lblotp.AutoSize = true;
            lblotp.BackColor = Color.Transparent;
            lblotp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblotp.ForeColor = Color.CadetBlue;
            lblotp.Location = new Point(280, 186);
            lblotp.Name = "lblotp";
            lblotp.Size = new Size(80, 25);
            lblotp.TabIndex = 4;
            lblotp.Text = "Get OTP";
            lblotp.Click += lblotp_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton1.IconColor = Color.CadetBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(70, 112);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(41, 36);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // OTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(434, 361);
            Controls.Add(iconButton1);
            Controls.Add(lblotp);
            Controls.Add(lblsen);
            Controls.Add(lbleemail);
            Controls.Add(txtemail);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "OTP";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtemail;
        private Label lbleemail;
        private Label lblsen;
        private Label lblotp;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}