using System;
public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    Goal(string name, string description, string point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

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