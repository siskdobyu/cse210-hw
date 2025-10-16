using System;

public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => GetDistance() / Length * 60;

    public override double GetPace() => Length / GetDistance();
}
