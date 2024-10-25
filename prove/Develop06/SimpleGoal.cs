using System;
public class SimpleGoal : Goal
{
    private bool _isCompleted;

    SimpleGoal(string name, string description, string point)
    {
        _isCompleted = false;
    }

    public void RecordEvent()
    {

    }

    public bool isCompleted()
    {
        return false;
    }

    // public string GetStringRepresentation()
    // {
    //     return "";
    // }
}