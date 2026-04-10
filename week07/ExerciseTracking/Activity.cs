using System;

// Base class
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Abstract methods (must be overridden)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Shared summary method (DO NOT override in children)
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name.Replace("Activity", "")} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace {GetPace():0.0} min per mile";
    }

    protected int GetMinutes()
    {
        return _minutes;
    }
}
