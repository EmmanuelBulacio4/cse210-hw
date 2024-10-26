using System;
public class SimpleGoal : Goal
{
    SimpleGoal(string name, string description, string point) : base(name, description, point)
    {
        _completedGoal = false;
    }

    public override void RecordEvent()
    {
        if (_completedGoal == false) {
            _completedGoal = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsCompleted()
    {
        if (_completedGoal == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public void ShowCheck()
    {
        string checkSymbol = "";
        bool _isCompleted = IsCompleted();
        if (_isCompleted == true)
        {
            checkSymbol = "X";
        }
        else
        {
            checkSymbol = " ";
        }
        Console.WriteLine($"[{checkSymbol}] {GetStringRepresentation()}");
    }

    public override string SaveGoal()
    {
        string lineToSave = "";
        lineToSave = $"{GetStringRepresentation()}, {IsCompleted().ToString()}";
        return lineToSave;
    }
}