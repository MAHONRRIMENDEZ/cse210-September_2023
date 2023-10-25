using System;

class Activity
{
    private string _date;
    private int _lenghtActivity;
    private string _type;
    
    private int _distance;

    //Distance (km) = swimming laps * 50 / 1000
    public Activity()
    {
       
    }
    public Activity(string date, int lenghtActivity)
    {
        _date = date;
        _lenghtActivity = lenghtActivity;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetLenghtActivity(int lenghtActivity)
    {
        _lenghtActivity = lenghtActivity;
    }
    public int GetLenghtActivity()
    {
        return _lenghtActivity;
    }
    public void SetTyype(string type)
    {
        _type = type;
    }
    public string GetTyype()
    {
        return _type;
    }
    public void SetDistance(int distance)
    {
        _distance = distance;
    }
    public int GetDistance()
    {
        return _distance;
    }
    
    
    /*public virtual int CalculateDistance()
    {
        return GetDistance();
    }*/
    public virtual int CalculateSpeed() // kilometers per hour)
    {
        return GetDistance() / GetLenghtActivity() * 60;
    }
    public virtual int CalculatePace() //  minutes per kilometer) In either case the length of a lap in the lap pool is 50 meters.
    {
        return GetLenghtActivity() / GetDistance();
    }
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetTyype()}({GetLenghtActivity()} min) - Distance: {GetDistance()} km, Speed: {CalculateSpeed()}, {CalculatePace()} min per km";
    }

    /*03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km*/
}