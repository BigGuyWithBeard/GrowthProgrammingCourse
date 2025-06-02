public class User
{
    public void  SendName(Greeter greeter, string name)
    {
        if (greeter == null)
        {
            throw new ArgumentNullException(nameof(greeter), "Greeter cannot be null");
        }
        
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty", nameof(name));
        }

        string greeting = greeter.Greet(name);
        Console.WriteLine(greeting);
   }
}