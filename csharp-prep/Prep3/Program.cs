using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("Hello, lets play 'Guess the random number'");
        //string x = Console.ReadLine();
        //int magicNumber = int.Parse(x);


        int userGuess = -1;

        while (magicNumber != userGuess)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());


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