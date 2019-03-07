using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominoTournament
{
    public partial class BeginContest : Form
    {
        public static string FolderPath;
        public static string ServerStr = "localhost";
        public static string LoginStr = "root";
        public static string PasswordStr = "1234";
        public static string NameDBStr = "participants";
        private int NumberOfGames = 10;

        public BeginContest()
        {
            InitializeComponent();
            textBoxPath.Text = "";
        }

        public BeginContest(string folderPath)
        {
            InitializeComponent();
            FolderPath = folderPath;
            textBoxPath.Text = folderPath;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            textBoxPath.Text = folderBrowser.SelectedPath;
            FolderPath = textBoxPath.Text;
        }

        private void btnSetDB_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(ServerStr, LoginStr, PasswordStr, NameDBStr);
            settings.ShowDialog();
            settings.GetSettings(out ServerStr, out LoginStr, out PasswordStr, out NameDBStr);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = "Итого " + numericUpDown1.Value * 2 + " партий с переходом права первого хода";
            NumberOfGames = (int) numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FolderPath != null)
            {
                Turnir turnirWindow = new Turnir(FolderPath, NumberOfGames);
                turnirWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не указан путь к папке с решениями.");
            }
        }
    }
}
