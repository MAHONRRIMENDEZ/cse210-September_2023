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
        ShowSpinner(_duration);
        

        DisplayEndingMessage();
    }
}