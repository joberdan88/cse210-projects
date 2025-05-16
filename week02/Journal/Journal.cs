using System;
using System.Collections.Generic;

public class Journal
{
    public string _owner;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Journal of {_owner}");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
