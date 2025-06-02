public class TriangleCalculator : ICalculator
{
    private const double Pi = 3.14159;

    public double CalculateArea()
    {

        Console.WriteLine("Enter the base length:");
        string baseLength = Console.ReadLine() + "";
        Console.WriteLine("Enter the height:");
        string height = Console.ReadLine() + "";

        double area = 0.5 * double.Parse(baseLength) * double.Parse(height);
        return area;

    }
}