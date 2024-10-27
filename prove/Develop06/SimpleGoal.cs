using System;
public class SimpleGoal : Goal
{
    SimpleGoal(string name, string description, string point) : base(name, description, point)
    {
        _completedGoal = false;
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
}