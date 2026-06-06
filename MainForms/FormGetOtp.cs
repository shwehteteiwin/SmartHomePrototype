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
using SmartHomeSideMenubar;

namespace SmartHomeSideMenubar.Welcome
{
    public partial class FormGetOtp : Form
    {
        public FormGetOtp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            // Get the user's email from the textbox
            string email = txtemail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DbUserHelper.IsEmailExists(email))
            {
                MessageBox.Show("Your email is already registered. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int userId = DbUserHelper.GetUserIdByEmail(email);
            // Generate a random OTP (for example, a 6-digit code)g
            string otp = GenerateOTP();

            // Set the OTP expiry time (e.g., 10 minutes from now)
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
                FormEmailOtpVerify otpForm = new FormEmailOtpVerify(userId, email);
                otpForm.Show();

                // Optionally hide the current form so the user focuses on the OTP form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP email. Please try again later.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// Generates a 6-digit OTP code.

        private string GenerateOTP()
        {
            Random random = new Random();
            int otpValue = random.Next(100000, 1000000); // Generates a number between 100000 and 999999
            return otpValue.ToString();
        }


        /// Sends an email containing the OTP to the user.
        /// Adjust SMTP settings as needed.

        private void SendOTPEmail(string recipientEmail, string otp)
        {
            // Configure the SMTP client (example uses Gmail SMTP; update with your credentials and settings)
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

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
