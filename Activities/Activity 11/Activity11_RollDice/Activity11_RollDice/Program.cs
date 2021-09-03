using System;

namespace Activity11_RollDice
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Dice dice1 = new Dice(12);
            Dice dice2 = new Dice(12);

            playGame(dice1, dice2);

        }

        private static void playGame(Dice dice1, Dice dice2)
        {
            int numRolls = 1;
            bool isSnakeEyes = false;

            while (isSnakeEyes == false)
            {
                int diceFace1, diceFace2;

                diceFace1 = dice1.rollDice(dice1);
                diceFace2 = dice2.rollDice(dice2);

                Console.WriteLine("Roll #" + numRolls + ": " + diceFace1 + ", " + diceFace2);

                if (diceFace1 == 1 && diceFace2 == 1)
                {
                    Console.WriteLine("It took " + numRolls + " rolls to get snake eyes! Phew!");
                    isSnakeEyes = true;
                }


                numRolls++;
            }
        }
    }
}
