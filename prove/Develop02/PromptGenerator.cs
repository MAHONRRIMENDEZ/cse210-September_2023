using System.Collections.Generic;

public class PromptGenerator
{   
    //public List<string> _prompts;
    public List<string> _prompts = new List<string>();
    
    

    public string GetRandomPrompt()
    {
        _prompts.Add("How am I feeling today?");
        _prompts.Add("What are my top priorities for the day?");
        _prompts.Add("What am I nervous or anxious about today?");
        _prompts.Add("What did I learn today?");
        
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        return "";
        // Random randomGenerator = new Random();
        //string randomPrompt = randomGenerator.Next();
    }
}