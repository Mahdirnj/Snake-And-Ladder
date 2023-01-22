using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    
    public partial class GameBoard : Form
    {
       
       
        public GameBoard()
        {
            InitializeComponent();
            lblPlayer1Name.Text = GameLogic.Player1Name;
            if (GameLogic.AI == true)
            {
                lblPlayer2Name.Text = "AI";
            }
            else
            {
                lblPlayer2Name.Text = GameLogic.Player2Name;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press roll button to do a dice roll and \nfollow the game rules.");
        }
        private void pictPlay_Click(object sender, EventArgs e)
        {
            pictPlay.Hide();
            pnlTable.Show();
            lblPlayer1Name.Show();
            lblPlayer2Name.Show();
            
        }

        private void btnGameQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
