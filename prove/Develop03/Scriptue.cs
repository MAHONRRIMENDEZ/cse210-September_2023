using System;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();


    public void TheScripture(Reference reference, string text)
    {

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word();
            newWord.TheWord(word);
            _words.Add(newWord); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _words.Count); // ___ ---
        _words[randomIndex].Hide();
    
    }

    public void GetDisplayText()
    {
        foreach (Word word in _words)
        {
            word.GetDisplayText();

        }

    }

    public bool IsCompletelyHidden()
    {
        return false || true;
    }
}