public class Store 
{
    private  List<Product> products = new List<Product>();
    private  List<User> users = new List<User>();

    public Store()
    {
        products = new List<Product>();
        users = new List<User>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }


public  List<Product> GetProducts()
    {
        return products;
    }

    public Product? FindProductByName(string name)
    {
        return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
  
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public List<User> GetUsers()
    {
        return users;
    }

    public User? FindUserByName(string name)
    {
        return users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}