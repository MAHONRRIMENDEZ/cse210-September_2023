using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score;

    public GoalManager()
    {

    }
    public void Start()
    {
        int userComand = 0;

        while (userComand != 6)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu");
            userComand = int.Parse(Console.ReadLine());

            if (userComand == 1)
            {
                CreateGoal();
                
            }
            else if (userComand == 2)
            {
                Console.WriteLine("The Goals are: ");
                ListGoalNames();
                ListGoalDetails(); 
            }
            else if (userComand == 3)
            {
                
            }
            else if (userComand == 4)
            {
                
            }
            else if (userComand == 5)
            {
                
            }
            else 
            {
                Console.WriteLine("That's not a valid option");
            }

            
        }
        

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        //string[] names = "";
       // foreach(string name in names)
        {

        }
    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        int userComand = 0;
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        userComand = int.Parse(Console.ReadLine());
        if (userComand == 1)
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
        
        }
        else if (userComand == 2)
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            
        }
        else if (userComand == 3)
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

        }
        
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        
    }
    public void LoadGoals()
    {
        
    }

}