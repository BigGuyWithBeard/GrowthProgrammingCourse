using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Type 'exit' at any time to quit.");

        bool finished = false;
        do
        {
            Console.WriteLine("Enter a calculation:");
            string input = Console.ReadLine() + "";

            if (input.ToLower() == "exit")
            {
                finished = true;
                continue;
            }

            var parts = input.Split(' ');
            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid input. Please enter in the format: number1 operator number2");
                continue;
            }

            var result = 0.0;

            switch (parts[1])
            {
                case "+":
                    result = Calculator.Add(double.Parse(parts[0]), double.Parse(parts[2]));
                    break;
                case "-":
                    result = Calculator.Subtract(double.Parse(parts[0]), double.Parse(parts[2]));
                    break;
                case "*":
                    result = Calculator.Multiply(double.Parse(parts[0]), double.Parse(parts[2]));
                    break;
                case "/":
                    result = Calculator.Divide(double.Parse(parts[0]), double.Parse(parts[2]));
                    break;
                default:
                    Console.WriteLine("Unknown operator. Please use +, -, *, or /.");
                    break;

            }
             Console.WriteLine($"Result: {result}");
        } while (!finished);
    }
}