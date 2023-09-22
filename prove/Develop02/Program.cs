using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
        Journal theJournal = new Journal();

        int userComand = -1;
        while (userComand != 5)
        {
            Console.WriteLine("Please select one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userComand = int.Parse(Console.ReadLine());

            if (userComand == 1)
            {

            }

            if (userComand == 2)
            {
                
            }

            if (userComand == 3)
            {
                
            }

            if (userComand == 4)
            {
                
            }      
        }

    }
}