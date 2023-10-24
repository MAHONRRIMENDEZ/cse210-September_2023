using System;

class Lecture : Event
{
    private string _speaker;
    private int _eventCapacity;

    private Address _address;
                                                        
    public Lecture(string speaker, int eventCapacity, Address address) 
    {
        
        _speaker = speaker;
        _eventCapacity = eventCapacity;
        _address = address;
    }
    public string StandardDetails()
    {
        
        Console.WriteLine();
        Console.WriteLine("Standard Details: ");
        return $"Event Title: {GetEventTitle()}. Description: {GetDescription()}. Date and Time: {GetDate()} - {GetTime()}, Address: {_address.CompleteAddress()}.";
    }
    
    public string FullDetails()  //this may need to be in the other classes 
    {
        Console.WriteLine("Full and Standard Details:");
        return $" This will be a {GetType()} event. Our speaker for this event will be {_speaker}. {StandardDetails()} Don't forguet this event have a max capacity of {_eventCapacity} people.";
    }

    public string ShortDescription()
    {
        Console.WriteLine("Short Description:");
        return $"This will be a {GetType()} event. Title: {GetEventTitle()}. Date: {GetDate()}.";
    }
}