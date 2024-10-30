using System;
public class Running : Activity
{

    public Running()
    {
    }


    public override void GetSumary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetDuration()}min) - Distance {GetDistance()} kilometers, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/km"); 
    }

    // public override double GetActivitySpeed()
    // {
    //     return GetDuration()/GetDistance();
    // }
}