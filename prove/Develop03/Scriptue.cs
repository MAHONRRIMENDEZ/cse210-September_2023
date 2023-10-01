using System;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();


    public void TheScripture(Reference reference, string text)
    {
        string[] _words = File.ReadAllLines(words);
        _words.Clear();

        foreach (string line in _words)
        {
            string [] parts = line.Split(" | ");
            Word word = new Word();
            word. = parts[0];
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, 51);

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