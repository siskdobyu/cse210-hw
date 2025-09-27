using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

public class promptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?",   "If I had one thing I could do over today, what would it be?","What challenged me today?","What is something I learned today?"
    };

    private Random _random = new Random();

    public string getRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}