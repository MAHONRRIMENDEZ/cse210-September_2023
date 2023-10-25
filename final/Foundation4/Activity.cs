using System;

class Activity
{
    private string _date;
    private int _lenghtActivity;


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


    public virtual int CalculateDistance()
    {
        return 0;
    }
    public virtual int CalculateSpeed()
    {
        return 0;
    }
    public virtual int CalculatePace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} *ACTIVITY*{_lenghtActivity} - {CalculateDistance()},{CalculateSpeed()}, {CalculatePace()}";
    }

    /*03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km*/
}