using System;
public class Swimming : Activity
{
    private int _laps;

    public Swimming()
    {
    }

    public void SetLaps(int lap)
    {
        _laps = lap;
    }

    public int GetLaps()
    {
        return _laps;
    }


    public double GetSwimDistance()
    {
        double swimDistance = (_laps*50) / 1000.0;
        return swimDistance;
    }

    public override double GetActivitySpeed()
    {
        double swimSpeed = GetSwimDistance()/(GetDuration()/60.0);
        return swimSpeed;
    }

        public override double GetActivityPace()
    {
        return GetDuration()/GetDistance();
    }

        public override void GetSumary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetDuration()}min) - Distance {GetDistance()} kilometers, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/km");
    }

}