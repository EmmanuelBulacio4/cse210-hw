using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int point)  : base(name, description, point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    public EternalGoal()
    {
        
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