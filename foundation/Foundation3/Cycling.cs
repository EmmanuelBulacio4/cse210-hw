using System;
public class Cycling : Activity
{
    

    public Cycling()
    {
    }

        public override void GetSumary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetDuration()}min) - Distance {GetDistance()} kilometers, Speed {GetPace()} km/h, Pace: {GetSpeed()} min/km");
    }
}