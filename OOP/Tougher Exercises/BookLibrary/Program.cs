using System.Runtime.CompilerServices;

public class Program
{
    static Library library = new Library();

    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Book Library!");
        Console.WriteLine("Initializing library with some books...");
        InitLibrary();


        bool exiting = false;
        while (!exiting)
        {
            Console.WriteLine("\nChoose an option (number or keyword):");
            Console.WriteLine("1. LOAN a book");
            Console.WriteLine("2. RETURN a book");
            Console.WriteLine("3. FIND a book by title");
            Console.WriteLine("4. Manage BOOKS");
            Console.WriteLine("5. Manage USERS");
            Console.WriteLine("x. EXIT");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice.ToLower().Trim())
            {
                case "loan":
                case "1":
                    LoanBook();
                    break;
                case "return":
                case "2":
                    ReturnBook();
                    break;
                case "3":
                case "books":
                    ManageBooks();
                    break;
                case "4":
                case "find":
                    FindBookByTitle();
                    break;
                case "5":
                case "users":
                    ManageUsers();
                    break;
                case "x":
                case "exit":
                    exiting = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }


    }
    private static void InitLibrary()
    {

        // Initialize the library with some books
        library.AddBook(new Book("1984", "George Orwell"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));

        //initialize the library with some users
        library.AddUser(new User("Alice"));
        library.AddUser(new User("Bob"));

    }

    #region Rental Management


    private static void LoanBook()
    {


        Book? book = FindBookByTitle();

        if (book != null)
        {
            if (!book.IsCheckedOut)
            {
                User user = FindUser();

                book.IsCheckedOut = true;
                user.Books.Add(book);
                Console.WriteLine($"You have successfully loaned '{book.Title}' by {book.Author} to {user}.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is already checked out.");
            }
        }
        else
        {
            Console.WriteLine($"No book found.");
        }



    }
    #endregion

    private static void ReturnBook()
    {
        Console.WriteLine("Enter book title to return:");
        string title = Console.ReadLine() ?? string.Empty;

        Book? book = library.FindBookByTitle(title);
        if (book != null)
        {
            if (book.IsCheckedOut)
            {
                book.IsCheckedOut = false;

                //remove the book from the user's list
                var users = library.GetAllUsers();
                foreach (var user in users)
                {
                    if (user.Books.Contains(book))
                    {
                        user.Books.Remove(book);
                        break; // Exit loop after finding the user
                    }
                }
                Console.WriteLine($"You have successfully returned '{book.Title}' by {book.Author}.");
            }
            else
            {
                Console.WriteLine($"'{book.Title}' was not checked out.");
            }
        }
        else
        {
            Console.WriteLine($"No book found with title '{title}'.");
        }
    }
    #region Book Management

    private static void ManageBooks()
    {

        bool exiting = false;
        while (!exiting)
        {

            Console.WriteLine("Manage Books:");
            Console.WriteLine("1. ADD a book");
            Console.WriteLine("2. REMOVE a book");
            Console.WriteLine("3. FIND a book by title");
            Console.WriteLine("4. LIST all books");
            Console.WriteLine("x. EXIT to main menu");


            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice.ToLower().Trim())
            {
                case "1":
                case "add":
                    AddBook();
                    break;
                case "2":
                case "remove":
                    RemoveBook();
                    break;
                case "3":
                case "find":
                    FindBookByTitle();
                    break;
                case "4":
                case "list":
                    ListAllBooks();
                    break;
                case "x":
                case "exit":
                    exiting = true; // Exit to main menu
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
    private static void AddBook()
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter book author:");
        string author = Console.ReadLine() ?? string.Empty;

        library.AddBook(new Book(title, author));
        Console.WriteLine($"Book '{title}' by {author} added to the library.");
    }

    private static void RemoveBook()
    {
        Console.WriteLine("Enter book title to remove:");
        string title = Console.ReadLine() ?? string.Empty;

        library.RemoveBook(title);
        Console.WriteLine($"Book '{title}' removed from the library.");
    }


    private static Book FindBookByTitle()
    {
        Console.WriteLine("Enter book title to find:");
        string title = Console.ReadLine() ?? string.Empty;

        Book? book = library.FindBookByTitle(title);
        if (book != null)
        {
            Console.WriteLine($"Found: {book}");
            return book;
        }
        else
        {
            Console.WriteLine($"No book found with title '{title}'.");
            return null;
        }
    }

    private static void ListAllBooks()


    {
        var books = library.GetAllBooks();
        if (books.Count > 0)
        {
            Console.WriteLine("Books in the library:");
            books.ForEach(book => Console.WriteLine(book));
        }
        else
        {
            Console.WriteLine("No books in the library.");
        }
    }
    #endregion
    #region User Management

    private static void ManageUsers()
    {

        bool exiting = false;
        while (!exiting)
        {
            Console.WriteLine("\nManage Users:");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. ADD a user");
            Console.WriteLine("2. LIST all users");
            Console.WriteLine("3. FIND a user");
            Console.WriteLine("x. EXIT to main menu");
            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice.ToLower().Trim())
            {
                case "1":
                case "add":
                    AddUser();
                    break;
                case "2":
                case "list":
                    ListAllUsers();
                    break;
                case "3":
                case "find":
                    FindUser();
                    break;
                case "x":
                case "exit":
                    exiting = true; // Exit to main menu
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
    private static User FindUser()
    {
        Console.WriteLine("Enter user name to find:");
        string name = Console.ReadLine() ?? string.Empty;

        var users = library.GetAllUsers();
        var user = users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (user != null)
        {
           
            ShowUser(user);
        }
        else
        {
            Console.WriteLine($"No user found with name '{name}'.");
        }
        return user;
    }
    private static void ListAllUsers()
    {
        var users = library.GetAllUsers();
        if (users.Count > 0)
        {
            Console.WriteLine("Users in the library:");
            users.ForEach(user => Console.WriteLine(user));
        }
        else
        {
            Console.WriteLine("No users in the library.");
        }
    }
private static void ShowUser(User user)
    {
        Console.WriteLine($"User: {user.Name}");
        if (user.Books.Count > 0)
        {
            Console.WriteLine("Books loaned:");
            user.Books.ForEach(book => Console.WriteLine($"- {book.Title} by {book.Author}"));
        }
        else
        {
            Console.WriteLine("No books loaned.");
        }
    }
    private static void AddUser()
    {
        Console.WriteLine("Enter user name:");
        string name = Console.ReadLine() ?? string.Empty;

        library.AddUser(new User(name));
        Console.WriteLine($"User '{name}' added to the library.");
    }

    #endregion
}