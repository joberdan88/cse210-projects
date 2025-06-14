public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = 0;
    }

    public override int RecordEvent()
    {
        _completed++;
        if (_completed >= _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete() => _completed >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Progress: {_completed}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_completed}";
    }
}