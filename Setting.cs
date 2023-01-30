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
   
    
    public partial class Setting : Form
    {
        playerInfo player1;
        playerInfo player2;
        public Setting()
        {
            InitializeComponent();
            player1 = new playerInfo();
            player2 = new playerInfo();
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void chkAI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAI.Checked)
            {
                txtPlayer2.Hide();
                lblPlayer2.Hide();
                GameLogic.AI = true;
            }
            else
            {
                txtPlayer2.Show();
                lblPlayer2.Show();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Getting text box info and save it
            GameLogic.Player1Name = txtPlayer1.Text;
            
            if (chkAI.Checked)
            {
                GameLogic.AI = true;
            }
            // Conditions below
            if (txtPlayer1.Text == "" )
            {
                MessageBox.Show("Name needed! ");
            }
            else if (txtPlayer2.Text == "" && GameLogic.AI == false)
            {
                GameLogic.AI = true;
            }
            else
            {
                GameLogic.Player2Name = txtPlayer2.Text;
                player1.playerTurn = true;
                GameBoard f1 = new GameBoard(player1, player2);
                this.Hide();
                f1.Show();
            }
            
        }
    }
}
