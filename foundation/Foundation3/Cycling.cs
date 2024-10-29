using System;
public class Cycling : Activity
{
    

    public Cycling()
    {
    }

        public override string GetSumary()
    {
        return $"{GetDate()} Cycling ({GetDuration()}min) - Distance {GetDistance()} kilometers, Speed {GetSpeed()}km/h, Pace: {GetPace()}min/km";
    }

}