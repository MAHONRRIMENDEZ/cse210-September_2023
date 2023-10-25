using System;

class Cycling : Activity
{
    private string _speed;

    public override string GetSummary()
    {
        return $"{GetLenghtActivity()} *ACTIVITY*{GetLenghtActivity()} - {CalculateDistance()},{CalculateSpeed()}, {CalculatePace()}";
    }
}