using System;

class Address
{
    private string _eventAddress;

    //Constructor.
    
    public Address(string eventAddress)
    {
        _eventAddress = eventAddress;
    }
    public void SetAddress(string eventAddress)
    {
        _eventAddress = eventAddress;
         
    }

    public string GetAddress()
    {
        return _eventAddress;
    }
    public string CompleteAddress()
    {
        
        return $"{_eventAddress}";
    }
}