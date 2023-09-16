using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will calculate your grade");
      
        Console.Write("What is your percentage grade? ");
        String gradeUser = Console.ReadLine();

        int x = int.Parse(gradeUser);
        string letter = "";
    
        if (x >= 90)
        {
            letter = "A";
            //Console.WriteLine("Good job Your Grade is 'A'");
        }
        else if (x >= 80)
        {
            letter = "B";
            //Console.WriteLine("Good job Your Grade is 'B'");
        }
        else if (x >= 70)
        {
            letter = "C";
            //Console.WriteLine("Your Grade is 'C'");
        }
        else if (x >= 60)
        {
            letter = "D";
            //Console.WriteLine("Your Grade is 'D'");
        }
        else if (x < 60)
        {
            letter = "F";
            //Console.WriteLine("Your Grade is 'F'");
        }
        Console.WriteLine($"Your grade is {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congrats!! You have approved the course");
        }

        if (x < 70)
        {
            Console.WriteLine("We regret to inform you that you didn't pass the course, we know you can do it better next time");
        }
    }   
}