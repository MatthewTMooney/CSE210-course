public class BadHabitGoal : GoalBase
{
    public BadHabitGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return -_points;
    }

    public override string Display()
    {
        return $"[!!!] {_name} (Bad Habit)";
    }

    public override string GetSaveString()
    {
        return $"Bad|{_name}|{_desc}|{_points}";
    }

    public static BadHabitGoal Load(string[] p)
    {
        return new BadHabitGoal(p[1], p[2], int.Parse(p[3]));
    }
}
