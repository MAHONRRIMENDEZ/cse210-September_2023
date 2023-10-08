using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Welcome to the Mindfulness Program! ");

        int userComand = 0;

        while (userComand != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userComand = int.Parse(Console.ReadLine());

            if (userComand == 1) //breathing
            {
                Console.Clear();
                BreathingActivity newBreath = new BreathingActivity();
                newBreath.Run();
            }

            else if (userComand == 2) //reflecting
            {
                Console.Clear();
                ReflectingActivity newReflect = new ReflectingActivity();
                newReflect.Run();
               
            }

            else if (userComand == 3) //listing
            {
                Console.Clear();
                ListingActivity newListing = new ListingActivity();
                newListing.Run();
            }

            else 
            {
                Console.WriteLine("That's not a valid option");
            }


        }

    }
}