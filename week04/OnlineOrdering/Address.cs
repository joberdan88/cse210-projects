public class Address
{
    //variables (street, city, state, country)
    private string street;
    private string city;
    private string state;
    private string country;

    //constructors 
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    //methods (IsInUSA, ToUpper)
    public bool IsInUSA()
    {
        return country.ToUpper() == "USA";
    }

    public override string ToString()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}







