using System;

namespace Activity11_RollDice
{
    internal class Dice
    {
        private int diceSides;
        private int faceVal;
        public Dice()
        {
            diceSides = 6;
        }
        public Dice(int sides)
        {
            if (sides >=4 && sides <= 20)
            {
                this.diceSides = sides;
            }
            else
            {
                Console.WriteLine("You cannot implement a dice that has " + sides + " sides! Making a dice with 6 sides...");
                this.diceSides = 6;
            }
            
        }

        public int rollDice(Dice dice)
        {
            Random random = new Random();

            dice.faceVal = random.Next(1, dice.diceSides + 1);

            return dice.faceVal;
        }
    }
}