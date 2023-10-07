using System;
using System.Collections;
using System.IO;
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
        using(StreamWriter writer = new StreamWriter(file)) 
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{ entry._date} | {entry._prompText} | {entry._entryText}");

            }

            writer.Close();
        }
 


    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompText = parts[1];
            entry._entryText = parts[2];

            
            _entries.Add(entry);

        }
    }

}    