public class Product
{
    //variables (name, productID, price, quantity)
    private string name;
    private string productID;
    private double price;
    private int quantity;

    //constructors
    public Product(string name, string productID, double price, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }

    //methods(GetTotalCost, ToString)
    public double GetTotalCost()
    {
        return price * quantity;
    }

    public override string ToString()
    {
        return $"{name} (ID:{productID}) - ${price} X {quantity} = ${GetTotalCost()}";
    }
}