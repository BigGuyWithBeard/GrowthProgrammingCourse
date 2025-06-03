public class Library
{
    private List<Book> books;
    private List<User> users;

    public Library()
    {
        books = new List<Book>();
        users = new List<User>();
    }


    #region User Management
    public void AddUser(User user)
    {
        users.Add(user);
    }

    public List<User> GetAllUsers()
    {
        return new List<User>(users);
    }
    #endregion

    #region Book Management
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(string Title)
    {
        books.RemoveAll(b => b.Title == Title);
    }

    public Book? FindBookByTitle(string Title)
    {
        return books.FirstOrDefault(b => b.Title.Equals(Title, StringComparison.OrdinalIgnoreCase));
    }


    public List<Book> GetAllBooks()
    {
        return new List<Book>(books);
    }
    #endregion
}