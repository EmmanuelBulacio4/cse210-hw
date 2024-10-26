using System;
using System.Runtime.InteropServices;
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal()
    {
        SetGoal();
    }
    public Goal(string name, string description, string point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    public void SetGoal()
    {

        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.WriteLine("Write a short description: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many point do you set to this goal? ");
        _points = Console.ReadLine();
        
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
        if (isCompleted() == false) {
            SetCompletedGoal();
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public virtual void SetCompletedGoal()
    {
    }

    public virtual bool isCompleted()
    {
        return false;
    }

    public virtual string GetDetailString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}