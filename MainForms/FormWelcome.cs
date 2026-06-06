using SmartHomeSideMenubar.Welcome;

namespace SmartHomeSideMenubar
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
            this.MaximizeBox = false;  
            this.MinimizeBox = false;
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            

        }

        private void lblsmart_Click(object sender, EventArgs e)
        {

        }

        private void lblto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignInForm signin = new SignInForm();
            signin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGetOtp check = new FormGetOtp();
            check.Show();
        }
    }
}
