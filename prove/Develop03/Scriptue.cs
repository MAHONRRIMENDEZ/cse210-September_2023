using System;
using System.Reflection.Metadata;

public class Scripture
{
    protected Reference _reference;

    private List<Word> _words = new List<Word>();


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int N = 0;

        int randomIndex = random.Next(0, _words.Count); // ___ ---

        // while ( N != numberToHide)
        /*
            randomIndex
            Check if all the words are hidden. Hint(is completly hidden)
                numberToHide = N

            Check if the word is hidden.Hint(_words[index].ishidden()) Hide if false, otherwise get a new index

        */ 

        if (_words[randomIndex].IsHidden() == true)
        {
            
        }
        // if (Commandment.isHiden())
        _words[randomIndex].Hide();

        /*
        while (numberToHide > N)
        {
            for (int i = 0; i < numberToHide; ++i)
            {
                int randomIndex = random.Next(0, _words.Count); // ___ ---
                _words[randomIndex].Hide();
            }
        } */

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

        // Check if all the words are hidden.
        
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
            
        }

        return true;
        
    }
}