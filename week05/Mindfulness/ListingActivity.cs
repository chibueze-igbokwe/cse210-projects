using System;
using System.Collections.Generic;

// Helps user list positive items quickly
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate.",
        "List your personal strengths.",
        "List people you helped recently.",
        "List things you're grateful for."
    };

    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity helps you list positive things in your life."
        )
    { }

    public override void Run()
    {
        Start();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);

        Console.WriteLine("\nGet ready...");
        ShowCountdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
                count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");

        End();
    }
}
