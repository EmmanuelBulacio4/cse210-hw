using System;
public class SimpleGoal : Goal
{
    private bool _isCompleted;

    SimpleGoal(string name, string description, string point) : base(name, description, point)
    {
        _isCompleted = false;
    }

    //RecordEvent() lo hereda de la clase Goal.

    //isCompleted() lo hereda de la clase Goal

    // public string GetStringRepresentation()
    // {
    //     return "";
    // }
}