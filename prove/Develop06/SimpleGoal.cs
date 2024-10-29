using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int point, bool iscompleted)
    {
        _shortName = name;
        _description = description;
        _points = point;
        _completedGoal = iscompleted;
    }

    public SimpleGoal()
    {

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

    //El RecordEvent lo hereda de la clase base. No declaro nada diferente aqui.

    public override void ShowCheck()
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
}