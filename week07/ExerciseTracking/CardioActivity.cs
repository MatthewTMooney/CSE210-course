using System;

public abstract class CardioActivity : Activity
{
    public CardioActivity(string date, int minutes)
        : base(date, minutes)
    {
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





public class RunningActivity : CardioActivity
{
    private double _miles;

    public RunningActivity(string date, int minutes, double miles)
        : base(date, minutes)
    {
        _miles = miles;
    }

    public override double GetDistance()
    {
        return _miles;
    }
}





public class CyclingActivity : CardioActivity
{
    private double _avgSpeed;

    public CyclingActivity(string date, int minutes, double avgSpeed)
        : base(date, minutes)
    {
        _avgSpeed = avgSpeed;
    }

    public override double GetDistance()
    {
        return (_avgSpeed / 60) * GetMinutes();
    }

    public override double GetSpeed()
    {
        return _avgSpeed;
    }
}





public class SwimmingActivity : CardioActivity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }
}
