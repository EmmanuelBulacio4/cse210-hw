using System;
using System.ComponentModel;
public class CheckListGoal : Goal
{
    private int _amountCompleted; //Es la cantidad de veces que cumplí con los pasos
    private int _target; //Es la cantidad de veces que tengo que cumplir la meta para lograrla
    private int _bonus; //la cantidad de puntos extras que recibo al completar la meta


    public CheckListGoal()
    {
    }

    public override void SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.WriteLine("Write a short description: ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many point do you set to this goal? ");
        SetPoint(int.Parse(Console.ReadLine()));
        Console.WriteLine("How many steps you need to take to achive this goal? ");
        _target = int.Parse(Console.ReadLine());
        _amountCompleted = 0;
        Console.WriteLine("How many points as bonus you get after completed this goal? ");
        _bonus = int.Parse(Console.ReadLine());
        SetStatus(false);
    }

    public override void ListGoal()
    {
        string checkSymbol = "";
        if(_amountCompleted < _target)
        {
            checkSymbol = "X";
        }
        else
        {
            checkSymbol = " ";
        }

        Console.WriteLine($"[{checkSymbol}] {DetailsGoal()}");
    }

    public override string DetailsGoal()
    {
        return $"{GetName()} - ({GetDescription()}) Currently completed: {_amountCompleted}/{_target}";
    }

    public override string SaveGoal()
    {
        string lineToSave;
        lineToSave = $"{GetName()},{GetDescription()},{GetPoint()},{_bonus},{_target},{_amountCompleted}";
        return lineToSave;
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

    public override int TotalPoints()
    {
        int clPoints;
        if  (_amountCompleted == _target)
        {
            clPoints = _target*GetPoint() + _bonus;
        }
        else{
            clPoints = _amountCompleted * GetPoint();
        }
        return clPoints;
    }
}