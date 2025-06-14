using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Your current score is: {_score}\n");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option."); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Goala types:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.WriteLine("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = type switch
        {
            "1" => new SimpleGoal(name, desc, points),
            "2" => new EternalGoal(name, desc, points),
            "3" => CreateChecklistGoal(name, desc, points),
            _ => null
        };

        if (goal != null)
            _goals.Add(goal);
    }

    private ChecklistGoal CreateChecklistGoal(string name, string desc, int points)
    {
        Console.Write("Target count: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Bonus points: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, desc, points, target, bonus);
    }

    private void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index++}. {g.GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter the number of the goal to record progress.");
        int i = int.Parse(Console.ReadLine()) - 1;

        if (i >= 0 && i < _goals.Count)
        {
            int earned = _goals[i].RecordEvent();
            _score += earned;
            Console.WriteLine($"You gained {earned} points!");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
                writer.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("Goal saved to goals.txt");
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal goal = parts[0] switch
            {
                "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
                { },
                "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5]))
                { },
                _ => null
            };

            if (goal != null) _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded from goals.txt");
    }
}