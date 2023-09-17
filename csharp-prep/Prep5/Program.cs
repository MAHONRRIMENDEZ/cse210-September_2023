using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.WriteLine("Please Write your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine("Please enter your favorite number: ");
        int userNumber = 0;
        userNumber = int.Parse(Console.ReadLine());

        // calculating the square 

        int square = userNumber * userNumber;

        Console.WriteLine($"the square is {square}");

    }
}