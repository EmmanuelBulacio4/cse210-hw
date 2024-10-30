using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("MM/dd/yyy");
        List<Activity> activities = new List<Activity>();
        
        Running running = new Running();
        running.SetDate(date);
        running.SetDuration(45);
        running.SetDistance(5);
        double runSpeed = running.GetActivitySpeed();
        running.SetSpeed(runSpeed);
        double runPace = running.GetActivityPace();
        running.SetPace(runPace);
        activities.Add(running);


        Cycling cycling = new Cycling();
        cycling.SetDate(date);
        cycling.SetDuration(60);
        cycling.SetDistance(20);
        double bikeSpeed = cycling.GetActivitySpeed();
        cycling.SetSpeed(bikeSpeed);
        double bikePace = cycling.GetActivityPace();
        cycling.SetPace(bikePace);
        activities.Add(cycling);

        Swimming swimming = new Swimming();
        swimming.SetDate(date);
        swimming.SetDuration(50);
        swimming.SetLaps(3);
        double swimDistance = swimming.GetSwimDistance();
        swimming.SetDistance(swimDistance);
        double swimSpeed = swimming.GetActivitySpeed();
        swimming.SetSpeed(swimSpeed);
        double swimPace = swimming.GetActivityPace();
        swimming.SetPace(swimPace);
        activities.Add(swimming);

        //iterar por toda la lista activities y llamar al GetSummary()
        foreach (Activity activ in activities)
        {
            activ.GetSumary();
        }
    }
}