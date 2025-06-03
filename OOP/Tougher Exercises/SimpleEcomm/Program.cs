using System.Reflection.Metadata;

internal class Program
{

    private static void Main(string[] args)
    {
        Store store = new Store();
        User? user;

        ShowBanner();

        InitialiseStore(store);

        user = LoginUser(store);

ShowWelcomeMessage(user);

        ShowMenu(store, user);


    }

    private static void InitialiseStore(Store store)
    {
        Console.Write("Initialising Store...");
        InitialiseProducts(store);
        InitialiseUsers(store);
        Console.WriteLine(" Completed.");
    }

    private static void ShowBanner()
    {
        // lets go old school with some ascii art...

        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow," _   ___    _ _____ _   __      _____      ___  ___  ___  ______ _____ ");
        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow,"| | / / |  | |_   _| | / /     |  ___|     |  \\/  | / _ \\ | ___ \\_   _|");
        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow,"| |/ /| |  | | | | | |/ /______| |__ ______| .  . |/ /_\\ \\| |_/ / | |  ");
        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow,"|    \\| |/\\| | | | |    \\______|  __|______| |\\/| ||  _  ||    /  | |  ");
        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow,"| |\\  \\  /\\  /_| |_| |\\  \\     | |___      | |  | || | | || |\\ \\  | |  ");
        ConsoleEx.WriteLineBold(ConsoleColor.DarkYellow,"\\_| \\_/\\/  \\/ \\___/\\_| \\_/     \\____/      \\_|  |_/\\_| |_/\\_| \\_| \\_/  ");
        ConsoleEx.WriteLine("");
        ConsoleEx.WriteLineBold("Welcome to Kwik-E-Mart Online");
        ConsoleEx.WriteLineBold("=======================================================================");
    }
    private static void ShowProducts(Store store)
    {
        foreach (var product in store.GetProducts())
        {
            Console.WriteLine(product);
        }

    }

private static void ShowWelcomeMessage(User user)
    {
        ConsoleEx.WriteLineBold($"Welcome {user.Name}!");
        if (user.IsManager)
        {
            ConsoleEx.WriteLine(ConsoleColor.DarkRed, "You are logged in as a manager.");
        }

    }
    private static void ShowMenu(Store store, User user)
    {

        bool exiting = false;
        while (exiting == false)
        {

            Console.WriteLine("Please select an option:");
            Console.WriteLine("* View CART");
            Console.WriteLine("* ADD item to cart");
            //     Console.WriteLine("3. FIND Product by Name");

            if (user.IsManager)
            {
                Console.WriteLine("* View USERS");
                Console.WriteLine("* CREATE Product");
            }

            Console.WriteLine("* EXIT");

            string input = Console.ReadLine() + "";
            switch (input.ToLower().Trim())
            {

                case "cart":
                    ShowCart(user.Cart);
                    break;
                case "add":
                    AddProductToCart(store, user);
                    break;
                //      case "users":
                //          Console.WriteLine("Users:");
                //          break;

                //     case "find":
                //         Console.Write("Enter product name: ");
                //         break;

                case "x":
                case "exit":
                    exiting = true;
                    continue;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    continue;
            }

        }
    }

    private static void AddProductToCart(Store store, User user)
    {
        // pick a product:


        Console.WriteLine("Please select a product to add to your cart:");
        ShowProducts(store);
        string input = Console.ReadLine() + "";
        Product? product = store.FindProductByName(input);

        if (product == null)
        {
            Console.WriteLine("Product not found, please try again.");
            return;
        }
        else
        {
            int quantity = 1;
            user.Cart.Add(product, quantity);
        }
    }

    private static User LoginUser(Store store)
    {
        User? user = null;
        bool exiting = false;

        //pick a user (ie Login)
        while (exiting == false)
        {
            ConsoleEx.WriteLineBold("Please Login:");
            ConsoleEx.WriteLine(ConsoleColor.DarkGreen, "[hint: 'Apu' is a manager, 'Homer' is not]:");
            string input = Console.ReadLine() + "";
            user = store.FindUserByName(input);
            if (user == null)
            {
                Console.WriteLine("User not found, please try again.");
                continue;
            }
            exiting = true;
        }
        return user;
    }
    private static void InitialiseProducts(Store store)
    {
        store.AddProduct(new Product("Duff", 9.99m));
        store.AddProduct(new Product("Malk", 0.99m));
        store.AddProduct(new Product("Laramie Cigarettes", 18.99m));
        store.AddProduct(new Product("Krusty Burger", 2.99m));
    }
    private static void InitialiseUsers(Store store)
    {
        store.AddUser(new User("Homer", false));
        store.AddUser(new User("Ned", false));
        store.AddUser(new User("Apu", true));
        store.AddUser(new User("Moe", false));
        store.AddUser(new User("Barney", false));
    }

    private static void ShowCart(Cart cart)
    {
        if (cart.Products.Count == 0)
        {
            Console.WriteLine("Your cart is empty.");
            return;
        }

        Console.WriteLine("Your Cart:");
        foreach (var product in cart.Products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine($"Total: £{cart.TotalValue}");
    }
}