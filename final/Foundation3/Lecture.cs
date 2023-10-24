using System;

class Lecture : Event
{
    private string _speaker;
    private int _eventCapacity;
                                                        
    public Lecture(string speaker, int eventCapacity) : base()
    {
        
        _speaker = speaker;
        _eventCapacity = eventCapacity;
    }
    
    public string FullDetails()  //this may need to be in the other classes 
    {
        Console.WriteLine("Full Details:");
        return $" This will be a {GetType()} event. Our speaker for this event will be {_speaker}. {StandardDetails()}. Don't forguet this event have a max capacity of {_eventCapacity} people";
    }

    public string ShortDescription()
    {
        Console.WriteLine("Short Description:");
        return $"This will be a {GetType()} event. {GetEventTitle()}. {GetDate()}";
    }
}