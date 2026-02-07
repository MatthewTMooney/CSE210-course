using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    { }

    protected override void Run()
    {
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration)
                break;

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(6);
            elapsed += 6;
        }
    }
}
