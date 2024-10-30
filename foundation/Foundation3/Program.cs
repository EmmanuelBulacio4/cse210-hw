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

        //running.GetSumary();

        Cycling cycling = new Cycling();
        cycling.SetDate(date);
        cycling.SetDuration(60);
        cycling.SetDistance(20);
        double bikeSpeed = cycling.GetActivitySpeed();
        cycling.SetSpeed(bikeSpeed);
        double bikePace = cycling.GetActivityPace();
        cycling.SetPace(bikePace);
        activities.Add(cycling);

        //cycling.GetSumary();

        Swimming swimming = new Swimming();


        //iterar por toda la lista activities y llamar al GetSummary()
        foreach (Activity activ in activities)
        {
            activ.GetSumary();
        }
    }
}