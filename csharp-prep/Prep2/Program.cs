using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will calculate your grade");
      
        Console.Write("What is your percentage grade? ");
        String gradeUser = Console.ReadLine();

        int x = int.Parse(gradeUser);
        if (x >= 90)
        {
            Console.WriteLine("Good job Your Grade is 'A'");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Good job Your Grade is 'B'");
        }
        else if (x >= 70)
        {
            Console.WriteLine("Your Grade is 'C'");
        }
        else if (x >= 60)
        {
            Console.WriteLine("You have to do it better next time, Your Grade is 'D'");
        }
        else if (x < 60)
        {
            Console.WriteLine("We regret to inform you that your Grade is 'F'");
        }
    }   
}