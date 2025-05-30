public class Order
{
    //variables(list products, customer)
    private List<Product> products;
    private Customer customer;

    //constructors
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    //methods(AddProduct, GetTotalCost, GetPackingLabel, GetShippingLabel)
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = products.Sum(p => p.GetTotalCost());
        double shippingCost = customer.LivesInUSA() ? 5.0 : 35.0;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(p => p.ToString()));
    }

    public string GetShippingLabel()
    {
        return customer.ToString();
    }
}