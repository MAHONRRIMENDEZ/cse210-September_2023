using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breating";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("breth in... "); 
            ShowCountDown(2);
            Console.WriteLine();
            Console.Write("breath out... ");  
            ShowCountDown(3);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}