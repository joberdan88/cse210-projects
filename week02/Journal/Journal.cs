using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

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
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                Entry newEntry = new Entry(parts[0], parts[1], parts[2], "General");
                _entries.Add(newEntry);
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date, Prompt, Response");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"\"{entry._date}\",\"{entry._prompt}\",\"{entry._response}\"");
            }
        }
        Console.WriteLine("Journal saved as CSV successfully!");
    }

    public void SaveToJSON(string filename)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved as JSON successfully!");
    }

    public void LoadFromJSON(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal loaded form JSON successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void CheckForDailyEntry()
    {
        if (_entries.Count == 0 || _entries[_entries.Count - 1]._date != DateTime.Now.ToShortDateString())
        {
            Console.WriteLine("\nReminder: You haven't written in your journal today! ");
        }
    }
}

















