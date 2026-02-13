public abstract class GoalBase
{
    protected string _name;
    protected string _desc;
    protected int _points;

    public GoalBase(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract string Display();
    public abstract string GetSaveString();
}
