using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber = -1;

        List<int> numbers = new List<int>();

        List<string> words = new List<string>();

        while (newNumber != 0)
            Console.WriteLine("What number would you like to append? ");
            newNumber = int.Parse(Console.ReadLine());        


    }
} 