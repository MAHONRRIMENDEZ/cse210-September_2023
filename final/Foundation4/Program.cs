using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("Welcome to the Activity tracker");

        Running r1 = new Running();
        r1.SetDistance(3);
        r1.SetTyype("Running");
        r1.SetDate("03 Nov 2022");
        r1.SetLenghtActivity(30);
        activities.Add(r1);



        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine($"{summary}");
        }

    }
}


/*Once you have the classes in place, write a program that creates at least 
one activity of each type. Put each of these activities in the same list. 
Then iterate through this list and call the GetSummary method on each item 
and display the results.*/