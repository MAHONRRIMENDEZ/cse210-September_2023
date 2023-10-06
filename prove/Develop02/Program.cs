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

            if (userComand == 1) //Write
            {
                PromptGenerator Prompt = new PromptGenerator();
                string newPrompt = Prompt.GetRandomPrompt();
                Console.WriteLine(newPrompt);
                    //PromptGenerator prompt1 = PromptGenerator();

                DateTime theCurrentTime = DateTime.Now;

                Entry newEntry  = new Entry();
                newEntry._date = theCurrentTime.ToShortDateString();
                newEntry._prompText = newPrompt;
                newEntry._entryText = Console.ReadLine();
                
                theJournal._entries.Add(newEntry);

           
            }

            else if (userComand == 2) //Display
            {
                
                theJournal.DisplayAll();     
            }

            else if (userComand == 3)
            {
                Console.WriteLine("Please share your file name ");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);
            }

            else if (userComand == 4)
            {
                Console.WriteLine("Please share your file name you want to load ");
                string file = Console.ReadLine();

                theJournal.LoadFromFile(file);                
            }      
        }

    }
}