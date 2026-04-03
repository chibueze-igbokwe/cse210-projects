using System;

// Guides breathing in/out rhythm
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity helps you relax by guiding slow breathing in and out."
        )
    { }

    public override void Run()
    {
        Start();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);

            Console.Write("\nBreathe out...");
            ShowCountdown(4);
        }

        End();
    }
}
