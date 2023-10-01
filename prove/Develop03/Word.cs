using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public void TheWord(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        
    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return true || false;
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"{_text}");
    }


}