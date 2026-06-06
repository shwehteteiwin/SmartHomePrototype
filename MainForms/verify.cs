using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar;
using SmartHomeSideMenubar.Welcome;

namespace SmartHomeSideMenubar
{
    public partial class verify : Form
    {
        private int userId;
        private string email;
        public verify(int userId,string email)
        {
            InitializeComponent();
            this.userId = userId;
            this.email = email;
            this.MaximizeBox = false;  
            this.MinimizeBox = false;
        }

        private void lblveri_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        
     
            // Retrieve the OTP entered by the user
            string otpEntered = txtotp.Text.Trim();

            if (string.IsNullOrEmpty(otpEntered))
            {
                MessageBox.Show("Please enter the OTP.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool isValid = DbOtpHelper.ValidateOTP(userId, otpEntered);
            if (isValid)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormReset reset = new FormReset(email);

                reset.Show();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid or expired OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

