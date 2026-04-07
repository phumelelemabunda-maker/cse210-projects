using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Always gives points, never complete
        return _points;
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string SaveFormat()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}