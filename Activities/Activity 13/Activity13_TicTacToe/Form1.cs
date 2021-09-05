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

        private void changeGrid(int positionY, int positionX)
        {
            if (isPlayerTurn == true && isGameWon == false && isGameLost == false)
            {
                grid[positionY, positionX] = 1;

                String buttonName = "btn_" + positionY + "_" + positionX;
                this.Controls[buttonName].Text = "X";
                this.Controls[buttonName].Enabled = false;
                isPlayerTurn = false;
                checkGameWon();
                if (isGameWon == false) computerTurn();
            }
            else
            {
                String buttonName = "btn_" + positionY + "_" + positionX;
                if (this.Controls[buttonName].Enabled == false && isGameWon == false && isGameLost == false)
                {
                    if(computerTrys != 100)
                    {
                        computerTrys++;
                        computerTurn();
                    }
                    else
                    {
                        MessageBox.Show("So Close... It's a tie!", "Tie Game!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    grid[positionY, positionX] = 2;
                    this.Controls[buttonName].Text = "O";
                    this.Controls[buttonName].Enabled = false;

                    checkGameWon();
                }
            }
        }

        private void checkGameWon()
        {
            if (grid[0, 0] == 1 && grid[0, 1] == 1 && grid[0, 2] == 1) isGameWon = true;
            if (grid[1, 0] == 1 && grid[1, 1] == 1 && grid[1, 2] == 1) isGameWon = true;
            if (grid[2, 0] == 1 && grid[2, 1] == 1 && grid[2, 2] == 1) isGameWon = true;

            if (grid[0, 0] == 1 && grid[1, 0] == 1 && grid[2, 0] == 1) isGameWon = true;
            if (grid[0, 1] == 1 && grid[1, 1] == 1 && grid[2, 1] == 1) isGameWon = true;
            if (grid[0, 2] == 1 && grid[1, 2] == 1 && grid[2, 2] == 1) isGameWon = true;

            if (grid[0, 0] == 1 && grid[1, 1] == 1 && grid[2, 2] == 1) isGameWon = true;
            if (grid[0, 2] == 1 && grid[1, 1] == 1 && grid[2, 0] == 1) isGameWon = true;


            if (grid[0, 0] == 2 && grid[0, 1] == 2 && grid[0, 2] == 2) isGameLost = true;
            if (grid[1, 0] == 2 && grid[1, 1] == 2 && grid[1, 2] == 2) isGameLost = true;
            if (grid[2, 0] == 2 && grid[2, 1] == 2 && grid[2, 2] == 2) isGameLost = true;

            if (grid[0, 0] == 2 && grid[1, 0] == 2 && grid[2, 0] == 2) isGameLost = true;
            if (grid[0, 1] == 2 && grid[1, 1] == 2 && grid[2, 1] == 2) isGameLost = true;
            if (grid[0, 2] == 2 && grid[1, 2] == 2 && grid[2, 2] == 2) isGameLost = true;

            if (grid[0, 0] == 2 && grid[1, 1] == 2 && grid[2, 2] == 2) isGameLost = true;
            if (grid[0, 2] == 2 && grid[1, 1] == 2 && grid[2, 0] == 2) isGameLost = true;

            if (isGameWon == true)
            {
                MessageBox.Show("You have won the game!", "You Won!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            if (isGameLost == true)
            {
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
