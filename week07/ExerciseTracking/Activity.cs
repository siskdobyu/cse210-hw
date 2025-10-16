using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime Date => _date;
    public int Length => _length;

    // Abstract methods — each subclass must override these:
    public abstract double GetDistance(); // km
    public abstract double GetSpeed(); // kph
    public abstract double GetPace(); // min per km

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_length} min): " +
               $"Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}

