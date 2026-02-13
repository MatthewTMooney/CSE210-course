public class SimpleGoal : GoalBase
{
    private bool _done = false;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (!_done)
        {
            _done = true;
            return _points;
        }
        return 0;
    }

    public override string Display()
    {
        string box = _done ? "[X]" : "[ ]";
        return $"{box} {_name} ({_desc})";
    }

    public override string GetSaveString()
    {
        return $"Simple|{_name}|{_desc}|{_points}|{_done}";
    }

    public static SimpleGoal Load(string[] p)
    {
        SimpleGoal g = new SimpleGoal(p[1], p[2], int.Parse(p[3]));
        g._done = bool.Parse(p[4]);
        return g;
    }
}
