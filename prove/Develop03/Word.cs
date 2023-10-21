using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    // private string hiddenWord;

    public Word(string text)
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
        _isHidden = false;
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
    }


}