using System;

public class Journal
{
    public string _newEntry;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry)
    {
        /*
        Entry aNewEntry = new Entry();
        aNewEntry._date = "";
        aNewEntry._entryText = $"{_newEntry}";
        aNewEntry._prompText = "";

        Entry theNewEntry = new Entry();

        theNewEntry._entries.Add(_newEntry)
        */
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
        Entry newEntry = new Entry();
        newEntry.Display();
        }

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}    