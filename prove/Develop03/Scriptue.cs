using System;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public void scripture(Reference reference, string text)
    {
        return;
    }

    public void HideRandomWords(int numberToHide)
    {
        return;
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false || true;
    }
}