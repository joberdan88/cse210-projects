using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(newEntry);
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}



