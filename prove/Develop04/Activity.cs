using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }   
    public void DisplayStartingMessage()
    {
        
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); 
    
        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds session of the {_name} Activity.");
    }
    public void ShowSpinner(int seconds)
    {
        seconds = _duration;
        Console.WriteLine("Get Ready...");

        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/"); //|/-\|/-\|
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");   
        foreach (string s in animations)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }
    public void ShowCountDown(int seconds)
    {

    }


}