using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"🗓️ Progress on '{_shortName}': {_amountCompleted}/{_target}");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"🏅 Goal '{_shortName}' completed! You earned {_points + _bonus} points (including {_bonus} bonus!)");
        }
        else
        {
            Console.WriteLine($"You earned {_points} points!");
        }
    }

    public override string GetDetailsString()
    {
        bool complete = _amountCompleted >= _target;
        string status = complete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public static ChecklistGoal FromString(string data)
    {
        string[] parts = data.Split('|');
        ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
        g._amountCompleted = int.Parse(parts[4]);
        return g;
    }
}
