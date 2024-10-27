using System;
public class EternalGoal : Goal
{
    EternalGoal(string name, string description, string point)  : base(name, description, point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    public override void RecordEvent()
    {
        return ;
    }
    public override bool IsCompleted()
    {
        return false;
    }
}