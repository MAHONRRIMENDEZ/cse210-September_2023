using System;
public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
    }
    public void GetRandomPrompt()
    {
        
    }
    public void GetListFromUser()
    {
        
    }

    
}