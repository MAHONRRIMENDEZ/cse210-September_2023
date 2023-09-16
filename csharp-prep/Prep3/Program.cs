using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please share a random number: ");
        string x = Console.ReadLine();
        int magicNumber = int.Parse(x);

        Console.Write("What is your guess? ");
        string y = Console.ReadLine();
        int userGuess = int.Parse(y);


        if (magicNumber == userGuess)
        {
            Console.WriteLine("You got it!! ");
        }

        else if (magicNumber > userGuess)
        {
            Console.WriteLine("Try higher ");
        }

        else if (magicNumber < userGuess)
        {
            Console.WriteLine("Try lower ");
        }
    }
}