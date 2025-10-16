using System;

public class Cycling : Activity
{
    private double _speed; //in kph

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * Length / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
