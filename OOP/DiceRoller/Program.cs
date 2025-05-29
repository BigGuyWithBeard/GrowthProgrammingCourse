using System;

namespace DiceRoller
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Enter the number of sides on the dice:");
            int myNum=Int32.Parse(Console.ReadLine());

            Dice myDice = new Dice();
            Console.WriteLine($"You rolled a {myDice.Roll(myNum)}");
        }
    }
}
