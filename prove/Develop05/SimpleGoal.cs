using System;
public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true || false;
    }
    public string GetStringRepresentation()
    {
        return "";
    }

}