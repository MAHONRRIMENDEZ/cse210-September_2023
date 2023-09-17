using System;

class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers = new List<int>();


        int newNumber = -1;
        //in case we need it List<string> words = new List<string>();
        Console.WriteLine("We will add some numbers to a list and receive some facts about it, type 0 when finished. ");
        while (newNumber != 0)
        {    
            //Console.WriteLine("Enter a number, type 0 when finished. ");
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            newNumber = int.Parse(userResponse);

            
            //newNumber = int.Parse(Console.ReadLine());        
            
            if (newNumber != 0)
            {
                //don't needed //Console.Write("Enter number: ");
                numbers.Add(newNumber);
            }
        }

        //Suma

        int suma = 0;
        foreach (int number in numbers)
        {
            suma += number;
        }
        Console.WriteLine("--List closed--");
        Console.WriteLine($"The total is: {suma}");



        //average

        float average = ((float)suma) / numbers.Count;
        Console.WriteLine($"The average is {average}");
        


        //max number

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The new max number is {max}");
        
    }
} 