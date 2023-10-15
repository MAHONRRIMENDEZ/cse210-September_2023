using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        
    }
}