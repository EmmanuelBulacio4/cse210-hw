using System;
public class SimpleGoal : Goal
{
    protected bool _isCompleted;

    SimpleGoal(string name, string description, string point) : base(name, description, point)
    {
        _isCompleted = false;
    }

    public override void SetCompletedGoal()
    {
        _isCompleted = true;
    }

    public bool GetCompletedGoal()
    {
        return _isCompleted;
    }

    public override void RecordEvent()
    {
        if (_isCompleted == false) {
            _isCompleted = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public void isCompleted() //lo hereda de la clase Goal
    {
        
    }

    // public string GetStringRepresentation()
    // {
    //     return "";
    // }
}