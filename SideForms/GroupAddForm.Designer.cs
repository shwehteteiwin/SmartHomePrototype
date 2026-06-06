namespace SmartHomeSideMenubar.Forms
{
    partial class GroupAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelGroupName;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupAddForm));
            textBoxGroupName = new TextBox();
            buttonSave = new Button();
            labelGroupName = new Label();
            SuspendLayout();
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Location = new Point(121, 12);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(200, 27);
            textBoxGroupName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightSlateGray;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(119, 58);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.BackColor = Color.Transparent;
            labelGroupName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGroupName.Location = new Point(12, 15);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(103, 20);
            labelGroupName.TabIndex = 0;
            labelGroupName.Text = "Group Name:";
            // 
            // GroupAddForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(338, 100);
            Controls.Add(buttonSave);
            Controls.Add(textBoxGroupName);
            Controls.Add(labelGroupName);
            Name = "GroupAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Group";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}