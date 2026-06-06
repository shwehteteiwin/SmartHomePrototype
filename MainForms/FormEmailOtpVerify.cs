using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using SmartHomeSideMenubar;
using SmartHomeSideMenubar.DBQuery;

namespace SmartHomeSideMenubar.Welcome
{
    public partial class FormEmailOtpVerify : Form
    {
        private int userId;
        private string userEmail;
        public FormEmailOtpVerify(int userId,string email)
        {
            InitializeComponent();
            this.userId = userId;
            this.userEmail = email;// Store the email for passing to signup form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            // Retrieve the OTP entered by the user
            string otpEntered = txtotp.Text.Trim();

            if (string.IsNullOrEmpty(otpEntered))
            {
                MessageBox.Show("Please enter the OTP.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the OTP using the DbOtpHelper class
            bool isValid = DbOtpHelper.ValidateOTP(userId, otpEntered);
            if (isValid)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

                FormSignUp sing = new FormSignUp(userEmail);

               sing.Show();

            
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid or expired OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

