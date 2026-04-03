using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed courage."
    };

    List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel afterward?",
        "What did you learn?",
        "How can you use this experience again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity helps you reflect on moments of strength.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nTake a moment to think...");
        ShowSpinner(5);

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}