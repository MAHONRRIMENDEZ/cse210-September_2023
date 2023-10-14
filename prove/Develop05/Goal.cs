using System;
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, int points)
    {

    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true || false;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public string GetStringRepresentation()
    {
        return "";
    }

    
}