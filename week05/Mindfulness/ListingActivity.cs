using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who did you help this week?",
        "Who are your heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by listing as many things as you can.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int count = 0;

        Console.WriteLine("Start listing items:");

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        DisplayEndingMessage();
    }
}