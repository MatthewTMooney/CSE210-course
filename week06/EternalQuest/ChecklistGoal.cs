public class CheckListGoal : GoalBase
{
    private int _count;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        if (_count >= _target)
            return 0;

        _count++;

        if (_count == _target)
            return _points + _bonus;

        return _points;
    }

    public override string Display()
    {
        string box = (_count >= _target) ? "[X]" : "[ ]";
        return $"{box} {_name} ({_desc}) Completed {_count}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_desc}|{_points}|{_count}|{_target}|{_bonus}";
    }

    public static CheckListGoal Load(string[] p)
    {
        CheckListGoal g = new CheckListGoal(
            p[1],
            p[2],
            int.Parse(p[3]),
            int.Parse(p[5]),
            int.Parse(p[6])
        );

        g._count = int.Parse(p[4]);
        return g;
    }
}
