using System;
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _totalPoints;

    GoalManager()
    {
    }

    public void Start()
    {
        Goal goal = new();
        goal.SetGoal();
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetName());
        }
        //aqui seguro que es hacer un loop foreach y llamar el metodo que me devuelva el nombre.
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalAGP = GetTotalPoints();
            outputFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
private int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void LoadGoals()
    {

    }


}//Curlybrace final de la clase.