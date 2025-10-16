using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public bool IsCompleteFlag => _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"✅ Goal '{_shortName}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete!");
        }
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}|{_isComplete}";
    }

    public static SimpleGoal FromString(string data)
    {
        string[] parts = data.Split('|');
        return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
        {
            _isComplete = bool.Parse(parts[4])
        };
    }
}
