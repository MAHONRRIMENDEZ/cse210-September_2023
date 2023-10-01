using System;

class Program
{
    static void Main(string[] args)
    {
        Reference R1 = new Reference();
        R1.TheReference("1 Nefi", 3, 7);
        R1.GetDisplayText();


        Console.WriteLine("Hello Welcome to the Scripture memorizer");
        Console.WriteLine("Please use 'Enter' to Hide words and Write 'quit to finish");
        
        string userComand = Console.ReadLine();

        while (userComand != "quit")
        {
            if (userComand == "");

        }
    }
}