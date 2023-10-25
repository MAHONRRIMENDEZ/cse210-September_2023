using System;

class Swimming : Activity
{
    private string _numberLaps;

    public override string GetSummary()
    {
        return $"{GetLenghtActivity()} *ACTIVITY*{GetLenghtActivity()} - {CalculateDistance()},{CalculateSpeed()}, {CalculatePace()}";
    }
}