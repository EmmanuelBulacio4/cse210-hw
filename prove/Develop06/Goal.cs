using System;
using System.Runtime.InteropServices;
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _completedGoal;

    public Goal()
    {
    }
    public Goal(string name, string description, string point)
    {
        _shortName = name;
        _description = description;
        _points = point;
        _completedGoal = false;
    }

    public void SetGoal()
    {

        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.WriteLine("Write a short description: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many point do you set to this goal? ");
        _points = Console.ReadLine();
        _completedGoal = false;
        
    }

    //Getters

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoint()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsCompleted()
    {
        return false;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }

    public virtual string SaveGoal()
    {
        return "";
    }
}