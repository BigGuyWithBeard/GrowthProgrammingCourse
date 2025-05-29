using System;

namespace DiceRoller
{
    public class Dice
    {
        public int Roll(int numSides)
        {
            Random myRand = new Random();
            int myRoll = myRand.Next(1, numSides + 1);
            return myRoll;
        }
    }
}
