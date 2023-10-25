using System;

class Running : Activity
{
    //
    //private int _distance; // Kilometers

    public Running()
    {
    }
    /*public override int CalculateDistance()
    {
        return 0;
    }*/
    
    public override int CalculatePace() //  minutes per kilometer) In either case the length of a lap in the lap pool is 50 meters.
    {
        return GetLenghtActivity() / GetDistance();
    }
    public override int CalculateSpeed() // kilometers per hour)
    {
        return GetDistance() / GetLenghtActivity() * 60;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} {GetTyype()}({GetLenghtActivity()} min) - Distance: {GetDistance()} km, Speed: {CalculateSpeed()} kph, {CalculatePace()} min per km";
    }
}