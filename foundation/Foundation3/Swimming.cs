using System;
public class Swimming : Activity
{
    private int _laps;

    public Swimming()
    {
    }

    public double GetActivityDistance()
    {
        double swimDistance = (_laps*50)/1000;
        return swimDistance;
    }

    public override double GetActivitySpeed()
    {
        double swimSpeed = GetActivityDistance()/GetDuration();
        return swimSpeed;
    }

        public override string GetSumary()
    {
        return $"{GetDate()} Swimming ({GetDuration()}min) - Distance {GetDistance()} kilometers, Speed {GetSpeed()}km/h, Pace: {GetPace()}min/km";
    }
}