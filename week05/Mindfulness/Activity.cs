using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" }; // Array of spinner characters
        int spinnerIndex = 0;

        Console.Write("Loading ");
        for (int i = 0; i < seconds * 4; i++) // 4 updates per second
        {
            Console.Write($"\rLoading {spinner[spinnerIndex]}"); // Overwrites the line with the spinner character
            spinnerIndex = (spinnerIndex + 1) % spinner.Length; // Cycle through the spinner characters
            System.Threading.Thread.Sleep(250); // Wait for 250 milliseconds
        }
        Console.Write("\r           \r"); // Clean up the line
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} "); // Overwrite the line with the countdown
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
        }
        Console.Write("\r   \r"); // Clean up the line
    }
}