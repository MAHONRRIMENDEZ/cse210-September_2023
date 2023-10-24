using System;

class Address
{
    private string _eventAddress;

    //Constructor
    public Address(string eventAddress)
    {
        _eventAddress = eventAddress;
    }

    public string GetAddress()
    {
        return _eventAddress;
    }
}