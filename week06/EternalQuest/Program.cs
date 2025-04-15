using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string filePath = "goals.txt";
        string choice;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddGoal();
                    break;
                case "2":
                    manager.RecordEvent();
                    break;
                case "3":
                    manager.ListGoalDetails();
                    break;
                case "4":
                    manager.SaveGoals(filePath);
                    Console.WriteLine("Goals saved.");
                    break;
                case "5":
                    manager.LoadGoals(filePath);
                    Console.WriteLine("Goals loaded.");
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "6");
    }
}



