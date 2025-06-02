public class RectangleCalculator : ICalculator
{
    private const double Pi = 3.14159;

    public double CalculateArea()
    {

        Console.WriteLine("Enter the length:");
        string length = Console.ReadLine() + "";
        Console.WriteLine("Enter the width:");
        string width = Console.ReadLine() + "";

        double area =Double.Parse(length) * double.Parse(width);
            return area;
    }
}