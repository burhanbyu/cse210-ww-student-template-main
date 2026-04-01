using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country = "USA")
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Returns the full address as a string with newlines
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    // Checks if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
}