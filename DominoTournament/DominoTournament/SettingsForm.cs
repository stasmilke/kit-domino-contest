using System;
using System.Windows.Forms;

namespace DominoTournament
{
    public partial class SettingsForm : Form
    {
        private string serverStr;
        private string loginStr;
        private string passwordStr;
        private string nameDBStr;

        public SettingsForm(string server, string login, string password, string name)
        {
            InitializeComponent();

            serverStr = server;
            loginStr = login;
            passwordStr = password;
            nameDBStr = name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            serverStr = serverBox.Text;
            loginStr = loginBox.Text;
            passwordStr = passwordBox.Text;
            nameDBStr = databaseBox.Text;
            this.Close();
        }

        public void GetSettings(out string server, out string login, out string password, out string database)
        {
            server = serverStr;
            login = loginStr;
            password = passwordStr;
            database = nameDBStr;
        }
    }
}
