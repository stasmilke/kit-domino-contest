using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DominoTournament
{
    internal class Tour
    {
        public Participant[] Participants;
        public int[] Points;
        public readonly int NumberOfTour;

        public Tour(int numberOfTour, string folderName)
        {
            NumberOfTour = numberOfTour;
            Participants = GetParticipants(NumberOfTour);
            Points = new int[Participants.Length];
            InitPoints();
        }

        private Participant[] GetParticipants(int numberOfTour)
        {
            Participant[] participants;

            string connStr = "server=" + BeginContest.ServerStr + ";user=" + BeginContest.LoginStr + ";password=" + BeginContest.PasswordStr + ";";
            string nameOfDB = BeginContest.NameDBStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = "USE " + nameOfDB + ";"; ;
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "SELECT COUNT(*) FROM PLAYERS WHERE STAGE IN (" + numberOfTour + ");";
            command = new MySqlCommand(sql, conn);
            int numberOfLines = (int)(long) command.ExecuteScalar();

            sql = "SELECT ID, NAME FROM PLAYERS WHERE STAGE IN (" + numberOfTour + ");";
            command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            participants = new Participant[numberOfLines % 2 == 0 ? numberOfLines : numberOfLines + 1];

            for (int i = 0; i < numberOfLines; i++)
            {
                reader.Read();
                int id = (int) reader.GetInt32(0);
                string nameOfPlayer = (string) reader.GetString(1);
                participants[i] = new Participant(id, nameOfPlayer);
            }

            if (numberOfLines % 2 == 1)
            {
                Random rnd = new Random();
                int randInt = rnd.Next(numberOfLines);
                participants[numberOfLines] = participants[randInt];
            }

            conn.Close();
            return participants;
        }

        private void InitPoints()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = 0;
            }
        }
    }
}
