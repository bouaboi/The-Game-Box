using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Game_Box
{
    public partial class frmLunchGame : Form
    {
        public frmLunchGame()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmTicTacToe game = new frmTicTacToe();
            game.GameMode = frmTicTacToe.enGameMode.PvC;
            this.Hide();
            game.ShowDialog();
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTicTacToe game2 = new frmTicTacToe();
            game2.GameMode = frmTicTacToe.enGameMode.PvP;
            this.Hide();
            game2.ShowDialog();
            this.Close();
        }

       
    }
}
