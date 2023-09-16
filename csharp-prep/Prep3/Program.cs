using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("Hello, lets play 'Guess the random number'");
        //string x = Console.ReadLine();
        //int magicNumber = int.Parse(x);

        Console.Write("What is your guess? ");
        string y = Console.ReadLine();
        int userGuess = int.Parse(y);


        while (magicNumber != userGuess)
        {
            if (magicNumber == userGuess)
            {
            Console.WriteLine("You guess it!!");
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
}