using System;
public class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
        

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
        _duration = 0;        

    }
    public void Run()
    {
        DisplayStartingMessage();
    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
    
}