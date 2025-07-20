using System;
using System.Windows.Forms;

namespace The_Game_Box
{
    public partial class frmLunchGame2 : Form
    {
        public frmLunchGame2()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            short rounds = (short)nmChooseRounds.Value; 
            frmRockPaperScissors RPS = new frmRockPaperScissors(rounds);
            this.Hide();
            RPS.ShowDialog();
            this.Close();
        }


    }
}