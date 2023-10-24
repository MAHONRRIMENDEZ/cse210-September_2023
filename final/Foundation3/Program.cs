using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to the event planer");
        Lecture l1 = new Lecture("the speaker", 45);
        l1.SetType("Lecture");
        l1.SetEventTitle("General meeting for stake leaders");
        l1.SetDescription("We will learn more about how to take care of the new members of the Church"); 
        l1.SetDate("11/25/2023");
        l1.SetTime("11:00 AM");

        Console.WriteLine($"{l1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{l1.FullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{l1.ShortDescription()}");
        
        


    }
}