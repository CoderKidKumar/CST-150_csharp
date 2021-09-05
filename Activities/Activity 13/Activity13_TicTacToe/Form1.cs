using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13_TicTacToe
{
    public partial class Form1 : Form
    {
        //set up variables to create the game (grid, position of the grid, and bool for player's turn and if the game is won or lost)
        int[,] grid = { {0,0,0},
                        {0,0,0},
                        {0,0,0}};
        int positionX;
        int positionY;

        bool isPlayerTurn = true;
        bool isGameWon = false;
        bool isGameLost = false;
        //Random var for computer's turn
        Random computerPosition = new Random();

        //count for computer's tries - helps to prevent stack overflow
        int computerTrys = 0;

        // --------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        private bool checkPlayerTurn()
        { // checks whos turn it is
            if (isPlayerTurn == true)
                return true;
            else
                return false;
        }
        //this method changes the grid based on whos turn it is
        private void changeGrid(int positionY, int positionX)
        {   //if it is the players turn and there is no won or lose bool
            if (isPlayerTurn == true && isGameWon == false && isGameLost == false)
            {   //put the value of the player on the grid
                grid[positionY, positionX] = 1;
                // find the button in that same position and put an X and disable the button
                String buttonName = "btn_" + positionY + "_" + positionX;
                this.Controls[buttonName].Text = "X";
                this.Controls[buttonName].Enabled = false;
                //change the turn to the computer and check first if the payer has won
                isPlayerTurn = false;
                checkGameWon();
                //if there the player is not a winner, move to the computer's turn
                if (isGameWon == false) computerTurn();
            }
            else
            { // this is for the computer's turn - find the button and make sure that is enabled [and that the game is still running]
                String buttonName = "btn_" + positionY + "_" + positionX;
                if (this.Controls[buttonName].Enabled == false && isGameWon == false && isGameLost == false)
                { // if the button is disabled or the game is won/lost - have the computer try again
                    if(computerTrys != 100)
                    { // this is here to limit from a stackoverflow exception
                        computerTrys++;
                        computerTurn();
                    }
                    else
                    { // if the computer has tried 100 times in a row and find nothing that means that the grid is full and the game is a tie
                        MessageBox.Show("So Close... It's a tie!", "Tie Game!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                
                //if the computer finds an open spot - put its mark on the grid with an O - then check if the game is won
                    grid[positionY, positionX] = 2;
                    this.Controls[buttonName].Text = "O";
                    this.Controls[buttonName].Enabled = false;

                    checkGameWon();
                }
            }
        }

        private void checkGameWon()
        { // check all the posibilities of a person winning across, up/down, and cross
            if (grid[0, 0] == 1 && grid[0, 1] == 1 && grid[0, 2] == 1) isGameWon = true;
            if (grid[1, 0] == 1 && grid[1, 1] == 1 && grid[1, 2] == 1) isGameWon = true;
            if (grid[2, 0] == 1 && grid[2, 1] == 1 && grid[2, 2] == 1) isGameWon = true;

            if (grid[0, 0] == 1 && grid[1, 0] == 1 && grid[2, 0] == 1) isGameWon = true;
            if (grid[0, 1] == 1 && grid[1, 1] == 1 && grid[2, 1] == 1) isGameWon = true;
            if (grid[0, 2] == 1 && grid[1, 2] == 1 && grid[2, 2] == 1) isGameWon = true;

            if (grid[0, 0] == 1 && grid[1, 1] == 1 && grid[2, 2] == 1) isGameWon = true;
            if (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 1) isGameWon = true;

          // check all the posibilities of the computer winning across, up/down, and cross
            if (grid[0, 0] == 2 && grid[0, 1] == 2 && grid[0, 2] == 2) isGameLost = true;
            if (grid[1, 0] == 2 && grid[1, 1] == 2 && grid[1, 2] == 2) isGameLost = true;
            if (grid[2, 0] == 2 && grid[2, 1] == 2 && grid[2, 2] == 2) isGameLost = true;

            if (grid[0, 0] == 2 && grid[1, 0] == 2 && grid[2, 0] == 2) isGameLost = true;
            if (grid[0, 1] == 2 && grid[1, 1] == 2 && grid[2, 1] == 2) isGameLost = true;
            if (grid[0, 2] == 2 && grid[1, 2] == 2 && grid[2, 2] == 2) isGameLost = true;

            if (grid[0, 0] == 2 && grid[1, 1] == 2 && grid[2, 2] == 2) isGameLost = true;
            if (grid[0, 2] == 2 && grid[1, 1] == 2 && grid[2, 0] == 2) isGameLost = true;

            if (isGameWon == true)
            { // if the player has won, end the game with messagebox
                MessageBox.Show("You have won the game!", "You Won!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            if (isGameLost == true)
            { // if the computer won and the player lost, end the game with messagebox
                MessageBox.Show("Computer Won! \n You have lost the game!", "You Lost!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void computerTurn()
        {
            positionY = computerPosition.Next(3);
            positionX = computerPosition.Next(3);

            changeGrid(positionY, positionX);
            isPlayerTurn = true;
        }
//the functions for when a player clicks a button - check if it is the player's turn and give chnageGrid method the position varaibles
        private void btn_1_1_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 1;
                positionX = 1;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_0_0_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 0;
                positionX = 0;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_0_1_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 0;
                positionX = 1;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_0_2_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 0;
                positionX = 2;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_1_0_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 1;
                positionX = 0;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_1_2_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 1;
                positionX = 2;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_2_0_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 2;
                positionX = 0;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_2_1_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 2;
                positionX = 1;

                changeGrid(positionY, positionX);
            }
        }

        private void btn_2_2_Click(object sender, EventArgs e)
        {
            if (checkPlayerTurn() == true)
            {
                positionY = 2;
                positionX = 2;

                changeGrid(positionY, positionX);
            }
        }
//for the menu on top - new game restart the application exit will exit the application
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
