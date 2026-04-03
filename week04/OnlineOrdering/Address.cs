// Represents a customer's address
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if address is in USA
    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Return full address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
