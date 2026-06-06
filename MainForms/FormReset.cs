using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar;
using SmartHomeSideMenubar.DBQuery;

namespace SmartHomeSideMenubar.Welcome
{
    public partial class FormReset : Form
    {
        private string Email;
        public FormReset(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnv_Click(object sender, EventArgs e)
        {
            if (txtpwd.PasswordChar == '*')
            {
                btnuv.BringToFront();
                txtpwd.PasswordChar = '\0';
            }
        }

        private void btnuv_Click(object sender, EventArgs e)
        {
            if (txtpwd.PasswordChar == '\0')
            {
                btnv.BringToFront();
                txtpwd.PasswordChar = '*';
            }
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            string newPassword = txtpwd.Text.Trim();
            string confirmPassword = txtcpwd.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve userId using the current user's email
            string currentUserEmail = Email; // Replace with actual logic to get the current user's email
            int userId = DbUserHelper.GetUserIdByEmail(currentUserEmail);

            bool isUpdated = DbUserHelper.UpdatePassword(userId, newPassword);

            if (isUpdated)
            {
                MessageBox.Show("Password has been updated successfully! Please Sign in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignInForm rein = new SignInForm();
                rein.Show();

                this.Hide();

                // Hide Form1 if it is still open (using its name; adjust the name if needed)
                Form form1 = Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.Hide();
                }

            }
            else
            {
                MessageBox.Show("Error updating password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcpwd.Focus();
            }
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            if (txtcpwd.PasswordChar == '*')
            {
                btncu.BringToFront();
                txtcpwd.PasswordChar = '\0';
            }
        }

        private void btncu_Click(object sender, EventArgs e)
        {
            if (txtcpwd.PasswordChar == '\0')
            {
                btncv.BringToFront();
                txtcpwd.PasswordChar = '*';
            }
        }
    }
}
