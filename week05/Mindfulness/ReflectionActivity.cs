using System;
using System.Collections.Generic;

// Helps user reflect on past experiences
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Think of a time you helped someone.",
        "Think of a time you showed courage.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this experience special?",
        "How can you apply this in future situations?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity helps you reflect on moments of strength and resilience."
        )
    { }

    public override void Run()
    {
        Start();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("\nThink deeply...");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("\n" + _questions[_random.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        End();
    }
}
