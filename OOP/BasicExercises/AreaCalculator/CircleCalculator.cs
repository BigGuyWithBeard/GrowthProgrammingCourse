public class CircleCalculator : ICalculator
{
    private const double Pi = 3.14159;

    public double CalculateArea()
    {
        Console.WriteLine("Enter the radius of the circle:");
        string input = Console.ReadLine() + "";

        if (double.TryParse(input, out double radius) && radius > 0)
        {
            double area = Pi * radius * radius;
            return area;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number for the radius.");
            return 0.0;
        }
    }
}