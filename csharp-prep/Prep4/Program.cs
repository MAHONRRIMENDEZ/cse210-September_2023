using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber = -1;

        List<int> numbers = new List<int>();

        //in case we need it List<string> words = new List<string>();

        while (newNumber != 0)
        {    
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());        
            
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            
        }
    }
} 