using System;
using System.ComponentModel;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int point, int target, int amount, int bonus) : base(name, description, point)
    {
        _shortName = name;
        _description = description;
        _points = point;
        _target = target;
        _amountCompleted = amount;
        _bonus = bonus;
    }

    public CheckListGoal()
    {}

    public override void SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.WriteLine("Write a short description: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many point do you set to this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many steps you need to take to achive thius goal? ");
        _target = int.Parse(Console.ReadLine());
        _amountCompleted = 0;
        _bonus = _points;
    }

    public void ExtraGoal(string name, int target, int amount, int bonus)
    {
        _shortName = name;
        _bonus = bonus;
        _target = target;
        _amountCompleted = amount;
    }
    

    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

    public override bool IsCompleted()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void ShowCheck()
    {
        GetDetailString();
    }


    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_points}";
    }
    public string GetDetailString()
    {
        return $"{GetStringRepresentation()} || Completed: {_amountCompleted}/{_target}";
    }

    public override string SaveGoal()
    {
        string lineToSave = "";
        lineToSave = GetDetailString();
        return lineToSave;
    }
}