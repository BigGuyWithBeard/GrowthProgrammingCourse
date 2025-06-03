public class User
{  
    public string Name { get; set; }
    public bool IsManager { get; set; } = false;
    public Cart Cart { get; private set; } = new Cart();

    public User(string name, bool isManager = false)
    {
        Name = name;
        IsManager = isManager;
    }

    public override string ToString()
    {
        return $"{Name})";
    }
}