using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to the event planer");

        //Lecture 1
        Address a1 = new Address("123 flowers street, Salt lake city, UT");
        
        Lecture l1 = new Lecture("President Marco Arias", 45, a1); 
        
        
        l1.SetType("Lecture");
        l1.SetEventTitle("General meeting for Stake leaders");
        l1.SetDescription("We will learn more about how to care and love the new members of the Church"); 
        l1.SetDate("11/25/2023");
        l1.SetTime("11:00 AM");

        Console.WriteLine($"{l1.GetType()}:");
        Console.WriteLine($"{l1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{l1.FullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{l1.ShortDescription()}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        
        // Reception 1

        Address a2 = new Address("123 Nature street, Ogden, UT");
        
        Reception r1 = new Reception("Wedding@gmail.com", a2); 
        
        
        r1.SetType("Reception");
        r1.SetEventTitle("Valeria and Maho's wedding");
        r1.SetDescription("We will have the ceremony at noon, Photoshoot during the afternoon, and party until dawn"); 
        r1.SetDate("24/September/2024");
        r1.SetTime("11:00 AM");

        Console.WriteLine($"{r1.GetType()}:");
        Console.WriteLine($"{r1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{r1.FullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{r1.ShortDescription()}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------");


        // Outdoor 1
        Address a3 = new Address("123 Primal street, Lehi, UT");
        
        Outdoor o1 = new Outdoor("rainy", a3); 
        
        
        o1.SetType("Outdoor");
        o1.SetEventTitle("Picnic for Linde's ward");
        o1.SetDescription("We will have a delicious breakfast, team/family activities, hike, and lunch"); 
        o1.SetDate("20/01/2024");
        o1.SetTime("06:00 AM");

        Console.WriteLine($"{o1.GetType()}:");
        Console.WriteLine($"{o1.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{o1.FullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"{o1.ShortDescription()}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------");


    }
}