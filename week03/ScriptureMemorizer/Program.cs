using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Project!");

        // Create a reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetReference()}");
            Console.WriteLine($"{scripture.GetDisplayText()}");

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 random words at a time
        }
    }
}