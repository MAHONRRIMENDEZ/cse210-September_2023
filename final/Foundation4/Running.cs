using System;

class Running : Activity
{
    private int _distance;

    public Running(int distance)
    {
        _distance = distance;
        
    }
    public override string GetSummary()
    {
        return $"{GetLenghtActivity()} *ACTIVITY*{GetLenghtActivity()} - {CalculateDistance()},{CalculateSpeed()}, {CalculatePace()}";
    }
}