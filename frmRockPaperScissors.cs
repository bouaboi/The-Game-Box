using System;
using System.Drawing;
using System.Windows.Forms;
using static The_Game_Box.frmRockPaperScissors;

namespace The_Game_Box
{
    public partial class frmRockPaperScissors : Form
    {
        public enum enGameChoice { Rock, Paper, Scissors }
        public enum enWinner { Player1, Computer, Draw }


        stRoundInfo RoundInfo;
        stGameResults GameResults;


        struct stRoundInfo
        {
            public byte RoundNumber;
            public enGameChoice Player1;
            public enGameChoice Computer;
            public enWinner Winner;
            public bool Player1Played;
            public bool ComputerPlayed;
        }

        public struct stGameResults
        {
            public short GameRound;
            public short Player1WinTimes;
            public short Computer2WinTimes;
            public short DrawTimes;
            public enWinner GameWinner;
            public string WinnerName;
        };

        private short _rounds;
        private short _currentRound;

        public frmRockPaperScissors()
        { }

        public frmRockPaperScissors(short rounds)
        {
            InitializeComponent();
            InitButtons();
            ResetGame();
            _rounds = rounds;
            _currentRound = 1;
        }

        private void InitButtons()
        {
            button1.Tag = "Rock";
            button1.Click += btnChoice_Click;

            button4.Tag = "Paper";
            button4.Click += btnChoice_Click;

            button3.Tag = "Scissors";
            button3.Click += btnChoice_Click;


            button2.Tag = null;
            btn2.Tag = null;
        }

        private void ResetGame()
        {
            RoundInfo = new stRoundInfo
            {
                RoundNumber = (byte)_currentRound,
                Player1Played = false,
                ComputerPlayed = false
            };

            lblResult.Text = "";
            button2.Image = Properties.Resources.QSM;
            btn2.Image = Properties.Resources.QSM;
        }

        private string WinnerName(frmRockPaperScissors.enWinner winner)
        {
            string[] names = { "Player1", "Computer", "Draw" };
            return names[(int)winner];
        }




        enWinner TheWinner()
        {
            if (RoundInfo.Player1 == RoundInfo.Computer)
                return enWinner.Draw;

            switch (RoundInfo.Player1)
            {
                case enGameChoice.Rock:
                    return (RoundInfo.Computer == enGameChoice.Paper) ? enWinner.Computer : enWinner.Player1;

                case enGameChoice.Paper:
                    return (RoundInfo.Computer == enGameChoice.Scissors) ? enWinner.Computer : enWinner.Player1;

                case enGameChoice.Scissors:
                    return (RoundInfo.Computer == enGameChoice.Rock) ? enWinner.Computer : enWinner.Player1;
            }

            return enWinner.Draw;
        }

        private Image GetChoiceImage(enGameChoice choice)
        {
            switch (choice)
            {
                case enGameChoice.Rock:
                    return Properties.Resources.rock1;
                case enGameChoice.Paper:
                    return Properties.Resources.paper1;
                case enGameChoice.Scissors:
                    return Properties.Resources.Scissors3;
                default:
                    return Properties.Resources.QSM;
            }
        }

        private void ShowResult(enWinner Winner)
        {
            switch (Winner)
            {
                case enWinner.Player1:
                    GameResults.Player1WinTimes++;
                    MessageBox.Show("Congrats\n \nYou Win", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case enWinner.Computer:
                    GameResults.Computer2WinTimes++;
                    MessageBox.Show("You Lose\n \nBest Luck Next Time", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case enWinner.Draw:
                    lblResult.Text = "Draw!";
                    GameResults.DrawTimes++;
                    MessageBox.Show("Draw", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            GameResults.GameRound = _currentRound;


            if (_currentRound >= _rounds)
            {
                if (GameResults.Player1WinTimes > GameResults.Computer2WinTimes)
                    GameResults.GameWinner = enWinner.Player1;
                else if (GameResults.Computer2WinTimes > GameResults.Player1WinTimes)
                    GameResults.GameWinner = enWinner.Computer;
                else
                    GameResults.GameWinner = enWinner.Draw;
                    GameResults.WinnerName = WinnerName(GameResults.GameWinner);

                this.Hide();
                frmGameResults resultsForm = new frmGameResults(GameResults);
                resultsForm.ShowDialog();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Next round starting", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _currentRound++;
                ResetGame();
            }

        }

        private void UpdateGameState(Button btn)
        {
            if (btn.Tag == null)
                return;

            enGameChoice playerChoice = (enGameChoice)Enum.Parse(typeof(enGameChoice), btn.Tag.ToString());

            RoundInfo.Player1 = playerChoice;
            RoundInfo.Player1Played = true;
            button2.Image = GetChoiceImage(playerChoice);

            Random rnd = new Random();
            enGameChoice computerChoice = (enGameChoice)rnd.Next(0, 3);

            RoundInfo.Computer = computerChoice;
            RoundInfo.ComputerPlayed = true;
            btn2.Image = GetChoiceImage(computerChoice);

            RoundInfo.Winner = TheWinner();
            ShowResult(RoundInfo.Winner);
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            UpdateGameState((Button)sender);
        }
        
    }
    
}