using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar;



namespace SmartHomeSideMenubar
{
    public partial class Profile : Form
    {

        public Profile()
        {
            InitializeComponent();
        }
        public void UpdateProfileLabels(string newName, string newEmail)
        {
            lbln.Text = newName;
            lble.Text = newEmail;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            if (lbln != null && lble != null)
            {



                // Set labels instead of textboxes
                lbln.Text = Properties.Settings.Default.Username;
                lble.Text = Properties.Settings.Default.Email;

                // Load profile photo from database
                LoadProfilePhoto(Properties.Settings.Default.UserId);
            }
        }

        private void LoadProfilePhoto(int userId)
        {
            byte[] imageData = DbUserHelper.GetUserProfilePhoto(userId);
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbx.Image = Image.FromStream(ms);
                }
            }
        }



        private void LogoutUser()
        {
            DbHistoryHelper.InsertHistory($"{Properties.Settings.Default.Username} (logged out) ");

            // Reset user session data
            Properties.Settings.Default.IsLoggedIn = false;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Email = "";
            Properties.Settings.Default.Role = "";
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Save(); // Save the changes


            MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to login form
            FormWelcome loginForm = new FormWelcome();
            loginForm.Show();

            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is FormWelcome)) // Keep the login form open
                {
                    form.Close();
                }
            }
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pbx.Image = Image.FromFile(filePath);

                // Save to database
                DbUserHelper.SaveProfilePhoto(Properties.Settings.Default.UserId, filePath);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Edit ed = new Edit(this);
            ed.Show();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            LogoutUser(); // Call the logout function
        }
    }
}
