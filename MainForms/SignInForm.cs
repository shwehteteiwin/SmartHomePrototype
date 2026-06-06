using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar;
using SmartHomeSideMenubar.Forms;

namespace SmartHomeSideMenubar
{
    public partial class SignInForm : Form
    {
        
        public SignInForm()
        {
            InitializeComponent();
            this.MaximizeBox = false; 
            this.MinimizeBox = false;
            


        }

        private void btn4back_Click(object sender, EventArgs e)
        {
            
            this.Hide(); 

            FormWelcome originalForm = Application.OpenForms["FormWelcome"] as FormWelcome;

            if (originalForm != null)
            {
                originalForm.Show(); // Show the existing Form1
            }
            else
            {
                MessageBox.Show("Form1 is not open.");
            }
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnuv_Click(object sender, EventArgs e)
        {
            if (txtpwd.PasswordChar == '\0')
            {
                btnv.BringToFront();
                txtpwd.PasswordChar = '*';

            }
        }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            OTP send = new OTP();
            send.Show();
            this.Close();
        }

        private void btn4signin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string password = txtpwd.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate user
            int userId = DbUserHelper.AuthenticateUser(email, password);
            if (userId > 0)
            {
                var userDetails = DbUserHelper.GetUserByEmail(email);

                if (userDetails != null)
                {
                    // Store user details in Properties.Settings
                    SmartHomeSideMenubar.Properties.Settings.Default.IsLoggedIn = true;
                    SmartHomeSideMenubar.Properties.Settings.Default.UserId = userDetails.UserID;
                    SmartHomeSideMenubar.Properties.Settings.Default.Email = userDetails.Email;
                    SmartHomeSideMenubar.Properties.Settings.Default.Username = userDetails.Username;
                    SmartHomeSideMenubar.Properties.Settings.Default.Role = userDetails.Role;

                    SmartHomeSideMenubar.Properties.Settings.Default.Save();  // Save settings
                }
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DbHistoryHelper.InsertHistory($"{SmartHomeSideMenubar.Properties.Settings.Default.Username} (logged in)");

                SideMenuBar dashboard = new SideMenuBar();

                dashboard.Show();
                // Hide Form1 if it is still open (using its name; adjust the name if needed)
                Form form1 = Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.Hide();
                }

                this.Hide();

               
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent beep sound
                txtpwd.Focus(); // Move to the next text box
            }
        }
    }
}
