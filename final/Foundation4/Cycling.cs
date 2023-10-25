using System;

class Cycling : Activity
{
    private int _speed;

    public override int CalculateSpeed() // kilometers per hour)
    {
        return 0;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} {GetTyype()}({GetLenghtActivity()} min) - Distance {GetDistance()} km,{CalculateSpeed()}, {CalculatePace()} min per km";
    }
}