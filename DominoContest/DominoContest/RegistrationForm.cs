using System;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace DominoContest
{
    public partial class RegistrationForm : Form
    {
        private string Path;
        private string[] ArrayOfFiles;

        private string ServerStr = "localhost";
        private string LoginStr = "root";
        private string PasswordStr = "1234";

        public RegistrationForm(string[] arrayOfFiles, string path)
        {
            InitializeComponent();

            listOfSources.Items.AddRange(arrayOfFiles);
            this.Path = path;
            this.ArrayOfFiles = arrayOfFiles;
        }

        private void createDatabase_Click(object sender, EventArgs e)
        {
            string connStr = "server=" + ServerStr + ";user=" + LoginStr + ";password=" + PasswordStr + ";";
            string name = "participants";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            if (nameTextBox.Text != "")
            {
                name = nameTextBox.Text;
            }
            string sql = "CREATE DATABASE IF NOT EXISTS " + name + ";";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            sql = "USE " + name + ";";
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            sql = "CREATE TABLE IF NOT EXISTS Players ( Id INT, Name VARCHAR(50), File VARCHAR(150), Stage INT DEFAULT 1, PRIMARY KEY(Id) );";
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            for (int i = 0; i < ArrayOfFiles.Length; i++)
            {
                string namePlayer = ArrayOfFiles[i].TrimEnd(".cs".ToCharArray());
                sql = "INSERT Players(Id, Name, File) VALUES (" + i + ", '" + namePlayer + "', '" + ArrayOfFiles[i] + "');";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("База данных создана.");
            this.Close();
        }

        private void clrDB_Click(object sender, EventArgs e)
        {
            string connStr = "server=" + ServerStr + ";user=" + LoginStr + ";password=" + PasswordStr + ";";
            string name = "participants";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            if (nameTextBox.Text != "")
            {
                name = nameTextBox.Text;
            }
            MessageBox.Show("Будет стерта база данных \""+ name + "\" по адресу \"" + ServerStr + "\".");
            string sql = "DROP DATABASE IF EXISTS " + name + ";";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("База данных стерта.");
        }

        private void clrON_CheckedChanged(object sender, EventArgs e)
        {
            if (clrON.Checked)
            {
                clrON.Text = "";
                clrDB.Visible = true;
                MessageBox.Show("Внимание! Кнопка \"Стереть\" стирает имеющуюся базу данных с введенным названием! Будьте внимательны.");
            }
            else
            {
                clrON.Text = "Стереть базу";
                clrDB.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
            form.GetSettings(out ServerStr, out LoginStr, out PasswordStr);
        }
    }
}
