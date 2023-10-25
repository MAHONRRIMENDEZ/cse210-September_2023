using System;

class Outdoor : Event
{
    private string _weather;
    private Address _address;

    public Outdoor(string weather, Address address) 
    {
        
        _weather = weather;
        _address = address;
    }
    // Getters and Setters

    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public string StandardDetails()
    {
        
        Console.WriteLine(); //this may need to be in the main class, but I can't pass the address correctly. 
        Console.WriteLine("Standard Details: ");
        return $"Event Title: {GetEventTitle()}. \nDescription: {GetDescription()}. \nDate and Time: {GetDate()} - {GetTime()}, \nAddress: {_address.CompleteAddress()}.";
    }
    public string FullDetails()  
    {
        Console.WriteLine("Full and Standard Details:");
        return $"This will be a {GetType()} event. \n{StandardDetails()}. Please be advised that the most likely weather will be, {_weather}, so please take your forecasts. ";
    }

}