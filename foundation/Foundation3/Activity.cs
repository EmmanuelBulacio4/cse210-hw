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

    //Getters
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

    //Setters
    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public void SetPace(double pace)
    {
        _pace = pace;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public virtual void GetSumary()
    {
    }

    public virtual double GetActivitySpeed()
    {
        return GetDuration()/GetDistance();
    }

    public double GetActivityPace()
    {
        double activityPace = GetDuration()/GetSpeed();
        return activityPace;
    }
}