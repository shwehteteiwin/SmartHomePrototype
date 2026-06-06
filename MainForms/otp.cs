using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;

namespace SmartHomeSideMenubar
{
    public partial class OTP : Form
    {
        public OTP()
        {
            InitializeComponent();
            this.MaximizeBox = false;  
            this.MinimizeBox = false;
        }

        private void lblotp_Click(object sender, EventArgs e)
        {

            
            string email = txtemail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = DbUserHelper.GetUserIdByEmail(email);
            if (userId == -1)
            {
                MessageBox.Show("No account found with that email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string otp = GenerateOTP();

            
            DateTime expiryTime = DateTime.UtcNow.AddMinutes(10);

            // Insert the OTP record into the OTP_Store table
            bool inserted = DbOtpHelper.InsertOTP(userId, otp, expiryTime, out int otpId);  // Now you get the OTP_ID
            if (!inserted)
            {
                MessageBox.Show("Failed to generate OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Send the OTP to the user's email
            try
            { 
                SendOTPEmail(email, otp);
                MessageBox.Show("An OTP has been sent to your email. Please check.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                verify ver = new verify (userId,email);
                ver.Show();

                
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP email. Please try again later.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
    
        private string GenerateOTP()
        {
            Random random = new Random();
            int otpValue = random.Next(100000, 1000000); 
            return otpValue.ToString();
        }

       
        /// Sends an email containing the OTP to the user.
        /// Adjust SMTP settings as needed.
        
        private void SendOTPEmail(string recipientEmail, string otp)
        {
            
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential("nanmyintthu492@gmail.com", "fzhtdovldrielwsw"),
                    EnableSsl = true
                };

                // Construct the email message
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("nanmyintthu492@gmail.com"),
                    Subject = "Your OTP Code",
                    Body = $"Your OTP is: {otp}. It is valid for 10 minutes.",
                    IsBodyHtml = false
                };
                mail.To.Add(recipientEmail);

                // Send the email
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email sending failed: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

