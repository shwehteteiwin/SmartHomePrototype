namespace SmartHomeSideMenubar.Welcome
{
    partial class FormEmailOtpVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmailOtpVerify));
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txtotp = new TextBox();
            btnc = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(163, 30);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(117, 30);
            lbl1.TabIndex = 0;
            lbl1.Text = "Verification";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(154, 92);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(137, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Enter OTP number";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(136, 125);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(166, 21);
            lbl3.TabIndex = 2;
            lbl3.Text = "that sent to your email";
            // 
            // txtotp
            // 
            txtotp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtotp.Location = new Point(154, 194);
            txtotp.Multiline = true;
            txtotp.Name = "txtotp";
            txtotp.Size = new Size(117, 33);
            txtotp.TabIndex = 3;
            txtotp.TextAlign = HorizontalAlignment.Center;
            // 
            // btnc
            // 
            btnc.BackColor = Color.Honeydew;
            btnc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnc.Location = new Point(163, 272);
            btnc.Name = "btnc";
            btnc.Size = new Size(89, 36);
            btnc.TabIndex = 4;
            btnc.Text = "Continue";
            btnc.UseVisualStyleBackColor = false;
            btnc.Click += btnc_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 361);
            Controls.Add(btnc);
            Controls.Add(txtotp);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtotp;
        private Button btnc;
    }
}