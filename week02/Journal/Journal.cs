// week02/Journal/Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List that stores all journal entries
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        Console.WriteLine();
        Console.WriteLine($"Total Entries: {_entries.Count}");
        Console.WriteLine("----------------------------");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save entries to file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}");
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    // Load entries from file
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}