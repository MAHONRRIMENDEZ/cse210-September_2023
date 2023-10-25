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
        return $"Event Title: {GetEventTitle()}. \nDescription: {GetDescription()}. \nDate and Time: {GetDate()} - {GetTime()}, \nAddress: {_address.CompleteAddress()}.";
    }
    
    public string FullDetails()  //this may need to be in the other classes 
    {
        Console.WriteLine("Full and Standard Details:");
        return $"This will be a {GetType()} event. \nOur speaker for this event will be: {_speaker}. \n{StandardDetails()} \nDon't forguet this event have a max capacity of {_eventCapacity} people.";
    }

    /*public string ShortDescription()
    {
        Console.WriteLine("Short Description:");
        return $"This will be a {GetType()} event. \nTitle: {GetEventTitle()}. Date: {GetDate()}.";
    }*/
}