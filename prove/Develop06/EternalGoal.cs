using System;
public class EternalGoal : Goal
{
    EternalGoal(string name, string description, string point) //CReo que aqui seria apropiado usar unos getters para estabrecer valosres...analizar!
    {
        
    }

    public void RecordEvent()
    {

    }

    public bool isCompleted()
    {
        return false;
    }

    public string GetStringRepresentation()
    {
        return "";
    }
}