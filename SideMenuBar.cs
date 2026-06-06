using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Microsoft.Windows.Themes;
using OpcLabs.BaseLib.Collections.ObjectModel;


namespace SmartHomeSideMenubar
{
    public partial class SideMenuBar : Form
    {
        private IconButton currentBtn;
        private Form activeForm;
        private Color basic_color = Color.FromArgb(4, 32, 33);
        private Color focus_color = Color.FromArgb(21, 63, 53);
        private Color hover_color = Color.FromArgb(7, 45, 38);
        public SideMenuBar()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSidebar.Width -= 5;
                if (panelSidebar.Width <= 69)
                {
                    sidebarExpand = false;
                    btnMenuControl.Location = new Point(5, 5);
                    sidebarTransition.Stop();
                    UpdatePanelWidth();
                }
            }
            else
            {
                panelSidebar.Width += 5;
                if (panelSidebar.Width >= 210)
                {
                    sidebarExpand = true;
                    btnMenuControl.Location = new Point(170, 5);
                    sidebarTransition.Stop();
                    UpdatePanelWidth();
                }
            }
        }

        private void btnMenuControl_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void UpdatePanelWidth()
        {
            panelDashboard.Width = panelSidebar.Width;
            panelGroup.Width = panelSidebar.Width;
            panelHistory.Width = panelSidebar.Width;
            panelSettings.Width = panelSidebar.Width;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                Color color = focus_color;
                currentBtn = (IconButton)btnSender;
                currentBtn.BackColor = color;
                currentBtn.FlatAppearance.MouseOverBackColor = color;
                currentBtn.FlatAppearance.MouseDownBackColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = basic_color;
                currentBtn.FlatAppearance.MouseOverBackColor = hover_color;
                currentBtn.FlatAppearance.MouseDownBackColor = hover_color;
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) { activeForm.Close(); }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDevicesControl(), sender);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDevicesControl(), sender);
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNoti(), sender);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGroup(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Role != "User")
            {

                OpenChildForm(new Forms.FormHistory(), sender);

            }
            else
            {
                MessageBox.Show("Access denied! This page is for Admins only.");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Role != "User")
            {

                OpenChildForm(new Forms.FormUserList(), sender);

            }
            else
            {
                MessageBox.Show("Access denied! This page is for Admins only.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /* private void SideMenuBar_Load(object sender, EventArgs e)
         {
             // Check if user is logged in
             if (Properties.Settings.Default.IsLoggedIn)
             {
                 string username = Properties.Settings.Default.Username;
                 string email = Properties.Settings.Default.Email;

                 // Load user data into UI

             }
             else
             {
                 MessageBox.Show("You are not logged in. Redirecting to Login page.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                 FormWelcome welcome = new FormWelcome();
                 welcome.Show();
                 foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                 {
                     if (!(form is FormWelcome)) // Keep the login form open
                     {
                         form.Close();
                     }
                 }
             }*/
        //private void btnProfile_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Profile(), sender);
        //}
        //}
        private void SideMenuBar_Load(object sender, EventArgs e)
        {
            // Check if user is logged in
            if (Properties.Settings.Default.IsLoggedIn)
            {
                string username = Properties.Settings.Default.Username;
                string email = Properties.Settings.Default.Email;

                // Load user data into UI

                // Set FormDevicesControl as the default form
                OpenChildForm(new Forms.FormDevicesControl(), btnDashboard);
            }
            else
            {
                MessageBox.Show("You are not logged in. Redirecting to Login page.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FormWelcome welcome = new FormWelcome();
                welcome.Show();
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is FormWelcome)) // Keep the login form open
                    {
                        form.Close();
                    }
                }
            }
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormType(), sender);

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideMenuBar_Load_1(object sender, EventArgs e)
        {
            // Check if user is logged in
            if (Properties.Settings.Default.IsLoggedIn)
            {
                string username = Properties.Settings.Default.Username;
                string email = Properties.Settings.Default.Email;

                // Load user data into UI

                // Set FormDevicesControl as the default form
                OpenChildForm(new Forms.FormDevicesControl(), btnDashboard);
            }
            else
            {
                MessageBox.Show("You are not logged in. Redirecting to Login page.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FormWelcome welcome = new FormWelcome();
                welcome.Show();
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is FormWelcome)) // Keep the login form open
                    {
                        form.Close();
                    }
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(), sender);

        }
    }
}
