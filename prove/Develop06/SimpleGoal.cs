using System;
public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
    }

    public SimpleGoal(string name, string description, int Points, bool status)  //Constructor for LoadGoal()
    {
        SetName(name);
        SetDescription(description);
        SetPoint(Points);
        SetStatus(status);
    }


    //SetGoal de la clase base esta implicito.

    public override void ListGoal()
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

        Console.WriteLine($"[{checkSymbol}] {DetailsGoal()}");
    }

    //DetailsGoal() esta implicito.

    public override string SaveGoal()
    {
        string lineToSave = "";
        lineToSave = $"{GetName()},{GetDescription()},{GetPoint()},{IsCompleted().ToString()}";
        return lineToSave;
    }

    //El RecordEvent lo hereda de la clase base. No declaro nada diferente aqui.

    public override bool  IsCompleted()
    {
        if (GetStatus() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int TotalPoints()
    {
        bool status = IsCompleted();
        int gCounter = 0;
        if (status == true)
        {
            gCounter = GetPoint();
        }
        else
        {
            gCounter = 0;
        }
        return gCounter;
    }
}