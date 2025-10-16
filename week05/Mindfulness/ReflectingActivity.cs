using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        
        DisplayPrompt();
        Console.Write("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        //shuffles list of questions

        _questions = _questions.OrderBy(q => Guid.NewGuid()).ToList();

        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        foreach (string question in _questions)
        {
            if (DateTime.Now >= endTime)
                break;

            Console.Write($"> {question} ");
            ShowSpinner(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        ShowSpinner(4);
        Console.WriteLine();
    }
}