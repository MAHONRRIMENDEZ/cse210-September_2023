using System;

class Reception : Event
{
    private string _email;
    private Address _address;

    //Constructor
    public Reception(string email, Address address) 
    {
        
        _email = email;
        _address = address;
    }
    // Getters and Setters

    public void SetEmail(string email)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }
    public string StandardDetails()
    {
        
        Console.WriteLine();
        Console.WriteLine("Standard Details: ");
        return $"Event Title: {GetEventTitle()}. \nDescription: {GetDescription()}. \nDate and Time: {GetDate()} - {GetTime()}, \nAddress: {_address.CompleteAddress()}.";
    }
    public string FullDetails()  //this may need to be in the other classes \n
    {
        Console.WriteLine("Full and Standard Details:");
        return $"This will be a {GetType()} event. \n{StandardDetails()} \nYou can confirm your attendance by sending an email to {_email}";
    }

    /*public string ShortDescription() PENDING 
    {
        Console.WriteLine("Short Description:");
        return $"This will be a {GetType()} event. Title: {GetEventTitle()}. Date: {GetDate()}.";
    }*/
    
}