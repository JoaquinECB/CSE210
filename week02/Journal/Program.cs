using System;
using System.Collections.Generic;

class PromptManager
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today?",
        "What made me smile today?",
        "What is something I am grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}

class Journal
{
    private List<string> entries = new List<string>();

    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nJournal Entries:");
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Filename cannot be empty. Please try again.");
            return;
        }

        File.WriteAllLines(fileName, entries);
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries = new List<string>(File.ReadAllLines(fileName));
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PromptManager promptManager = new PromptManager();
        Journal journal = new Journal();

        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string prompt = promptManager.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("Your Answer: ");
                    string response = Console.ReadLine();
                    string entry = $"{DateTime.Now.ToShortDateString()} - {prompt} - {response}";
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry saved.");
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("\nEnter the filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("\nEnter the filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}