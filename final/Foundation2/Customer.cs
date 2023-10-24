using System;

class Customer
{
    private string _customerName;
    //private string _streetAddress;
    //Getters and Setters
    private Address _address;

    public Customer (string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    
    
    public void AddAddress()
    {
        _address.CompleteAddress();
        
    }

    //The customer should have a method that can return whether they live in the USA or not.
    //(Hint this should call a method on the address to find this.)
    public bool USACountry()
    {
        return _address.CheckUSACountry(_address.GetCountry());
    }

    public string DisplayShipingLabel()
    {
        Console.WriteLine("");
        Console.WriteLine("Your Shipping Label: ");
        Console.WriteLine($"{_customerName} - {_address.CompleteAddress()}");
        return "";
    }
    


}