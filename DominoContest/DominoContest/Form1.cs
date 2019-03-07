using System;
using System.Windows.Forms;
using System.IO;

namespace DominoContest
{
    public partial class Form1 : Form
    {
        RegistrationForm Reg;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.Cancel)
                return;
            string directory = folderBrowser.SelectedPath;
            pathToDir.Text = directory;
            chooseDir.Visible = false;
            scanDir.Visible = true;
            pathToDir.Visible = true;
            string[] arrayOfFiles = Directory.GetFiles(directory);
            for (int i = 0; i < arrayOfFiles.Length; i++)
                arrayOfFiles[i] = arrayOfFiles[i].Remove(0, directory.Length + 1);
            Reg = new RegistrationForm(arrayOfFiles, directory);
        }

        private void scanDir_Click(object sender, EventArgs e)
        {
            Reg.ShowDialog();
            Close();
        }
    }
}
