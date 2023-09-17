using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplaySquare(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!!");
    }

    string PromptUserName()
    {
        Console.Write("Please write your full name: ");
        string name = Console.ReadLine();

        return name;
    }

    int PromptUserNumber()
    {
        Console.Write("Please share your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }


    void DisplaySquare(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}