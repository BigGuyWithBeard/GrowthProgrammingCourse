using System.Runtime.CompilerServices;

public class Greeter
{
    public string Greet(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return "Hello, World!";
        }
        else
        {
            return $"Hello, {name}!";
        }
    }
}