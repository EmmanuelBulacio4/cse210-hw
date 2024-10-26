using System;
using System.Runtime.InteropServices;
public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    protected Goal(string name, string description, string point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    //Getters

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoint()
    {
        return _points;
    }

    //Hacer tres setters

    public void RecordEvent()
    {
    }

    public bool isCompleted()
    {
        return false; //El false solo va para que no me muestre error en lo que escribo los demas metodos.
    }

    public virtual string GetDetailString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}