using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Game_Box.Properties;

namespace The_Game_Box
{

    public partial class frmTicTacToe : Form
    {

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.PlayerX;

        public enGameMode GameMode;

        public enum enGameMode { PvP, PvC }

        private int Counter = 2;

        enum enPlayer
        { PlayerX, PlayerO }
        enum enWinner { PlayerX, PlayerO, InProgress, Draw, }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        private bool IsComputerThinking = false;


        public bool CheckValues(Button Button1, Button Button2, Button Button3)
        {
            if (Button1.Tag.ToString() != "?" && Button1.Tag.ToString() == Button2.Tag.ToString()
                && Button1.Tag.ToString() == Button3.Tag.ToString())
            {
                Button1.BackColor = Color.GreenYellow;
                Button2.BackColor = Color.GreenYellow;
                Button3.BackColor = Color.GreenYellow;


                if (Button1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.PlayerX;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.PlayerO;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";

            // PvC Mode
            if (GameMode == enGameMode.PvC)
            {
                switch (GameStatus.Winner)
                {
                    case enWinner.PlayerX:
                        lblWinner.Text = "You";
                        MessageBox.Show("You Win", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case enWinner.PlayerO:
                        lblWinner.Text = "Computer";
                        MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case enWinner.Draw:
                        lblWinner.Text = "Draw";
                        MessageBox.Show("Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                MessageBox.Show("Game is over.\nPlease Re/start a new game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableGameButtons(false);
                return;
            }

            switch (GameStatus.Winner)
            {
                case enWinner.PlayerX:
                    lblWinner.Text = "Player X";
                    MessageBox.Show("Player X Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case enWinner.PlayerO:
                    lblWinner.Text = "Player O";
                    MessageBox.Show("Player O Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case enWinner.Draw:
                    lblWinner.Text = "Draw";
                    MessageBox.Show("Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            MessageBox.Show("Game is over.\nPlease Re/start a new game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnableGameButtons(false);
        }

        public void CheckWinner()
        {
            if (CheckValues(btn1, btn2, btn3))
                return;

            if (CheckValues(btn4, btn5, btn6))
                return;

            if (CheckValues(btn7, btn8, btn9))
                return;

            if (CheckValues(btn1, btn4, btn7))
                return;

            if (CheckValues(btn2, btn5, btn8))
                return;

            if (CheckValues(btn3, btn6, btn9))
                return;

            if (CheckValues(btn1, btn5, btn9))
                return;

            if (CheckValues(btn3, btn5, btn7))
                return;

            if (GameStatus.GameOver)
            {
                timer1.Stop();             
                IsComputerThinking = false;
                lblCountDown.Text = "";
            }
         
        }


        public void ChangeImage(Button Button)
        {
            if (Button.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.PlayerX:
                        Button.Image = Resources.X;
                        PlayerTurn = enPlayer.PlayerO;
                        lblTurn.Text = (GameMode == enGameMode.PvC) ? "Computer" : "Player O";
                        GameStatus.PlayCount++;
                        Button.Tag = "X";
                        CheckWinner();

                        if (GameMode == enGameMode.PvC && PlayerTurn == enPlayer.PlayerO && !GameStatus.GameOver)
                        {
                            IsComputerThinking = true;
                            Counter = 2;
                            timer1.Start();
                        }
                        break;

                    case enPlayer.PlayerO:
                        Button.Image = Resources.O;
                        PlayerTurn = enPlayer.PlayerX;
                        lblTurn.Text = "Player X";
                        GameStatus.PlayCount++;
                        Button.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void ComputerPick()
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            Random rand = new Random();

            int count = 0;
            foreach (Button btn in buttons)
            {
                if (btn.Tag.ToString() == "?")
                    count++;
            }

            if (count > 0)
            {
                int index = rand.Next(count);
                count = 0;
                foreach (Button btn in buttons)
                {
                    if (btn.Tag.ToString() == "?")
                    {
                        if (count == index)
                        {

                            ChangeImage(btn);

                            break;
                        }
                        count++;
                    }
                }
            }
        }

        private void RestButton(Button Button)
        {
            Button.Image = Resources.question_mark;
            Button.Tag = "?";
            Button.BackColor = Color.Transparent;
        }

        private void EnableGameButtons(bool enable)
        {
            btn1.Enabled = enable;
            btn2.Enabled = enable;
            btn3.Enabled = enable;
            btn4.Enabled = enable;
            btn5.Enabled = enable;
            btn6.Enabled = enable;
            btn7.Enabled = enable;
            btn8.Enabled = enable;
            btn9.Enabled = enable;
        }

        private void RestartGame()
        {
            RestButton(btn1);
            RestButton(btn2);
            RestButton(btn3);
            RestButton(btn4);
            RestButton(btn5);
            RestButton(btn6);
            RestButton(btn7);
            RestButton(btn8);
            RestButton(btn9);

            PlayerTurn = enPlayer.PlayerX;
            lblTurn.Text = "Player X"; 
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;
            lblWinner.Text = "No Winner Yet";
            timer1.Stop(); 
            IsComputerThinking = false; 
            lblCountDown.Text = "";
            Counter = 2; 
            EnableGameButtons(true);
        }


        public frmTicTacToe()
        {
            InitializeComponent();
            PlayerTurn = enPlayer.PlayerX; 
            GameStatus = new stGameStatus(); 
            GameStatus.Winner = enWinner.InProgress;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            lblTurn.Text = "Player X"; 
            lblWinner.Text = "No Winner Yet";
            timer1.Stop(); 
            IsComputerThinking = false; 
            Counter = 2; 
            GameMode = enGameMode.PvP;
        }


        private void btn_Click(object sender, EventArgs e)
        {
            if (IsComputerThinking)
                return;


            ChangeImage((Button)sender);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmLunchGame Tic = new frmLunchGame();
            this.Hide();
            Tic.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameStatus.GameOver || GameMode != enGameMode.PvC)
            {
                timer1.Stop();
                IsComputerThinking = false;
                lblCountDown.Text = "";
                return;
            }

            Counter--;
            lblCountDown.Text = "Computer\nis Thinking";

            if (Counter == 0)
            {
                ComputerPick();
                timer1.Stop();
                Counter = 2;
                lblCountDown.Text = "";
                IsComputerThinking = false;
            }
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

