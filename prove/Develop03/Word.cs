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
        if (IsHidden() == false)
        {
            _text = "___";

        }
        
    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        if (_text == "___")
        {
            return true;
        }

        return false;
    }

    public void GetDisplayText()
    {
        Console.Write($"{_text} ");
        Console.WriteLine();
    }


}