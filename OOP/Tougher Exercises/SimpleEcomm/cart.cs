public class Cart
{

    //a cart is a list of tuples of products and their quantities
    public List<Tuple<Product, int>> Products { get; private set; } = new List<Tuple<Product, int>>();
    public decimal TotalValue
    {
        get
        {
            decimal total = 0;
            foreach (var item in Products)
            {
                total += item.Item1.Price * item.Item2;
            }
            return total;
        }
    }
    public void Add(Product product, int quantity = 1)
    {
        var existingItem = Products.FirstOrDefault(p => p.Item1.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));
        if (existingItem != null)
        {
            // If the product already exists in the cart, increase the quantity
            int newQuantity = existingItem.Item2 + quantity;
            Products.Remove(existingItem);
            Products.Add(new Tuple<Product, int>(product, newQuantity));
        }
        else
        {
            // If the product does not exist in the cart, add it
            Products.Add(new Tuple<Product, int>(product, quantity));
        }
    }
}