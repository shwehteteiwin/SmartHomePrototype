
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace SmartHomeSideMenubar
{
    public partial class FormSignUp : Form
    {
        private string email;
        public FormSignUp(string userEmail)
        {
            InitializeComponent();
            DbHelper.CreateTables();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.email = userEmail;
            txtemail.Text = email;
            txtemail.ReadOnly = true;


        }



        private void lblsignup_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email format regex
            return Regex.IsMatch(email, pattern);
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {


            string username = txtuser.Text.Trim();
            string email = this.email;
            string password = txtpwd.Text;
            string confirmPassword = txtcpwd.Text;
            string role = "User"; // Default role

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate Email Format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = DbUserHelper.InsertUser(username, email, password, role);

            if (success)
            {
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int userId = DbUserHelper.GetUserIdByEmail(email);

                // Check the role of the registered user
                role = DbUserHelper.GetUserRoleByEmail(email);
                SmartHomeSideMenubar.Properties.Settings.Default.UserId = userId;
                SmartHomeSideMenubar.Properties.Settings.Default.Username = username;
                SmartHomeSideMenubar.Properties.Settings.Default.Email = email;
                SmartHomeSideMenubar.Properties.Settings.Default.Role = role;
                SmartHomeSideMenubar.Properties.Settings.Default.IsLoggedIn = true;
                SmartHomeSideMenubar.Properties.Settings.Default.Save();

                if (role == "Admin")
                {

                    SuccessForm successPage = new SuccessForm();
                    successPage.Show();
                }
                else
                {
                    DbHistoryHelper.InsertHistory($"{SmartHomeSideMenubar.Properties.Settings.Default.Username} (Signed up)");

                    SideMenuBar dashboard = new SideMenuBar();

                    dashboard.Show();
                }
                // Hide Form1 if it is still open (using its name; adjust the name if needed)
                Form form1 = Application.OpenForms["Form1"];
                if (form1 != null)
                {
                    form1.Hide();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            FormWelcome originalForm = Application.OpenForms["Form1"] as FormWelcome;

            if (originalForm != null)
            {
                originalForm.Show(); // Show the existing Form1
            }
            else
            {
                MessageBox.Show("Form1 is not open.");
            }
        }

        private void iconbtnuser_Click(object sender, EventArgs e)
        {

        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent beep sound
                txtemail.Focus(); // Move to the next text box
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtpwd.Focus();
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

        private void txtcpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnsignup.PerformClick();
            }
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

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void lblsen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
