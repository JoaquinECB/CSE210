using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> prompts = new List<string>
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

    static List<string> journalEntries = new List<string>();

    static void Main(string[] args)
    {
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
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
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

    static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.Write("Your Answer: ");
        string response = Console.ReadLine();
        string entry = $"{DateTime.Now.ToShortDateString()} - {prompt} - {response}";
        journalEntries.Add(entry);
        Console.WriteLine("Entry saved.");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (string entry in journalEntries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("\nEnter the filename to save the journal: ");
        string fileName = Console.ReadLine();
        File.WriteAllLines(fileName, journalEntries);
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("\nEnter the filename to load the journal: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            journalEntries = new List<string>(File.ReadAllLines(fileName));
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}