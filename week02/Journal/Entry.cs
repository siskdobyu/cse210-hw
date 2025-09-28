using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //Additional information in the journal entry
    public string _mood;
    public string _location;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine();
    }
}