class Shop
{
    private List<Product> Products = new List<Product>();
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public void PrintProductList()
    {
        foreach (var product in Products)
        {
            Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
        }
    }
}