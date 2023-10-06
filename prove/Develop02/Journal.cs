using System;
using System.Collections;

public class Journal
{
    //public string _newEntry;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry)
    {
        _entries.Add(_newEntry);
    
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        foreach (Entry entry in _entries)
        {

        }
    }

    public void LoadFromFile(string file)
    {
        
        //foreach (string entry in _entries)
        {

        }
    }

}    