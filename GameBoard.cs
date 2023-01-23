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
        // Var of movements
        public int Movecount , CurrentPosition;
        int X1, Y1 , X2 , Y2;


        public int PositionMove(int Move)
        {
            X1 = pictPlayer.Location.X;
            Y1 = pictPlayer.Location.Y;
            X2 = pictEnemy.Location.X;
            Y2 = pictEnemy.Location.Y;
            if (GameLogic.Player1turn == true)
            {

                GameLogic.Player1turn = false;
            }
            else
            {
                GameLogic.Player1turn = true;
            }
            return 0;
        }

        // Void for a dice logic
        public int Diceroll()
        {
            Random Dice = new Random();
            int dice = Dice.Next(1 , 7);
            switch (dice)
            {
                case 1:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 1.jpg");
                    Movecount = 1;
                    break;
                case 2:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 2.jpg");
                    Movecount = 2;
                    break;
                case 3:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 3.jpg");
                    Movecount = 3;
                    break;
                case 4:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 4.jpg");
                    Movecount = 4;
                    break;
                case 5:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 5.jpg");
                    Movecount = 5;
                    break;
                case 6:
                    pictDice.Image = Image.FromFile("C:/Visual Studio Projects/Snake and Ladder/Snake And Ladder/Resources/Images/dice 6.jpg");
                    Movecount = 6;
                    break;
            }
            return Movecount;
        }
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

        private void BtnDiceRoll_Click(object sender, EventArgs e)
        {
            if (GameLogic.AI == true)
            {
                Movecount = Diceroll();
            }
            else
            {
                Diceroll();
            }

        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press roll button to do a dice roll and \nfollow the game rules.");
        }
        private void btnGameQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
