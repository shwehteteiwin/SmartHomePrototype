namespace SmartHomeSideMenubar.SideForms
{
    partial class TypeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeAddForm));
            labelTypeName = new Label();
            textBoxTypeName = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTypeName.Location = new Point(12, 15);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(72, 15);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Type Name:";
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Location = new Point(100, 12);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(200, 23);
            textBoxTypeName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightSlateGray;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(115, 58);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // TypeAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(320, 100);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTypeName);
            Controls.Add(labelTypeName);
            Name = "TypeAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TypeAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTypeName;
        private TextBox textBoxTypeName;
        private Button buttonSave;
    }
}