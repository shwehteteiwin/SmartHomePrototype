using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartHomeSideMenubar
{
    public partial class Edit : Form
    {
        private Profile profileForm;
       
        

        public Edit(Profile form)
        {
            InitializeComponent();
            this.MaximizeBox = false;  
            this.MinimizeBox = false;
            profileForm = form;
            
            txtUser.Text = Properties.Settings.Default.Username;
            txtEmail.Text = Properties.Settings.Default.Email;
        }
        
       
        private void btnedit_Click(object sender, EventArgs e)
        {
            // Store the current email before updating
            string currentUserEmail = Properties.Settings.Default.Email;

            // Get new name and email from textboxes
            string newName = txtUser.Text.Trim();
            string newEmail = txtEmail.Text.Trim();

           
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
          

            // Check if name and email have changed
            if (newName == Properties.Settings.Default.Username && newEmail == currentUserEmail)
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve user ID using old email
            int userId = DbUserHelper.GetUserIdByEmail(currentUserEmail);
            if (userId == -1)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the database
            bool isUpdated = DbUserHelper.UpdateUserProfile(userId, newName, newEmail);

            if (isUpdated)
            {
                // Update Properties.Settings with new values
                Properties.Settings.Default.Username = newName;
                Properties.Settings.Default.Email = newEmail;
                Properties.Settings.Default.Save();

                // Update Profile form labels
                profileForm.UpdateProfileLabels(newName, newEmail);
               

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the edit form
            }
            else
            {
                MessageBox.Show("Error updating profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent beep sound
                txtEmail.Focus(); // Move to the next text box
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
