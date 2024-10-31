using System;
using System.Runtime.InteropServices;
public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

    public Goal()
    {
    }

    public virtual void SetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("Write a short description: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many point do you set to this goal? ");
        _points = int.Parse(Console.ReadLine());
        _status = false;
    }

    //Getters
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoint()
    {
        return _points;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoint(int points)
    {
        _points = points;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public virtual void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public virtual bool IsCompleted() //Me verifica si la meta esta lograda o no.
    {
        return false;
    }

    public virtual string SaveGoal()
    {
        string lineToSave = "";
        return lineToSave;
    }
    public virtual void ListGoal() //debe mostrar el check de la meta. Luego llama a la DetailsGoal()
    {
        //Aqui marco si la meta esta cumplida. y 
        //los pasos completados.
    }

    public virtual string DetailsGoal()
    {
        return $"{GetName()} - ({GetDescription()})";
    }

    public virtual int TotalPoints()
    {
        return 0; //Debe cambiar en todas las otras clases.
    } 
}