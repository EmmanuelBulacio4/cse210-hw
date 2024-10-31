using System;
using System.Reflection.Metadata.Ecma335;
public class EternalGoal : Goal
{
    private int _timesAchived;
    public EternalGoal()
    {
    }

    public EternalGoal(string name, string description, int Points)  //Constructor for LoadGoal()
    {
        SetName(name);
        SetDescription(description);
        SetPoint(Points);
    }

    public override void SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.WriteLine("Write a short description: ");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many point do you set to this goal? ");
        SetPoint(int.Parse(Console.ReadLine()));
        _timesAchived = 0;
    }

    //SetGoal() esta implicito.

        public override void ListGoal()
    {
        Console.WriteLine($"[ ] {DetailsGoal()}");
    }

    //DetailsGoal() esta implicito.

    public override string SaveGoal()
    {
        string lineToSave;
        lineToSave = $"{GetName()},{GetDescription()},{GetPoint()},{IsCompleted().ToString()}";
        return lineToSave;
    }

    public override void RecordEvent()
    {
        _timesAchived ++;
    }
    public override bool IsCompleted()
    {
        return false;
    }

    public override int TotalPoints()
    {
        int ePonits = GetPoint() * _timesAchived;
        return ePonits;
    }
}