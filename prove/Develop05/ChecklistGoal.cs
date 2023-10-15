using System;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }


}