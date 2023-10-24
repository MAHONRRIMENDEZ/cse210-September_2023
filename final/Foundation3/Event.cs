using System;

class Event
{
    private string _type;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    
    //private Address _address;
    //address is in the Address class.
    
        //Constructors
    public Event() //no arguments 
    {
        
    }
    public Event(string type, string eventTitle, string description, string date, string time)
    {
        _type = type;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        
    }
    

    //Getters and Setters
    public void SetType(string type)
    {
        _type = type;
    }
    public string GetType()
    {
        return _type;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetTime()
    {
        return _time;
    }
    

    

    public string ShortDescription()
    {
        Console.WriteLine("Short Description:");
        return $"This will be a {GetType()} event. Title: {GetEventTitle()}. Date: {GetDate()}." ;
        
    }
}