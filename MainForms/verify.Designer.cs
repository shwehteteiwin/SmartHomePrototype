namespace SmartHomeSideMenubar
{
    partial class verify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verify));
            lblveri = new Label();
            lblent = new Label();
            label3 = new Label();
            button1 = new Button();
            txtotp = new TextBox();
            SuspendLayout();
            // 
            // lblveri
            // 
            lblveri.AutoSize = true;
            lblveri.BackColor = Color.Transparent;
            lblveri.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblveri.Location = new Point(166, 41);
            lblveri.Name = "lblveri";
            lblveri.Size = new Size(117, 30);
            lblveri.TabIndex = 0;
            lblveri.Text = "Verification";
            lblveri.Click += lblveri_Click;
            // 
            // lblent
            // 
            lblent.AutoSize = true;
            lblent.BackColor = Color.Transparent;
            lblent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblent.Location = new Point(155, 104);
            lblent.Name = "lblent";
            lblent.Size = new Size(137, 21);
            lblent.TabIndex = 1;
            lblent.Text = "Enter OTP number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 137);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 2;
            label3.Text = "that sent to your email";
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(166, 279);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 3;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtotp
            // 
            txtotp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtotp.Location = new Point(155, 191);
            txtotp.Multiline = true;
            txtotp.Name = "txtotp";
            txtotp.Size = new Size(124, 36);
            txtotp.TabIndex = 4;
            txtotp.TextAlign = HorizontalAlignment.Center;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 361);
            Controls.Add(txtotp);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lblent);
            Controls.Add(lblveri);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblveri;
        private Label lblent;
        private Label label3;
        private Button button1;
        private TextBox txtotp;
    }
}