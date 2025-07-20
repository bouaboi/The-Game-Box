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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            frmLunchGame ForTicTacToe = new frmLunchGame();
            this.Hide();
            ForTicTacToe.ShowDialog();
            this.Close();

        }

        private void btnRSP_Click(object sender, EventArgs e)
        {
            frmLunchGame2 ForRockPaperScissors = new frmLunchGame2();
            this.Hide();
            ForRockPaperScissors.ShowDialog();
            this.Close();
        }

        private void btnRandomGame_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int randomgame = random.Next(2, 4);

            if (randomgame == 2)
            {
                btnRSP_Click(sender, e);
            }
            else if (randomgame > 2 || randomgame < 2) 
            {
                btnTicTacToe_Click(sender, e);
            }


        }
    }
}
