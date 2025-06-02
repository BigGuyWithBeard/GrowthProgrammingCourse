
Console.WriteLine("Enter your name: ");
var name = Console.ReadLine() + "";

var user = new User();
var greeter = new Greeter();

user.SendName(greeter, name);
