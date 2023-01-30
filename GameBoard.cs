using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    
    public partial class GameBoard : Form
    {
        int[] x = new int[10];
        int[] y = new int[10];
        playerInfo player1;
        playerInfo player2;
        // Var of movements
        public int Movecount;
        public bool win;
        public int[,] Player1Pos = new int[1,1];
        public int[,] Player2Pos = new int[1,1];
        

        public void BuildBoardpos()
        {
            x[0] = 331;
            y[0] = 543;
            // Fills the row and columns first
            for (int i = 1; i < 10; i++)
            {
               x[i] = x[i - 1] + 56;
            }
            for (int i = 1; i < 10; i++)
            {
                y[i] = y[i - 1] - 54;
            }
            //------------------------------------------------------
            // This code below create 2d array of board index
            
        }
//----------------------------------------------------------

        public bool CheckEvennum(int i)
        {
            // Zoj
            if (i % 2 == 0)
            {
                return true;
            }
            // Fard
            else
            {
                return false;
            }
        }
      
        //------------------------------------------------------
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
        //-----------------------------------------------------------------------------
        public GameBoard(playerInfo player1, playerInfo player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            InitializeComponent();
            lblPlayer1Name.Text = GameLogic.Player1Name;
            BtnDiceRoll.Focus();

            if (GameLogic.AI == true)
            {
                lblPlayer2Name.Text = "AI";
                lblPlayer2turn.Text = "AI turn";
            }
            else
            {
                lblPlayer2Name.Text = GameLogic.Player2Name;
            }
            BuildBoardpos();
        }
        //-------------------------------------------------------------
        private void BtnDiceRoll_Click(object sender, EventArgs e)
        {
            Movecount = Diceroll();
            if(player1.playerTurn == true)
                {
                if (GameLogic.AI == true)
                {
                    boardMove(Movecount, 3);
                }
                else
                {
                    boardMove(Movecount, 1);
                }
                }
            else
               {
                    boardMove(Movecount, 2);
               }

        }
        //-------------------------------------------------------------------
        private int lead(int playerPosition)
        {
            switch (playerPosition)
            {
                case 2:
                    return 38;
                case 7:
                    return 14;
                case 8:
                    return 31;
                case 15:
                    return 26;
                case 28:
                    return 84;
                case 21:
                    return 42;
                case 36:
                    return 44;
                case 51:
                    return 67;
                case 71:
                    return 91;
                case 78:
                    return 88;
                case 87:
                    return 94;
                case 16:
                    return 6;
                case 49:
                    return 11;
                case 46:
                    return 25;
                case 62:
                    return 19;
                case 64:
                    return 60;
                case 74:
                    return 53;
                case 81:
                    return 68;
                case 92:
                    return 88;
                case 95:
                    return 75;
                case 99:
                    return 89;
                default:
                    return playerPosition;
            }

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press roll button to do a dice roll and \nfollow the game rules.");
        }
        //-------------------------------------------------------------------
        private void btnGameQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void boardMove(int moveCount,int turn)
        {
            if(turn == 1)
            {
                for (int i = 0; i < moveCount; i++)
                {
                    if (CheckEvennum(player1.playerPosy))
                    {
                        player1.playerPosx += 1;
                        if (player1.playerPosx == 10)
                        {
                            player1.playerPosy += 1;
                            player1.playerPosx -= 1;
                            if (player1.playerPosy == 10)
                            {
                                MessageBox.Show("Player 1 Won!");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        player1.playerPosx -= 1;
                        if (player1.playerPosx == -1)
                        {
                            player1.playerPosy += 1;
                            player1.playerPosx += 1;
                            if (player1.playerPosy == 10)
                            {
                                MessageBox.Show("Player 1 Won!");
                                this.Close();
                            }
                        }
                    }
                    pictPlayer.Location = new Point(x[player1.playerPosx], y[player1.playerPosy]);
                }
            }
            if (turn == 2)
            {
                for (int i = 0; i < moveCount; i++)
                {
                    if (CheckEvennum(player2.playerPosy))
                    {
                        player2.playerPosx += 1;
                        if (player2.playerPosx == 10)
                        {
                            player2.playerPosy += 1;
                            player2.playerPosx -= 1;
                            if (player2.playerPosy == 10)
                            {
                                MessageBox.Show("Player 1 Won!");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        player2.playerPosx -= 1;
                        if (player2.playerPosx == -1)
                        {   
                            player2.playerPosy += 1;
                            player2.playerPosx += 1;
                            if (player2.playerPosy == 10)
                            {
                                MessageBox.Show("Player 2 Won!");
                                this.Close();
                            }
                        }
                    }
                    pictEnemy.Location = new Point(x[player2.playerPosx], y[player2.playerPosy]);
                }
            }
            if(turn == 3)
            {
                    for (int i = 0; i < moveCount; i++)
                    {
                        if (CheckEvennum(player1.playerPosy))
                        {
                            player1.playerPosx += 1;
                            if (player1.playerPosx == 10)
                            {
                                player1.playerPosy += 1;
                                player1.playerPosx -= 1;
                            if (player1.playerPosy == 10)
                                {
                                    MessageBox.Show("Player 1 Won!");
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            player1.playerPosx -= 1;
                            if (player1.playerPosx == -1)
                            {
                                player1.playerPosy += 1;
                                player1.playerPosx += 1;
                            if (player1.playerPosy == 10)
                                {
                                    MessageBox.Show("Player 1 Won!");
                                    this.Close();
                                }
                            }
                        }
                        pictPlayer.Location = new Point(x[player1.playerPosx], y[player1.playerPosy]);
                    }
                player1.playerTurn = !player1.playerTurn;
                player2.playerTurn = !player2.playerTurn;
                BtnDiceRoll_Click(null, EventArgs.Empty);
            }
            player1.playerTurn = !player1.playerTurn;
            player2.playerTurn = !player2.playerTurn;
        }
    }
}
