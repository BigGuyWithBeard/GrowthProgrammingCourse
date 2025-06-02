Console.WriteLine("Welcome to the Area Calculator!");

bool isExiting = false;
do
{
    
Console.WriteLine("Pick a shape to calculate the area:");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Rectangle");
Console.WriteLine("3. Triangle");
Console.WriteLine("Type 'exit' to quit.");
var shape = Console.ReadLine();
ICalculator? calculator = null;

switch (shape)
{
    case "1":
        calculator = new CircleCalculator();

        break;

    case "2":
        calculator = new RectangleCalculator();
        break;

    case "3":
        calculator = new TriangleCalculator();
        break;
case "exit":
        Console.WriteLine("Exiting the program. Goodbye!");
        return;
    default:
        Console.WriteLine("Unknown shape. Please select 1, 2, or 3.");
        break;
}

if (calculator != null)
{
    Console.WriteLine($"The area is: {calculator.CalculateArea()}");
}

 } while (!isExiting);

