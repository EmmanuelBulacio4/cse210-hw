using System;
public class Activity
{
    private string _date;
    private int _duration;
    private double _pace;

    private double _distance;

    private double _speed;

    public Activity() //Constructor
    {
    }

    //Agregar otro constructor..quizas

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public double GetPace()
    {
        return _pace;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public virtual string GetSumary()
    {
        return "";
    }

    public virtual double GetActivitySpeed()
    {
        double activitySpeed = (GetDistance()/GetDuration())*60;
        return activitySpeed;
    }

    public double GetActivityPace()
    {
        double activityPace = 60/GetSpeed();
        return activityPace;
        //return _duration/_distance;
    }
}