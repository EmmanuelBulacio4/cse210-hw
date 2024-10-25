using System;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    CheckListGoal(string name, string description, string point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
    }

    //REcordEvent lo usa de la clase base

    //isComplete lo usa de la clase base

    public override string GetDetailString()
    {
        return "";
    }

    //GetDetailsRepresentation tambien lo toma de la clase base.
}