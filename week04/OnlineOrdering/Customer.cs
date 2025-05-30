public class Customer
{
    //variables (name, address)
    private string name;
    private Address address;

    //constructors
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    //methods (LivesInUSA, ToString)
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public override string ToString()
    {
        return $"{name}\n{address}";
    }
}