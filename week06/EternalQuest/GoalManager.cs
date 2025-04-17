using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1; // Starting level
    }

    public void AddGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Enter your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter goal number to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.Points;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }

            CheckLevelUp(); // Check if the player levels up after recording the event
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void CheckLevelUp()
    {
        int pointsForNextLevel = _level * 100; // Example: 100 points per level
        if (_score >= pointsForNextLevel && _level < 10) // Max level: 10
        {
            _level++;
            Console.WriteLine($"Congratulations! You've reached level {_level}!");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Current Level: {_level}");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Points: {_score}");
            writer.WriteLine($"Level: {_level}");
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
            {
                Console.WriteLine("Error: File format is invalid.");
                return;
            }

            // Read and validate points
            if (!lines[0].StartsWith("Points: ") || !int.TryParse(lines[0].Substring(8), out _score))
            {
                Console.WriteLine("Error: Points are not in the correct format.");
                return;
            }

            // Read and validate level
            if (!lines[1].StartsWith("Level: ") || !int.TryParse(lines[1].Substring(7), out _level))
            {
                Console.WriteLine("Error: Level is not in the correct format.");
                return;
            }

            _goals.Clear();

            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == nameof(SimpleGoal))
                {
                    bool isComplete = bool.Parse(parts[4]);
                    var simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete) simpleGoal.RecordEvent();
                    _goals.Add(simpleGoal);
                }
                else if (type == nameof(EternalGoal))
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == nameof(ChecklistGoal))
                {
                    int target = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < completed; j++) checklistGoal.RecordEvent();
                    _goals.Add(checklistGoal);
                }
            }
        }
        else
        {
            Console.WriteLine("Error: File does not exist.");
        }
    }
}


