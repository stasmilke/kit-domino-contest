using System;
using System.Windows.Forms;

namespace DominoContest
{
    public partial class SettingsForm : Form
    {
        private string ServerStr = "localhost";
        private string LoginStr = "root";
        private string PasswordStr = "1234";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ServerStr = serverBox.Text;
            LoginStr = loginBox.Text;
            PasswordStr = passwordBox.Text;
        }

        public void GetSettings(out string server, out string login, out string password)
        {
            server = ServerStr;
            login = LoginStr;
            password = PasswordStr;
        }
    }
}
