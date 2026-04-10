using System;

// Swimming stores laps
public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50m → convert to miles
        return (_laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
