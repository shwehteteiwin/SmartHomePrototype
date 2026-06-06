namespace SmartHomeSideMenubar
{
    partial class FormWelcome
    {
        private const ImageLayout stretch = ImageLayout.Stretch;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbl4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Doulos SIL", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.Chocolate;
            lbl1.Location = new Point(94, 201);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(275, 92);
            lbl1.TabIndex = 0;
            lbl1.Text = "Welcome";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Location = new Point(873, 336);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(0, 20);
            lbl2.TabIndex = 1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lbl3.ForeColor = Color.OliveDrab;
            lbl3.Location = new Point(486, 323);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(373, 33);
            lbl3.TabIndex = 2;
            lbl3.Text = "Welcome to your intelligent home!";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(446, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 72);
            button1.TabIndex = 3;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(695, 528);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(171, 72);
            button2.TabIndex = 4;
            button2.Text = "Sign in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(873, 336);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(0, 20);
            lbl4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(486, 373);
            label1.Name = "label1";
            label1.Size = new Size(395, 33);
            label1.TabIndex = 6;
            label1.Text = "Let's make your living space smarter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.OliveDrab;
            label2.Location = new Point(560, 419);
            label2.Name = "label2";
            label2.Size = new Size(205, 33);
            label2.TabIndex = 7;
            label2.Text = "and more efficient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Doulos SIL", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(503, 231);
            label3.Name = "label3";
            label3.Size = new Size(356, 92);
            label3.TabIndex = 8;
            label3.Text = "Smart Home";
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 748);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button button1;
        private Button button2;
        private Label lbl4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
