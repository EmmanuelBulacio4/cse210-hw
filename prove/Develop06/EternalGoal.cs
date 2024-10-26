using System;
public class EternalGoal : Goal
{
    EternalGoal(string name, string description, string point)  : base(name, description, point)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Eternal Goals can be mark as 'Completed'");
    }
    //isCompleted() esta heredado
    //GetStringRepresentation() esta heredado
}