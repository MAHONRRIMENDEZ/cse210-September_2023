using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {   
        return true || false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}