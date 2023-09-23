using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
    

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

            if (userComand == 1) //Write
            {
                string one = "What was the learing today? ";
                Console.WriteLine("What was the learing today? ");
                //PromptGenerator prompt1 = PromptGenerator();
                Entry newEntry  = new Entry();
                newEntry._date = "09/22/2023";
                newEntry._prompText = one;
                newEntry._entryText = Console.ReadLine();
                
                Journal theJournal = new Journal();
                theJournal._entries.Add(newEntry);

           
            }

            if (userComand == 2) //Display
            {
                
                Journal theJournal2 = new Journal();
                theJournal2.DisplayAll();     
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