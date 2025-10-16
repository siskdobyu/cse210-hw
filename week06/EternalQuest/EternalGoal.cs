using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{_shortName}' recorded! You earned {_points} points.");
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description})";
    }
    

    
}