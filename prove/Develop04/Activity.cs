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

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! ");
        Console.WriteLine($"You have completed another {_duration} seconds session of the {_name} Activity.");
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {

        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/"); //|/-\|/-\|
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");   
        /*foreach (string s in animations)
        {


        }*/

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");   

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            } 
        }


    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}