using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state_province;
    private string _country;

public Address(string streetAddress, string city, string state_province, string country)
{
    _streetAddress = streetAddress;
    _city = city;
    _state_province = state_province;
    _country = country;
}
    //Getters and Setters
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState_province()
    {
        return _state_province;
    }
    public void SetState_province(string state_province)
    {
        _state_province = state_province;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool CheckUSACountry(string country)
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string CompleteAddress()
    {
        //Console.WriteLine("The products will be sent to the following address: ");
        
        
        return $"{_streetAddress}, {_city}, {_state_province}, {_country}";
    }

}