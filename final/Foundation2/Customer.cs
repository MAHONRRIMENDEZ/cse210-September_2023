using System;

class Customer
{
    private string _customerName;
    //private string _streetAddress;
    //Getters and Setters
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    
    
    public void NewAddress(string treetAddress, string City, string state_province, string Country)
    {
        Address address = new Address();
        address.SetStreetAddress(treetAddress);
        address.SetState_province(state_province);
        address.SetCity(City);
        address.SetCountry(Country);
        address.USACountry();
        address.CompleteAddress();
        
    }
    //The customer should have a method that can return whether they live in the USA or not.
    //(Hint this should call a method on the address to find this.)
    


}