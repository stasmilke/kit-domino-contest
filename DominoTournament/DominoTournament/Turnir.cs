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
    public partial class Turnir : Form
    {
        private readonly string FolderPath;
        private readonly int NumberOfGames;
        private Tour CurrentTour;

        public Turnir(string folder, int numberOfGames)
        {
            InitializeComponent();

            FolderPath = folder;
            NumberOfGames = numberOfGames;
            CurrentTour = new Tour(1, FolderPath);
            numberOfTourLbl.Text = String.Format("{0} тур", CurrentTour.NumberOfTour);
            ShowTourTable();
        }

        private void ShowTourTable()
        {
            panelOfAll.Controls.Clear();
            for (int i = 0; i < CurrentTour.Participants.Length; i += 2)
            {
                VersusPanel battle = new VersusPanel(i, CurrentTour);
                panelOfAll.Controls.Add(battle);
            }
        }

        private class VersusPanel : TableLayoutPanel
        {
            Label FirstPlayer;
            Label SecondPlayer;
            Label FirstScore;
            Label SecondScore;

            public VersusPanel(int from, Tour currentTour)
            {
                FirstPlayer = InitLabel(currentTour.Participants[from].Name, false);
                SecondPlayer = InitLabel(currentTour.Participants[from+1].Name, true);
                FirstScore = InitLabel(currentTour.Points[from], false);
                SecondScore = InitLabel(currentTour.Points[from + 1], true);
                SetCellPosition(FirstPlayer, new TableLayoutPanelCellPosition(0, 0));
                ColumnCount = 2;
                RowCount = 2;
                Size = new Size(214, 68);               
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;               
            }

            private Label InitLabel(int points, bool isSecond)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI Semibold", 16.2f, FontStyle.Regular);
                label.Text = points.ToString();
                label.Size = new Size(50, 32);                
                Controls.Add(label);
                SetCellPosition(label, new TableLayoutPanelCellPosition(1, isSecond ? 1 : 0));
                return label;
            }

            private Label InitLabel(string name, bool isSecond)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = name;
                label.Size = new Size(152, 32);
                Controls.Add(label);
                SetCellPosition(label, new TableLayoutPanelCellPosition(0, isSecond ? 1 : 0));
                return label;
            }
        }

        private void startTourBtn_Click(object sender, EventArgs e)
        {
            nextTourBtn.Enabled = true;
            startTourBtn.Enabled = false;
            new GamingClass(2, NumberOfGames, FolderPath, CurrentTour);
            ShowTourTable();
        }
    }

    
}
