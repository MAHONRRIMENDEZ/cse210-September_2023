using System;

class Activity
{
    private string _date;
    private int _lenghtActivity;


    //Distance (km) = swimming laps * 50 / 1000

    public Activity(string date, int lenghtActivity)
    {
        _date = date;
        _lenghtActivity = lenghtActivity;
    }

    public virtual int CalculateDistance()
    {
        
    }
}