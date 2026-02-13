using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager
{
    private List<GoalBase> _goals = new List<GoalBase>();
    private int _score = 0;
    private bool _running = true;

    public void Run()
    {
        while (_running)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ShowGoals();
                    break;
                case "3":
                    RecordGoal();
                    break;
                case "4":
                    Save();
                    break;
                case "5":
                    Load();
                    break;
                case "6":
                    _running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("\n==== Eternal Quest ====");
        Console.WriteLine($"Score: {_score}   Rank: {GetRank()}");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Load");
        Console.WriteLine("6. Quit");
        Console.Write("Select: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("1=Simple  2=Eternal  3=Checklist  4=Bad Habit");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
            return;

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Times needed: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
                return;

            Console.Write("Bonus points: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
                return;

            _goals.Add(new CheckListGoal(name, desc, points, target, bonus));
        }
        else if (type == "4")
        {
            _goals.Add(new BadHabitGoal(name, desc, points));
        }
    }

    private void ShowGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
        }
    }

    private void RecordGoal()
    {
        if (_goals.Count == 0)
            return;

        ShowGoals();
        Console.Write("Which goal number? ");

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;

            if (index >= 0 && index < _goals.Count)
            {
                int change = _goals[index].RecordEvent();
                _score += change;

                Console.WriteLine($"Points change: {change}");
            }
        }
    }

    private void Save()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (GoalBase g in _goals)
            {
                writer.WriteLine(g.GetSaveString());
            }
        }

        Console.WriteLine("Saved.");
    }

    private void Load()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
            return;

        string[] lines = File.ReadAllLines(file);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            switch (parts[0])
            {
                case "Simple":
                    _goals.Add(SimpleGoal.Load(parts));
                    break;
                case "Eternal":
                    _goals.Add(EternalGoal.Load(parts));
                    break;
                case "Checklist":
                    _goals.Add(CheckListGoal.Load(parts));
                    break;
                case "Bad":
                    _goals.Add(BadHabitGoal.Load(parts));
                    break;
            }
        }

        Console.WriteLine("Loaded.");
    }

    private string GetRank()
    {
        if (_score >= 5000) return "Celestial Champion";
        if (_score >= 2500) return "Disciple Elite";
        if (_score >= 1000) return "Goal Warrior";
        return "Beginner";
    }
}
