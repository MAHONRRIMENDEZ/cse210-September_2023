using System;

class Swimming : Activity
{
    private string _numberLaps;

    public override int CalculatePace() //  minutes per kilometer) In either case the length of a lap in the lap pool is 50 meters.
    {
        return 0;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} {GetTyype()}({GetLenghtActivity()} min) - Distance {GetDistance()} km,{CalculateSpeed()}, {CalculatePace()} min per km";
    }
}