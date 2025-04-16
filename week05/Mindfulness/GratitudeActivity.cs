using System;

class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity", "Take a moment to reflect on things you are grateful for.") { }

    public void Run()
    {
        // Mostrar el mensaje inicial y obtener la duración
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        Console.Clear();
        Console.WriteLine("Start listing things you're grateful for:");

        while (DateTime.Now < endTime)
        {
            Console.Write("- "); // Mostrar un guion para cada entrada
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"\nGreat job! You listed {count} things you're grateful for.");
        Console.WriteLine("\nNow, take a moment to reflect on the following questions:");

        // Pregunta 1
        Console.WriteLine("\n1. Why are you grateful for these things?");
        Console.Write("Your answer: ");
        string reason = Console.ReadLine();

        // Pregunta 2
        Console.WriteLine("\n2. What would you do to show that you are grateful?");
        Console.Write("Your answer: ");
        string action = Console.ReadLine();

        // Mostrar el mensaje final
        Console.WriteLine("\nThank you for reflecting on gratitude. Take these thoughts with you.");
        DisplayEndingMessage();
    }
}