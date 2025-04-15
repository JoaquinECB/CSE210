using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some things you are grateful for?",
        "What are some of your favorite memories?",
        "What are some things you love about yourself?",
        "What are some of your favorite places?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("\nYou will have a few seconds to think about the prompt before starting.");
        ShowCountDown(5); // Show countdown for 5 seconds
        Console.WriteLine("\nStart listing your thoughts:");
        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"\nYou listed {userResponses.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
            }
        }
        return responses;
    }
}