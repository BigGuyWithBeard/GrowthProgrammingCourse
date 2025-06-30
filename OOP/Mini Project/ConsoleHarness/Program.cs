using Paints.Library;


internal class Program
{

    // delcare a variable to hold our application
    readonly Application app;


    private static void Main(string[] args)
    {

        ShowWelcome();
        // initialise an new instance of the application
        Application app = new Application();

        ShowMenu();

    }

    private static void ShowWelcome()
    {

        Console.WriteLine("Hello, World!");

    }

    private static void ShowMenu() { }

}