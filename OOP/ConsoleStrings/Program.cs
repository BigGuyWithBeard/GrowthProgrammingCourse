using System;

namespace ConsoleStrings
{
    public class ConsoleStringsProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first Name:");
            string firstname = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter last Name:");
            string surname = Console.ReadLine() ?? string.Empty;
            string fullname  = $"{firstname ?? string.Empty} {surname}";
            Console.WriteLine($"Hello {fullname}, how are you today?");
        }
    }
}
