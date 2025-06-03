public class User
{
    public string Name { get; set; }


    public User(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}";
    }

    public List<Book>Books { get; set; } = new List<Book>();
}