using System;

namespace CurrencyConvertor
{
    public class Program
    {

        const decimal conversionRate = 1.24M;

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount to convert including currency symbol:");
            string input = Console.ReadLine() ?? string.Empty;
            decimal convertedAmount = 0;
            decimal inputAmount = decimal.Parse(input.Substring(1));
            
            if (input.StartsWith('£'))
            {
                convertedAmount = ConvertToDollars.Convert(inputAmount, conversionRate);
                Console.WriteLine($"Converted amount: ${convertedAmount.ToString("F2")}");
            }
            else if (input.StartsWith('$'))
            {
                convertedAmount = ConvertToPounds.Convert(inputAmount, conversionRate);
                Console.WriteLine($"Converted amount: £{convertedAmount.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Unsupported currency format. Please use £ or $.");
            }

        }
    }
}
