using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void addEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void displayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SavetoFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}|{entry._location}");
            }
        }

    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        // if (File.Exists(filename))
        // {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                // if (parts.Length == 3)
                // {
                //     Entry entry = new Entry
                //     {
                //         _date = parts[0],
                //         _promptText = parts[1],
                //         _entryText = parts[2]
                //     };
                //     _entries.Add(entry);
                // }
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._mood = parts[3];
                entry._location = parts[4];

                _entries.Add(entry);
            }
        // }
    }
}
