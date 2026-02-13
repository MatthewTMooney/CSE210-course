public class EternalGoal : GoalBase
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string Display()
    {
        return $"[∞] {_name} ({_desc})";
    }

    public override string GetSaveString()
    {
        return $"Eternal|{_name}|{_desc}|{_points}";
    }

    public static EternalGoal Load(string[] p)
    {
        return new EternalGoal(p[1], p[2], int.Parse(p[3]));
    }
}
