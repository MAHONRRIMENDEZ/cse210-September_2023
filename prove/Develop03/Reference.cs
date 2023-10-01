using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public void TheReference(string book, int chapter, int verse)
    { 
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void TheReference(string book, int chapter, int startVerse, int endVerse)
    { 
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public void GetDisplayText()
    {
        
        Console.WriteLine($"{_book} {_chapter}:{_verse} ");
        Console.WriteLine($"{_book} {_chapter}:{_verse} - {_endVerse}");
        
    
    }
}