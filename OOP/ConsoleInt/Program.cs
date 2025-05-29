using System;

namespace ConsoleInt
{
    public class ConsoleInt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;
            Console.WriteLine("Your total was: " + total);
        }
    }
}
