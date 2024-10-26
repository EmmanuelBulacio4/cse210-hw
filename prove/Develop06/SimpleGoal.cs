using System;
public class SimpleGoal : Goal
{
    protected bool _isCompleted;

    SimpleGoal(string name, string description, string point) : base(name, description, point)
    {
        _isCompleted = false;
    }

    public void SetComletedGoal()
    {
        _isCompleted = true;
    }

    public override void RecordEvent() //lo hereda de la clase Goal.
    {
        if (_isCompleted == false) {
            _isCompleted = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    //isCompleted() lo hereda de la clase Goal

    // public string GetStringRepresentation()
    // {
    //     return "";
    // }
}