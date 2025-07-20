using System;
using System.Windows.Forms;
using static The_Game_Box.frmRockPaperScissors;

namespace The_Game_Box
{
    public partial class frmGameResults : Form
    {
        private frmRockPaperScissors.stGameResults _gameResults;

        public frmGameResults(frmRockPaperScissors.stGameResults gameResults)
        {
            InitializeComponent();
            _gameResults = gameResults;
            DisplayResults();
            
        }

        

        private void DisplayResults()
        {
      
            lblRounds.Text = "Total Rounds: " + _gameResults.GameRound;
            lblPlayerWins.Text = "Player 1 Wins: " + _gameResults.Player1WinTimes;
            lblComputerWins.Text = "Computer 1 Wins: " + _gameResults.Computer2WinTimes;
            lblDraws.Text = "Draws: " + _gameResults.DrawTimes;
            lblWinner.Text = "Overall Winner: " +_gameResults.GameWinner;


        }

        private void btnlNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLunchGame2 newLunch = new frmLunchGame2();
            newLunch.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain Back = new frmMain();
            Back.ShowDialog();
            this.Close();
        }
    }
}