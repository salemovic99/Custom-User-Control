using CustomUserControl.UserControls;

namespace CustomUserControl
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            UserControlHome controlHome = new UserControlHome();
            AddUserControl(controlHome);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2ButtonHome_Click(object sender, EventArgs e)
        {
            UserControlHome controlHome = new UserControlHome();
            AddUserControl(controlHome);
        }

        private void guna2ButtonUsers_Click(object sender, EventArgs e)
        {
            UserControlUsers userControl = new UserControlUsers();
            AddUserControl(userControl);
        }

        private void guna2ButtonAbout_Click(object sender, EventArgs e)
        {
            UserControlAbout userControlAbout = new UserControlAbout();
            AddUserControl(userControlAbout);
        }

        private void guna2ButtonSetting_Click(object sender, EventArgs e)
        {
            UserControlSetting controlSetting = new UserControlSetting();
            AddUserControl(controlSetting);
        }
    }
}