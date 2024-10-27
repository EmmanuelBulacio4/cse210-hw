using System;
using System.ComponentModel;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    CheckListGoal(string name, string description, string point, int target, int amount, int bonus) : base(name, description, point)
    {
        _target = target;
        _amountCompleted = amount;
        _bonus = bonus;
    }

    public void ExtraGoal(string name, string point, int target, int amount, int bonus)
    {

    }
    

    // public void RecordEvent()
    // {
    //     if (IsCompleted() == false) {
    //         _completedGoal = true;
    //     } else {
    //         Console.WriteLine("You have already completed this goal.");
    //     }
    // }

    //isComplete lo usa de la clase base

    // public override string GetDetailString()
    // {
    //     return "";
    // }

    //GetDetailsRepresentation tambien lo toma de la clase base.
}